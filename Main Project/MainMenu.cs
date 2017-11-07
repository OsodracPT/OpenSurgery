using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class overSurgeryTitle : Form
    {
        public overSurgeryTitle()
        {
            InitializeComponent();
            SidePanelScroll.Height = staffButton.Height;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
           
        }

        //https://www.youtube.com/watch?v=ao4HwEpW7eg
        //C# Tutorial : How to load User control dynamically | FoxLearn
        private void patientBtn_Click(object sender, EventArgs e)
        {
            //put the sidescroll panel in the correct place, selection
            SidePanelScroll.Height = patientBtn.Height;
            SidePanelScroll.Top = patientBtn.Top;

            if (!userControlPanel.Controls.Contains(PatientUserControl.Instance))
            {
                userControlPanel.Controls.Add(PatientUserControl.Instance);
                PatientUserControl.Instance.Dock = DockStyle.Fill;
                PatientUserControl.Instance.BringToFront();
            }
            else
                PatientUserControl.Instance.BringToFront();
        }

        private void appointBtn_Click(object sender, EventArgs e)
        {
            //put the sidescroll panel in the correct place, selection
            SidePanelScroll.Height = appointBtn.Height;
            SidePanelScroll.Top = appointBtn.Top;

            if (!userControlPanel.Controls.Contains(AppointmentUserControl.Instance))
            {
                userControlPanel.Controls.Add(AppointmentUserControl.Instance);
                AppointmentUserControl.Instance.Dock = DockStyle.Fill;
                AppointmentUserControl.Instance.BringToFront();
            }
            else
                AppointmentUserControl.Instance.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            //put the sidescroll panel in the correct place, selection
            SidePanelScroll.Height = staffButton.Height;
            SidePanelScroll.Top = staffButton.Top;

            if (!userControlPanel.Controls.Contains(StaffUserControl.Instance))
            {
                userControlPanel.Controls.Add(StaffUserControl.Instance);
                StaffUserControl.Instance.Dock = DockStyle.Fill;
                StaffUserControl.Instance.BringToFront();
            }
            else
                StaffUserControl.Instance.BringToFront();

        }

        private void singOutPicture_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }
    }
}
