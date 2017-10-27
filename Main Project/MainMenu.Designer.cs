namespace Main_Project
{
    partial class MainMenu
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
            this.welcomeTxt = new System.Windows.Forms.Label();
            this.dgvUserdata = new System.Windows.Forms.DataGridView();
            this.userdataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oversurgeryDataSet = new Main_Project.oversurgeryDataSet();
            this.userdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userdataTableAdapter = new Main_Project.oversurgeryDataSetTableAdapters.userdataTableAdapter();
            this.staffLbl = new System.Windows.Forms.Label();
            this.patientBtn = new System.Windows.Forms.Button();
            this.appointBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.checkavailBtn = new System.Windows.Forms.Button();
            this.checkdutyBtn = new System.Windows.Forms.Button();
            this.checkfreeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oversurgeryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeTxt
            // 
            this.welcomeTxt.Location = new System.Drawing.Point(0, 0);
            this.welcomeTxt.Name = "welcomeTxt";
            this.welcomeTxt.Size = new System.Drawing.Size(100, 23);
            this.welcomeTxt.TabIndex = 2;
            // 
            // dgvUserdata
            // 
            this.dgvUserdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserdata.Location = new System.Drawing.Point(27, 297);
            this.dgvUserdata.Name = "dgvUserdata";
            this.dgvUserdata.RowTemplate.Height = 24;
            this.dgvUserdata.Size = new System.Drawing.Size(490, 191);
            this.dgvUserdata.TabIndex = 1;
            // 
            // userdataBindingSource1
            // 
            this.userdataBindingSource1.DataMember = "userdata";
            this.userdataBindingSource1.DataSource = this.oversurgeryDataSet;
            // 
            // oversurgeryDataSet
            // 
            this.oversurgeryDataSet.DataSetName = "oversurgeryDataSet";
            this.oversurgeryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userdataBindingSource
            // 
            this.userdataBindingSource.DataMember = "userdata";
            this.userdataBindingSource.DataSource = this.oversurgeryDataSet;
            // 
            // userdataTableAdapter
            // 
            this.userdataTableAdapter.ClearBeforeFill = true;
            // 
            // staffLbl
            // 
            this.staffLbl.AutoSize = true;
            this.staffLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLbl.Location = new System.Drawing.Point(52, 35);
            this.staffLbl.Name = "staffLbl";
            this.staffLbl.Size = new System.Drawing.Size(57, 25);
            this.staffLbl.TabIndex = 3;
            this.staffLbl.Text = "Staff";
            // 
            // patientBtn
            // 
            this.patientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientBtn.Location = new System.Drawing.Point(169, 26);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(116, 43);
            this.patientBtn.TabIndex = 4;
            this.patientBtn.Text = "Patient";
            this.patientBtn.UseVisualStyleBackColor = true;
            this.patientBtn.Click += new System.EventHandler(this.patientBtn_Click);
            // 
            // appointBtn
            // 
            this.appointBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointBtn.Location = new System.Drawing.Point(334, 26);
            this.appointBtn.Name = "appointBtn";
            this.appointBtn.Size = new System.Drawing.Size(153, 43);
            this.appointBtn.TabIndex = 5;
            this.appointBtn.Text = "Appointment";
            this.appointBtn.UseVisualStyleBackColor = true;
            this.appointBtn.Click += new System.EventHandler(this.appointBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(651, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(648, 83);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(98, 20);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Select date:";
            // 
            // checkavailBtn
            // 
            this.checkavailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkavailBtn.Location = new System.Drawing.Point(709, 175);
            this.checkavailBtn.Name = "checkavailBtn";
            this.checkavailBtn.Size = new System.Drawing.Size(142, 72);
            this.checkavailBtn.TabIndex = 8;
            this.checkavailBtn.Text = "Check Availability";
            this.checkavailBtn.UseVisualStyleBackColor = true;
            // 
            // checkdutyBtn
            // 
            this.checkdutyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkdutyBtn.Location = new System.Drawing.Point(709, 274);
            this.checkdutyBtn.Name = "checkdutyBtn";
            this.checkdutyBtn.Size = new System.Drawing.Size(142, 72);
            this.checkdutyBtn.TabIndex = 9;
            this.checkdutyBtn.Text = "Check on Duty";
            this.checkdutyBtn.UseVisualStyleBackColor = true;
            // 
            // checkfreeBtn
            // 
            this.checkfreeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkfreeBtn.Location = new System.Drawing.Point(709, 374);
            this.checkfreeBtn.Name = "checkfreeBtn";
            this.checkfreeBtn.Size = new System.Drawing.Size(142, 72);
            this.checkfreeBtn.TabIndex = 10;
            this.checkfreeBtn.Text = "Check Free";
            this.checkfreeBtn.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 510);
            this.Controls.Add(this.checkfreeBtn);
            this.Controls.Add(this.checkdutyBtn);
            this.Controls.Add(this.checkavailBtn);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.appointBtn);
            this.Controls.Add(this.patientBtn);
            this.Controls.Add(this.staffLbl);
            this.Controls.Add(this.dgvUserdata);
            this.Controls.Add(this.welcomeTxt);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oversurgeryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeTxt;
        private System.Windows.Forms.DataGridView dgvUserdata;
        private oversurgeryDataSet oversurgeryDataSet;
        private System.Windows.Forms.BindingSource userdataBindingSource;
        private oversurgeryDataSetTableAdapters.userdataTableAdapter userdataTableAdapter;
        private System.Windows.Forms.BindingSource userdataBindingSource1;
        private System.Windows.Forms.Label staffLbl;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.Button appointBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button checkavailBtn;
        private System.Windows.Forms.Button checkdutyBtn;
        private System.Windows.Forms.Button checkfreeBtn;
    }
}