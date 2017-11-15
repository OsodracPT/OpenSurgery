namespace Main_Project
{
    partial class StaffUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkavailBtn = new System.Windows.Forms.Button();
            this.checkdutyBtn = new System.Windows.Forms.Button();
            this.checkfreeBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // checkavailBtn
            // 
            this.checkavailBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkavailBtn.Location = new System.Drawing.Point(574, 17);
            this.checkavailBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkavailBtn.Name = "checkavailBtn";
            this.checkavailBtn.Size = new System.Drawing.Size(141, 71);
            this.checkavailBtn.TabIndex = 13;
            this.checkavailBtn.Text = "Check Availability";
            this.checkavailBtn.UseVisualStyleBackColor = true;
            this.checkavailBtn.Click += new System.EventHandler(this.checkavailBtn_Click);
            // 
            // checkdutyBtn
            // 
            this.checkdutyBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkdutyBtn.Location = new System.Drawing.Point(721, 17);
            this.checkdutyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkdutyBtn.Name = "checkdutyBtn";
            this.checkdutyBtn.Size = new System.Drawing.Size(141, 71);
            this.checkdutyBtn.TabIndex = 14;
            this.checkdutyBtn.Text = "Check on Duty";
            this.checkdutyBtn.UseVisualStyleBackColor = true;
            this.checkdutyBtn.Click += new System.EventHandler(this.checkdutyBtn_Click);
            // 
            // checkfreeBtn
            // 
            this.checkfreeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkfreeBtn.Location = new System.Drawing.Point(868, 17);
            this.checkfreeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkfreeBtn.Name = "checkfreeBtn";
            this.checkfreeBtn.Size = new System.Drawing.Size(141, 71);
            this.checkfreeBtn.TabIndex = 15;
            this.checkfreeBtn.Text = "Check Free";
            this.checkfreeBtn.UseVisualStyleBackColor = true;
            this.checkfreeBtn.Click += new System.EventHandler(this.checkfreeBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(20, 109);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(966, 313);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(16, 40);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(120, 22);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Select date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 40);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // StaffUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkavailBtn);
            this.Controls.Add(this.checkdutyBtn);
            this.Controls.Add(this.checkfreeBtn);
            this.Controls.Add(this.dateLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffUserControl";
            this.Size = new System.Drawing.Size(1025, 450);
            this.Load += new System.EventHandler(this.StaffUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkavailBtn;
        private System.Windows.Forms.Button checkdutyBtn;
        private System.Windows.Forms.Button checkfreeBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
