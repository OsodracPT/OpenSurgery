namespace Main_Project
{
    partial class PatientForm
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
            this.appointBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.patientLbl = new System.Windows.Forms.Label();
            this.findInputTxtBox = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.fileLbl = new System.Windows.Forms.Label();
            this.PrescriptionBtn = new System.Windows.Forms.Button();
            this.TestBtn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.oversurgeryDataSet = new Main_Project.oversurgeryDataSet();
            this.userdataTableAdapter = new Main_Project.oversurgeryDataSetTableAdapters.userdataTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.userdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.oversurgeryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointBtn
            // 
            this.appointBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointBtn.Location = new System.Drawing.Point(332, 26);
            this.appointBtn.Name = "appointBtn";
            this.appointBtn.Size = new System.Drawing.Size(153, 43);
            this.appointBtn.TabIndex = 9;
            this.appointBtn.Text = "Appointment";
            this.appointBtn.UseVisualStyleBackColor = true;
            this.appointBtn.Click += new System.EventHandler(this.appointBtn_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.Location = new System.Drawing.Point(25, 26);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(116, 43);
            this.staffBtn.TabIndex = 8;
            this.staffBtn.Text = "Staff";
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // patientLbl
            // 
            this.patientLbl.AutoSize = true;
            this.patientLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLbl.Location = new System.Drawing.Point(198, 35);
            this.patientLbl.Name = "patientLbl";
            this.patientLbl.Size = new System.Drawing.Size(79, 25);
            this.patientLbl.TabIndex = 7;
            this.patientLbl.Text = "Patient";
            // 
            // findInputTxtBox
            // 
            this.findInputTxtBox.Location = new System.Drawing.Point(25, 99);
            this.findInputTxtBox.Multiline = true;
            this.findInputTxtBox.Name = "findInputTxtBox";
            this.findInputTxtBox.Size = new System.Drawing.Size(299, 36);
            this.findInputTxtBox.TabIndex = 10;
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Location = new System.Drawing.Point(344, 99);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(123, 36);
            this.findBtn.TabIndex = 12;
            this.findBtn.Text = "Find Patient";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // fileLbl
            // 
            this.fileLbl.AutoSize = true;
            this.fileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLbl.Location = new System.Drawing.Point(32, 261);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(102, 24);
            this.fileLbl.TabIndex = 11;
            this.fileLbl.Text = "Patient File";
            // 
            // PrescriptionBtn
            // 
            this.PrescriptionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionBtn.Location = new System.Drawing.Point(669, 297);
            this.PrescriptionBtn.Name = "PrescriptionBtn";
            this.PrescriptionBtn.Size = new System.Drawing.Size(133, 56);
            this.PrescriptionBtn.TabIndex = 13;
            this.PrescriptionBtn.Text = "Prescription";
            this.PrescriptionBtn.UseVisualStyleBackColor = true;
            this.PrescriptionBtn.Click += new System.EventHandler(this.PrescriptionBtn_Click);
            // 
            // TestBtn
            // 
            this.TestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestBtn.Location = new System.Drawing.Point(669, 371);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(133, 36);
            this.TestBtn.TabIndex = 14;
            this.TestBtn.Text = "Tests";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(669, 89);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(164, 83);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register new Patient";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // oversurgeryDataSet
            // 
            this.oversurgeryDataSet.DataSetName = "oversurgeryDataSet";
            this.oversurgeryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userdataTableAdapter
            // 
            this.userdataTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 179);
            this.dataGridView1.TabIndex = 16;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(150, 258);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(110, 33);
            this.refreshBtn.TabIndex = 17;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.PatientForm_Load_1);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 510);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.PrescriptionBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.findInputTxtBox);
            this.Controls.Add(this.appointBtn);
            this.Controls.Add(this.staffBtn);
            this.Controls.Add(this.patientLbl);
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.oversurgeryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appointBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Label patientLbl;
        private System.Windows.Forms.TextBox findInputTxtBox;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Label fileLbl;
        private System.Windows.Forms.Button PrescriptionBtn;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Button btnRegister;
        private oversurgeryDataSet oversurgeryDataSet;
        private System.Windows.Forms.BindingSource userdataBindingSource;
        private oversurgeryDataSetTableAdapters.userdataTableAdapter userdataTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refreshBtn;
    }
}