namespace Todolovsky
{
    partial class fmTask
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTask));
            this.tbText = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbDueDate = new System.Windows.Forms.Label();
            this.btSetDueDate = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbText.Location = new System.Drawing.Point(6, 46);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(455, 156);
            this.tbText.TabIndex = 6;
            // 
            // lbDueDate
            // 
            this.lbDueDate.Location = new System.Drawing.Point(341, 5);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(120, 21);
            this.lbDueDate.TabIndex = 9;
            this.lbDueDate.Text = "DueDate";
            this.lbDueDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btSetDueDate
            // 
            this.btSetDueDate.Image = global::Todolovsky.Properties.Resources.exclamation_mark_red_icon;
            this.btSetDueDate.Location = new System.Drawing.Point(134, 5);
            this.btSetDueDate.Name = "btSetDueDate";
            this.btSetDueDate.Size = new System.Drawing.Size(40, 35);
            this.btSetDueDate.TabIndex = 8;
            this.toolTip.SetToolTip(this.btSetDueDate, "Set Due Date");
            this.btSetDueDate.UseVisualStyleBackColor = true;
            this.btSetDueDate.Click += new System.EventHandler(this.btSetDueDate_Click);
            // 
            // btSave
            // 
            this.btSave.Image = global::Todolovsky.Properties.Resources.disk_save_yellow_icon;
            this.btSave.Location = new System.Drawing.Point(5, 5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(40, 35);
            this.btSave.TabIndex = 0;
            this.toolTip.SetToolTip(this.btSave, "Save");
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.Image = global::Todolovsky.Properties.Resources.cancel_icon;
            this.btDelete.Location = new System.Drawing.Point(91, 5);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(40, 35);
            this.btDelete.TabIndex = 3;
            this.toolTip.SetToolTip(this.btDelete, "Delete");
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btComplete
            // 
            this.btComplete.Image = global::Todolovsky.Properties.Resources.ok_icon;
            this.btComplete.Location = new System.Drawing.Point(48, 5);
            this.btComplete.Name = "btComplete";
            this.btComplete.Size = new System.Drawing.Size(40, 35);
            this.btComplete.TabIndex = 1;
            this.toolTip.SetToolTip(this.btComplete, "Mark as Completed");
            this.btComplete.UseVisualStyleBackColor = true;
            this.btComplete.Click += new System.EventHandler(this.btComplete_Click);
            // 
            // fmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(466, 207);
            this.Controls.Add(this.lbDueDate);
            this.Controls.Add(this.btSetDueDate);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btComplete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmTask";
            this.Text = "fmTask";
            this.Load += new System.EventHandler(this.fmTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btComplete;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btSetDueDate;
        private System.Windows.Forms.Label lbDueDate;
    }
}