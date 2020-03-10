using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Todolovsky {
    public partial class fmMain : Form {
        /// <summary>
        /// Init all the things..
        /// </summary>
        public fmMain() {
            InitializeComponent();

            // Load tasks from disk.
            TaskHandler.LoadTasks();

            // Initialize a file-system-watcher that automatically reloads the tasks
            // JSON file if changed outside the app.
            TaskHandler.InitFileWatcher();

            // Setup events.
            this.lvTasks.MouseDoubleClick += lvTasks_OnMouseDoubleClick;
            this.lvTasks.KeyUp += lvTasks_OnKeyUp;
            this.lvTasks.Resize += lvTasks_OnResize;
            this.tbNewTask.KeyUp += tbNewTask_OnKeyUp;
        }

        /// <summary>
        /// Form load.
        /// </summary>
        private void fmMain_Load(object sender, EventArgs e) {
            // Clean the interface and populate the tasks from the array.
            this.PopuplateTasks();

            // Force a resize of the list-view.
            this.lvTasks_OnResize(null, null);
        }

        /// <summary>
        /// Task list, on mouse dbl-click.
        /// </summary>
        private void lvTasks_OnMouseDoubleClick(object sender, MouseEventArgs e) {
            if (this.lvTasks.SelectedItems.Count == 0) {
                return;
            }

            this.openTask(this.lvTasks.SelectedItems[0]);
        }

        /// <summary>
        /// Task list, on key press.
        /// </summary>
        private void lvTasks_OnKeyUp(object sender, KeyEventArgs e) {
            if (this.lvTasks.SelectedItems.Count == 0) {
                return;
            }

            this.openTask(this.lvTasks.SelectedItems[0]);
        }

        /// <summary>
        /// Task list, on resize.
        /// </summary>
        private void lvTasks_OnResize(object sender, EventArgs e) {
            this.chDueDate.Width = 120;
            this.chText.Width = this.lvTasks.Width - (this.chDueDate.Width + 30);
        }

        /// <summary>
        /// On 'new task' input key-press.
        /// </summary>
        private void tbNewTask_OnKeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter) {
                return;
            }

            var text = this.tbNewTask.Text.Trim()
                .Replace("\r", "")
                .Replace("\n", "")
                .Trim();

            if (string.IsNullOrWhiteSpace(text)) {
                this.tbNewTask.Text = string.Empty;
                return;
            }

            // Add new task.
            TaskHandler.Tasks.Add(
                Task.NewTask(text));

            // Save tasks to disk.
            TaskHandler.SaveTasks();

            // Empty the input box.
            this.tbNewTask.Text = string.Empty;
        }

        /// <summary>
        /// Clean the interface and populate the tasks from the array.
        /// </summary>
        public void PopuplateTasks() {
            this.lvTasks.Items.Clear();

            if (TaskHandler.Tasks == null ||
                !TaskHandler.Tasks.Any()) {

                return;
            }

            var list = TaskHandler.Tasks
                .Where(n => !n.Deleted.HasValue &&
                            !n.Completed.HasValue &&
                            n.Due.HasValue)
                .OrderBy(n => n.Due)
                .ThenByDescending(n => n.Created)
                .ToList();

            list.AddRange(TaskHandler.Tasks
                .Where(n => !n.Deleted.HasValue &&
                            !n.Completed.HasValue &&
                            !n.Due.HasValue)
                .OrderByDescending(n => n.Created)
                .ToList());

            foreach (var task in list) {
                var item = new ListViewItem {
                    Tag = task.Id,
                    Text = task.Text
                };

                if (task.Due.HasValue) {
                    item.SubItems.Add(task.Due.Value.ToString("yyyy-MM-dd"));

                    if (task.Due.Value < DateTimeOffset.Now) {
                        item.ForeColor = Color.Red;
                    }
                }

                this.lvTasks.Items.Add(item);
            }
        }

        /// <summary>
        /// Open a task.
        /// </summary>
        /// <param name="item">Task.</param>
        private void openTask(ListViewItem item) {
            var id = item.Tag.ToString();
            var task = TaskHandler.Tasks
                .FirstOrDefault(n => n.Id == id);

            if (task == null) {
                MessageBox.Show(
                    string.Format(
                        "Unable to get task with id {0}. Aborting.",
                        id),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            fmTask taskForm = null;

            foreach (var form in Application.OpenForms) {
                if (!form.GetType().IsEquivalentTo(typeof(fmTask))) {
                    continue;
                }

                var temp = form as fmTask;

                if (temp == null ||
                    temp.Task == null ||
                    temp.Task.Id != task.Id) {
                    continue;
                }

                taskForm = temp;
                break;
            }

            if (taskForm == null) {
                taskForm = new fmTask {
                    Task = task,
                    Text = task.Text
                };
            }

            taskForm.Show();
            taskForm.BringToFront();
        }
    }
}