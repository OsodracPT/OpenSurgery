namespace Main_Project
{
    partial class PatientUserControl
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
            this.refreshBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.TestBtn = new System.Windows.Forms.Button();
            this.PrescriptionBtn = new System.Windows.Forms.Button();
            this.fileLbl = new System.Windows.Forms.Label();
            this.findInputTxtBox = new System.Windows.Forms.TextBox();
            this.userdataTableAdapter = new Main_Project.oversurgeryDataSetTableAdapters.userdataTableAdapter();
            this.oversurgeryDataSet = new Main_Project.oversurgeryDataSet();
            this.printButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oversurgeryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(11, 140);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(82, 42);
            this.refreshBtn.TabIndex = 25;
            this.refreshBtn.Text = "Show All \r\n Patients";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.PatientUserControl_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 166);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(427, 51);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(106, 58);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "Register new Patient";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // TestBtn
            // 
            this.TestBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestBtn.Location = new System.Drawing.Point(647, 51);
            this.TestBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(106, 58);
            this.TestBtn.TabIndex = 22;
            this.TestBtn.Text = "Tests";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // PrescriptionBtn
            // 
            this.PrescriptionBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionBtn.Location = new System.Drawing.Point(537, 51);
            this.PrescriptionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PrescriptionBtn.Name = "PrescriptionBtn";
            this.PrescriptionBtn.Size = new System.Drawing.Size(106, 58);
            this.PrescriptionBtn.TabIndex = 21;
            this.PrescriptionBtn.Text = "Prescription";
            this.PrescriptionBtn.UseVisualStyleBackColor = true;
            this.PrescriptionBtn.Click += new System.EventHandler(this.PrescriptionBtn_Click);
            // 
            // fileLbl
            // 
            this.fileLbl.AutoSize = true;
            this.fileLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLbl.Location = new System.Drawing.Point(8, 44);
            this.fileLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(115, 20);
            this.fileLbl.TabIndex = 19;
            this.fileLbl.Text = "Search Patient";
            // 
            // findInputTxtBox
            // 
            this.findInputTxtBox.Location = new System.Drawing.Point(12, 66);
            this.findInputTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.findInputTxtBox.Multiline = true;
            this.findInputTxtBox.Name = "findInputTxtBox";
            this.findInputTxtBox.Size = new System.Drawing.Size(225, 30);
            this.findInputTxtBox.TabIndex = 18;
            this.findInputTxtBox.TextChanged += new System.EventHandler(this.findInputTxtBox_TextChanged);
            this.findInputTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.findInputTxtBox_KeyPress);
            // 
            // userdataTableAdapter
            // 
            this.userdataTableAdapter.ClearBeforeFill = true;
            // 
            // oversurgeryDataSet
            // 
            this.oversurgeryDataSet.DataSetName = "oversurgeryDataSet";
            this.oversurgeryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(647, 155);
            this.printButton.Margin = new System.Windows.Forms.Padding(2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(106, 27);
            this.printButton.TabIndex = 27;
            this.printButton.Text = "Print Test";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // PatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.PrescriptionBtn);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.findInputTxtBox);
            this.Name = "PatientUserControl";
            this.Size = new System.Drawing.Size(769, 366);
            this.Load += new System.EventHandler(this.PatientUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oversurgeryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Button PrescriptionBtn;
        private System.Windows.Forms.Label fileLbl;
        private System.Windows.Forms.TextBox findInputTxtBox;
        private oversurgeryDataSetTableAdapters.userdataTableAdapter userdataTableAdapter;
        private oversurgeryDataSet oversurgeryDataSet;
        private System.Windows.Forms.Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
