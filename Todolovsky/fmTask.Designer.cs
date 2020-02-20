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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTask));
            this.label1 = new System.Windows.Forms.Label();
            this.lbCreated = new System.Windows.Forms.Label();
            this.lbUpdated = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btComplete = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.dtDue = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created:";
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Location = new System.Drawing.Point(90, 9);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(16, 13);
            this.lbCreated.TabIndex = 1;
            this.lbCreated.Text = "...";
            // 
            // lbUpdated
            // 
            this.lbUpdated.AutoSize = true;
            this.lbUpdated.Location = new System.Drawing.Point(90, 30);
            this.lbUpdated.Name = "lbUpdated";
            this.lbUpdated.Size = new System.Drawing.Size(16, 13);
            this.lbUpdated.TabIndex = 3;
            this.lbUpdated.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Updated:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Due:";
            // 
            // btComplete
            // 
            this.btComplete.Location = new System.Drawing.Point(111, 74);
            this.btComplete.Name = "btComplete";
            this.btComplete.Size = new System.Drawing.Size(90, 34);
            this.btComplete.TabIndex = 1;
            this.btComplete.Text = "Mark as Completed";
            this.btComplete.UseVisualStyleBackColor = true;
            this.btComplete.Click += new System.EventHandler(this.btComplete_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(207, 74);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(90, 34);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Delete Task";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(15, 74);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(90, 34);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(15, 114);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(377, 161);
            this.tbText.TabIndex = 6;
            // 
            // dtDue
            // 
            this.dtDue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDue.Location = new System.Drawing.Point(92, 46);
            this.dtDue.Name = "dtDue";
            this.dtDue.Size = new System.Drawing.Size(106, 20);
            this.dtDue.TabIndex = 7;
            // 
            // fmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 287);
            this.Controls.Add(this.dtDue);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btComplete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbUpdated);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCreated);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmTask";
            this.Text = "fmTask";
            this.Load += new System.EventHandler(this.fmTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.Label lbUpdated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btComplete;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.DateTimePicker dtDue;
    }
}