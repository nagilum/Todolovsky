using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Todolovsky {
    public class TaskHandler {
        /// <summary>
        /// Loaded tasks.
        /// </summary>
        public static List<Task> Tasks { get; set; }

        /// <summary>
        /// File system watcher for the tasks JSON file.
        /// </summary>
        private static FileSystemWatcher fsw { get; set; }

        /// <summary>
        /// Path of the config files.
        /// </summary>
        private static string FilePath { get; set; }

        /// <summary>
        /// Initialize a file-system-watcher that automatically reloads the tasks
        /// JSON file if changed outside the app.
        /// </summary>
        public static void InitFileWatcher() {
            fsw = new FileSystemWatcher(
                FilePath,
                "*.json") {

                EnableRaisingEvents = true
            };

            fsw.Changed += (sender, args) => {
                if (args.Name == "todolovsky.tasks.json") {
                    LoadTasks();
                }
            };
        }

        /// <summary>
        /// Load tasks from disk.
        /// </summary>
        public static void LoadTasks() {
            try {
                Tasks = JsonConvert.DeserializeObject<List<Task>>(
                    File.ReadAllText(
                        GetTaskJsonFilePath()));

                fmMain mainForm = null;

                var mft = typeof(fmMain);
                var tft = typeof(fmTask);

                foreach (var form in Application.OpenForms) {
                    var ft = form.GetType();

                    if (ft.IsEquivalentTo(mft)) {
                        mainForm = form as fmMain;
                    }
                    else if (ft.IsEquivalentTo(tft)) {
                        var f = form as fmTask;

                        if (f == null) {
                            continue;
                        }

                        var t = Tasks
                            .FirstOrDefault(n => n.Id == f.Task.Id);

                        f.Invoke(new MethodInvoker(delegate {
                            if (t != null) {
                                f.Task = t;
                                f.UpdateTaskUi();
                            }
                            else {
                                // Task has been remove for some reason.
                                f.Close();
                            }
                        }));
                    }
                }

                if (mainForm != null) {
                    mainForm.Invoke(new MethodInvoker(delegate {
                        mainForm.PopuplateTasks();
                    }));
                }
            }
            catch {
                Tasks = new List<Task>();
            }
        }

        /// <summary>
        /// Save tasks to disk.
        /// </summary>
        public static void SaveTasks() {
            if (Tasks == null) {
                return;
            }

            try {
                File.WriteAllText(
                    GetTaskJsonFilePath(),
                    JsonConvert.SerializeObject(Tasks));
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Get the path for the tasks JSON file.
        /// </summary>
        /// <returns>Path.</returns>
        private static string GetTaskJsonFilePath() {
            FilePath = Application.StartupPath;

            return Path.Combine(
                FilePath,
                "todolovsky.tasks.json");
        }
    }
}