namespace Main_Project
{
    partial class Prescription
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
            this.dgvPrescription = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrescription
            // 
            this.dgvPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescription.Location = new System.Drawing.Point(31, 176);
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.RowTemplate.Height = 24;
            this.dgvPrescription.Size = new System.Drawing.Size(364, 151);
            this.dgvPrescription.TabIndex = 0;
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 353);
            this.Controls.Add(this.dgvPrescription);
            this.Name = "Prescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrescription;
    }
}