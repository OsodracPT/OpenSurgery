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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkavailBtn = new System.Windows.Forms.Button();
            this.checkdutyBtn = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dgvUserdata = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 14);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // checkavailBtn
            // 
            this.checkavailBtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkavailBtn.Location = new System.Drawing.Point(522, 11);
            this.checkavailBtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkavailBtn.Name = "checkavailBtn";
            this.checkavailBtn.Size = new System.Drawing.Size(106, 58);
            this.checkavailBtn.TabIndex = 13;
            this.checkavailBtn.Text = "Available Staff";
            this.checkavailBtn.UseVisualStyleBackColor = true;
            // 
            // checkdutyBtn
            // 
            this.checkdutyBtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkdutyBtn.Location = new System.Drawing.Point(412, 11);
            this.checkdutyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkdutyBtn.Name = "checkdutyBtn";
            this.checkdutyBtn.Size = new System.Drawing.Size(106, 58);
            this.checkdutyBtn.TabIndex = 14;
            this.checkdutyBtn.Text = "Check on Duty";
            this.checkdutyBtn.UseVisualStyleBackColor = true;
            this.checkdutyBtn.Click += new System.EventHandler(this.checkdutyBtn_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dateLabel.Location = new System.Drawing.Point(31, 17);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(82, 17);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Select date:";
            // 
            // dgvUserdata
            // 
            this.dgvUserdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(127)))), ((int)(((byte)(184)))));
            this.dgvUserdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUserdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserdata.Location = new System.Drawing.Point(24, 73);
            this.dgvUserdata.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUserdata.Name = "dgvUserdata";
            this.dgvUserdata.RowTemplate.Height = 24;
            this.dgvUserdata.Size = new System.Drawing.Size(719, 270);
            this.dgvUserdata.TabIndex = 20;
            this.dgvUserdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserdata_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button2.Location = new System.Drawing.Point(632, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 58);
            this.button2.TabIndex = 22;
            this.button2.Text = "Show All Staff";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // StaffUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvUserdata);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkavailBtn);
            this.Controls.Add(this.checkdutyBtn);
            this.Controls.Add(this.dateLabel);
            this.Name = "StaffUserControl";
            this.Size = new System.Drawing.Size(769, 366);
            this.Load += new System.EventHandler(this.StaffUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button checkavailBtn;
        private System.Windows.Forms.Button checkdutyBtn;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataGridView dgvUserdata;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
