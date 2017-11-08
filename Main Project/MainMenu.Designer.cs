namespace Main_Project
{
    partial class overSurgeryTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(overSurgeryTitle));
            this.oversurgeryDataSet = new Main_Project.oversurgeryDataSet();
            this.userdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userdataTableAdapter = new Main_Project.oversurgeryDataSetTableAdapters.userdataTableAdapter();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.SidePanelScroll = new System.Windows.Forms.Panel();
            this.patientBtn = new System.Windows.Forms.Button();
            this.appointBtn = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.oversurgeryLogo = new System.Windows.Forms.PictureBox();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.singOutPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.oversurgeryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdataBindingSource)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oversurgeryLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singOutPicture)).BeginInit();
            this.SuspendLayout();
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
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.leftPanel.Controls.Add(this.SidePanelScroll);
            this.leftPanel.Controls.Add(this.patientBtn);
            this.leftPanel.Controls.Add(this.appointBtn);
            this.leftPanel.Controls.Add(this.staffButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(279, 670);
            this.leftPanel.TabIndex = 11;
            // 
            // SidePanelScroll
            // 
            this.SidePanelScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.SidePanelScroll.Location = new System.Drawing.Point(4, 204);
            this.SidePanelScroll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SidePanelScroll.Name = "SidePanelScroll";
            this.SidePanelScroll.Size = new System.Drawing.Size(13, 66);
            this.SidePanelScroll.TabIndex = 14;
            // 
            // patientBtn
            // 
            this.patientBtn.FlatAppearance.BorderSize = 0;
            this.patientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientBtn.ForeColor = System.Drawing.Color.White;
            this.patientBtn.Image = ((System.Drawing.Image)(resources.GetObject("patientBtn.Image")));
            this.patientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientBtn.Location = new System.Drawing.Point(16, 362);
            this.patientBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(263, 66);
            this.patientBtn.TabIndex = 7;
            this.patientBtn.Text = "           Patient";
            this.patientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientBtn.UseVisualStyleBackColor = true;
            this.patientBtn.Click += new System.EventHandler(this.patientBtn_Click);
            // 
            // appointBtn
            // 
            this.appointBtn.FlatAppearance.BorderSize = 0;
            this.appointBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointBtn.ForeColor = System.Drawing.Color.White;
            this.appointBtn.Image = ((System.Drawing.Image)(resources.GetObject("appointBtn.Image")));
            this.appointBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointBtn.Location = new System.Drawing.Point(16, 278);
            this.appointBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.appointBtn.Name = "appointBtn";
            this.appointBtn.Size = new System.Drawing.Size(263, 66);
            this.appointBtn.TabIndex = 6;
            this.appointBtn.Text = "           Appointment";
            this.appointBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.appointBtn.UseVisualStyleBackColor = true;
            this.appointBtn.Click += new System.EventHandler(this.appointBtn_Click);
            // 
            // staffButton
            // 
            this.staffButton.FlatAppearance.BorderSize = 0;
            this.staffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffButton.ForeColor = System.Drawing.Color.White;
            this.staffButton.Image = ((System.Drawing.Image)(resources.GetObject("staffButton.Image")));
            this.staffButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffButton.Location = new System.Drawing.Point(16, 204);
            this.staffButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(263, 66);
            this.staffButton.TabIndex = 5;
            this.staffButton.Text = "           Staff";
            this.staffButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.staffButton.UseVisualStyleBackColor = true;
            this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(279, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1068, 12);
            this.topPanel.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.oversurgeryLogo);
            this.panel3.Location = new System.Drawing.Point(324, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 176);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Over Surgery";
            // 
            // oversurgeryLogo
            // 
            this.oversurgeryLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("oversurgeryLogo.ErrorImage")));
            this.oversurgeryLogo.Image = ((System.Drawing.Image)(resources.GetObject("oversurgeryLogo.Image")));
            this.oversurgeryLogo.Location = new System.Drawing.Point(21, 32);
            this.oversurgeryLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oversurgeryLogo.Name = "oversurgeryLogo";
            this.oversurgeryLogo.Size = new System.Drawing.Size(103, 87);
            this.oversurgeryLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oversurgeryLogo.TabIndex = 14;
            this.oversurgeryLogo.TabStop = false;
            // 
            // userControlPanel
            // 
            this.userControlPanel.Location = new System.Drawing.Point(305, 204);
            this.userControlPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(1025, 450);
            this.userControlPanel.TabIndex = 16;
            // 
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("closePictureBox.InitialImage")));
            this.closePictureBox.Location = new System.Drawing.Point(1271, 32);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(39, 39);
            this.closePictureBox.TabIndex = 15;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // singOutPicture
            // 
            this.singOutPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singOutPicture.Image = ((System.Drawing.Image)(resources.GetObject("singOutPicture.Image")));
            this.singOutPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("singOutPicture.InitialImage")));
            this.singOutPicture.Location = new System.Drawing.Point(1224, 32);
            this.singOutPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.singOutPicture.Name = "singOutPicture";
            this.singOutPicture.Size = new System.Drawing.Size(39, 39);
            this.singOutPicture.TabIndex = 17;
            this.singOutPicture.TabStop = false;
            this.singOutPicture.Click += new System.EventHandler(this.singOutPicture_Click);
            // 
            // overSurgeryTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 670);
            this.Controls.Add(this.singOutPicture);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.userControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "overSurgeryTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.oversurgeryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdataBindingSource)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oversurgeryLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singOutPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private oversurgeryDataSet oversurgeryDataSet;
        private System.Windows.Forms.BindingSource userdataBindingSource;
        private oversurgeryDataSetTableAdapters.userdataTableAdapter userdataTableAdapter;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.Button appointBtn;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox oversurgeryLogo;
        private System.Windows.Forms.Panel SidePanelScroll;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Panel userControlPanel;
        private System.Windows.Forms.PictureBox singOutPicture;
    }
}