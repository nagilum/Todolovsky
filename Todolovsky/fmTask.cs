using System;
using System.Linq;
using System.Windows.Forms;

namespace Todolovsky {
    public partial class fmTask : Form {
        /// <summary>
        /// Assigned task.
        /// </summary>
        public Task Task { get; set; }

        /// <summary>
        /// Init all the things..
        /// </summary>
        public fmTask() {
            InitializeComponent();
        }

        /// <summary>
        /// Form load.
        /// </summary>
        private void fmTask_Load(object sender, EventArgs e) {
            // Update the UI with task properties.
            this.UpdateTaskUi();
        }

        /// <summary>
        /// Update the UI with task properties.
        /// </summary>
        public void UpdateTaskUi() {
            // Text
            this.tbText.Text = this.Task.Text;

            // Due date.
            this.lbDueDate.Text = this.Task.Due.HasValue
                ? string.Format(
                    "Due: {0}",
                    this.Task.Due.Value.ToString("yyyy-MM-dd"))
                : null;
        }

        /// <summary>
        /// Save task.
        /// </summary>
        private void btSave_Click(object sender, EventArgs e) {
            // Text
            this.Task.Text = this.tbText.Text.Trim();

            // Initiate save proc.
            this.saveTask();
        }

        /// <summary>
        /// Mark as completed.
        /// </summary>
        private void btComplete_Click(object sender, EventArgs e) {
            var res = MessageBox.Show(
                "Are you sure?",
                "Mark as Complete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.No) {
                return;
            }

            this.Task.Completed = DateTimeOffset.Now;

            // Initiate save proc.
            this.saveTask();

            // Close form.
            this.Close();
        }

        /// <summary>
        /// Delete task.
        /// </summary>
        private void btDelete_Click(object sender, EventArgs e) {
            var res = MessageBox.Show(
                "Are you sure?",
                "Delete Task",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.No) {
                return;
            }

            this.Task.Deleted = DateTimeOffset.Now;

            // Initiate save proc.
            this.saveTask();

            // Close form.
            this.Close();
        }

        /// <summary>
        /// Set due date.
        /// </summary>
        private void btSetDueDate_Click(object sender, EventArgs e) {
            var dlg = new fmCalendar {
                SelectedDate = this.Task.Due
            };

            if (dlg.ShowDialog(this) == DialogResult.Cancel) {
                return;
            }

            // Set
            this.Task.Due = dlg.SelectedDate;

            // Preview
            this.lbDueDate.Text = this.Task.Due.HasValue
                ? string.Format(
                    "Due: {0}",
                    this.Task.Due.Value.ToString("yyyy-MM-dd"))
                : null;
        }

        /// <summary>
        /// Initiate save proc.
        /// </summary>
        private void saveTask() {
            var task = TaskHandler.Tasks
                .FirstOrDefault(n => n.Id == this.Task.Id);

            if (task == null) {
                MessageBox.Show(
                    "Something horrible happened!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            task.Created = this.Task.Created;
            task.Updated = DateTimeOffset.Now;
            task.Deleted = this.Task.Deleted;
            task.Due = this.Task.Due;
            task.Completed = this.Task.Completed;
            task.Text = this.Task.Text;

            TaskHandler.SaveTasks();
        }
    }
}