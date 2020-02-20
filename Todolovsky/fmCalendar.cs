using System;
using System.Windows.Forms;
using DateTime = System.DateTime;

namespace Todolovsky {
    public partial class fmCalendar : Form {
        public DateTimeOffset? SelectedDate { get; set; }

        /// <summary>
        /// Init all the things..
        /// </summary>
        public fmCalendar() {
            InitializeComponent();
        }

        /// <summary>
        /// Form load.
        /// </summary>
        private void fmCalendar_Load(object sender, EventArgs e) {
            if (this.SelectedDate.HasValue) {
                this.obCalendar.SelectionRange.Start = this.SelectedDate.Value.Date;
                this.obCalendar.SelectionRange.End = this.SelectedDate.Value.Date;
            }
            else {
                this.obCalendar.SelectionRange.Start = DateTime.Today;
                this.obCalendar.SelectionRange.End = DateTime.Today;
            }
        }

        /// <summary>
        /// Ok.
        /// </summary>
        private void btOk_Click(object sender, EventArgs e) {
            this.SelectedDate = this.obCalendar.SelectionRange.Start;
        }

        /// <summary>
        /// Unset the date.
        /// </summary>
        private void btUnset_Click(object sender, EventArgs e) {
            this.SelectedDate = null;
        }

        /// <summary>
        /// Close dialog.
        /// </summary>
        private void btCancel_Click(object sender, EventArgs e) { }
    }
}