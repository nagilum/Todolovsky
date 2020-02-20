namespace Todolovsky
{
    partial class fmCalendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCalendar));
            this.obCalendar = new System.Windows.Forms.MonthCalendar();
            this.btOk = new System.Windows.Forms.Button();
            this.btUnset = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // obCalendar
            // 
            this.obCalendar.Location = new System.Drawing.Point(4, 4);
            this.obCalendar.MaxSelectionCount = 1;
            this.obCalendar.Name = "obCalendar";
            this.obCalendar.ShowWeekNumbers = true;
            this.obCalendar.TabIndex = 0;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(4, 167);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(70, 35);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btUnset
            // 
            this.btUnset.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btUnset.Location = new System.Drawing.Point(80, 167);
            this.btUnset.Name = "btUnset";
            this.btUnset.Size = new System.Drawing.Size(70, 35);
            this.btUnset.TabIndex = 2;
            this.btUnset.Text = "Unset";
            this.btUnset.UseVisualStyleBackColor = true;
            this.btUnset.Click += new System.EventHandler(this.btUnset_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(183, 167);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(70, 35);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // fmCalendar
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(256, 206);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btUnset);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.obCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCalendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.fmCalendar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar obCalendar;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btUnset;
        private System.Windows.Forms.Button btCancel;
    }
}