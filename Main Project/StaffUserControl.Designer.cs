﻿namespace Main_Project
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkavailBtn = new System.Windows.Forms.Button();
            this.checkdutyBtn = new System.Windows.Forms.Button();
            this.checkfreeBtn = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dgvUserdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(587, 81);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // checkavailBtn
            // 
            this.checkavailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkavailBtn.Location = new System.Drawing.Point(607, 130);
            this.checkavailBtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkavailBtn.Name = "checkavailBtn";
            this.checkavailBtn.Size = new System.Drawing.Size(106, 58);
            this.checkavailBtn.TabIndex = 13;
            this.checkavailBtn.Text = "Check Availability";
            this.checkavailBtn.UseVisualStyleBackColor = true;
            // 
            // checkdutyBtn
            // 
            this.checkdutyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkdutyBtn.Location = new System.Drawing.Point(607, 202);
            this.checkdutyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkdutyBtn.Name = "checkdutyBtn";
            this.checkdutyBtn.Size = new System.Drawing.Size(106, 58);
            this.checkdutyBtn.TabIndex = 14;
            this.checkdutyBtn.Text = "Check on Duty";
            this.checkdutyBtn.UseVisualStyleBackColor = true;
            // 
            // checkfreeBtn
            // 
            this.checkfreeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkfreeBtn.Location = new System.Drawing.Point(607, 274);
            this.checkfreeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkfreeBtn.Name = "checkfreeBtn";
            this.checkfreeBtn.Size = new System.Drawing.Size(106, 58);
            this.checkfreeBtn.TabIndex = 15;
            this.checkfreeBtn.Text = "Check Free";
            this.checkfreeBtn.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(489, 81);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(83, 17);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Select date:";
            // 
            // dgvUserdata
            // 
            this.dgvUserdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserdata.Location = new System.Drawing.Point(60, 144);
            this.dgvUserdata.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUserdata.Name = "dgvUserdata";
            this.dgvUserdata.RowTemplate.Height = 24;
            this.dgvUserdata.Size = new System.Drawing.Size(488, 155);
            this.dgvUserdata.TabIndex = 16;
            // 
            // StaffUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvUserdata);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkavailBtn);
            this.Controls.Add(this.checkdutyBtn);
            this.Controls.Add(this.checkfreeBtn);
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
        private System.Windows.Forms.Button checkfreeBtn;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataGridView dgvUserdata;
    }
}