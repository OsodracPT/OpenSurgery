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
            this.appointBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.patientLbl = new System.Windows.Forms.Label();
            this.dgvUserdata = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.fileLbl = new System.Windows.Forms.Label();
            this.PrescriptionBtn = new System.Windows.Forms.Button();
            this.TestBtn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserdata)).BeginInit();
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
            // dgvUserdata
            // 
            this.dgvUserdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserdata.Location = new System.Drawing.Point(25, 297);
            this.dgvUserdata.Name = "dgvUserdata";
            this.dgvUserdata.RowTemplate.Height = 24;
            this.dgvUserdata.Size = new System.Drawing.Size(490, 191);
            this.dgvUserdata.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 36);
            this.textBox1.TabIndex = 10;
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
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 510);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.PrescriptionBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.appointBtn);
            this.Controls.Add(this.staffBtn);
            this.Controls.Add(this.patientLbl);
            this.Controls.Add(this.dgvUserdata);
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appointBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Label patientLbl;
        private System.Windows.Forms.DataGridView dgvUserdata;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Label fileLbl;
        private System.Windows.Forms.Button PrescriptionBtn;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Button btnRegister;
    }
}