namespace Main_Project
{
    partial class AppointmentUserControl
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.dgvUserdata = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnEdit.Location = new System.Drawing.Point(632, 13);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 54);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnBook.Location = new System.Drawing.Point(517, 13);
            this.btnBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(111, 54);
            this.btnBook.TabIndex = 22;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
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
            this.dgvUserdata.TabIndex = 19;
            this.dgvUserdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserdata_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button1.Location = new System.Drawing.Point(24, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Select Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dateTimePicker1.TabIndex = 28;
            // 
            // AppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dgvUserdata);
            this.Name = "AppointmentUserControl";
            this.Size = new System.Drawing.Size(769, 366);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.DataGridView dgvUserdata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
