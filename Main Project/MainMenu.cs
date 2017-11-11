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
        }

        /// <summary>
        /// the form loads already selecting the staff usercontrol
        /// this method ensures that
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Load(object sender, EventArgs e)
        {

            userLbl.Text = LoginForm.UsernameText;


            //moves the selection side scroll to the correct position(selecting staff)
            SidePanelScroll.Height = staffButton.Height;

            //starts the main menu with the staff user control already in front
            if (!userControlPanel.Controls.Contains(StaffUserControl.Instance))
            {
                userControlPanel.Controls.Add(StaffUserControl.Instance);
                StaffUserControl.Instance.Dock = DockStyle.Fill;
                StaffUserControl.Instance.BringToFront();
            }
            else
                StaffUserControl.Instance.BringToFront();
        }

        //https://www.youtube.com/watch?v=ao4HwEpW7eg
        //C# Tutorial : How to load User control dynamically | FoxLearn
        private void patientBtn_Click(object sender, EventArgs e)
        {
            //put the sidescroll panel in the correct place, selection
            SidePanelScroll.Height = patientBtn.Height;
            SidePanelScroll.Top = patientBtn.Top;

            //remove register patient if it is present in the panel.
            PatientUserControl.RemoveRegister();


            if (!userControlPanel.Controls.Contains(PatientUserControl.Instance))
            {
                userControlPanel.Controls.Add(PatientUserControl.Instance);
                PatientUserControl.Instance.Dock = DockStyle.Fill;
                PatientUserControl.Instance.BringToFront();
            }
            else
                PatientUserControl.Instance.BringToFront();
        }

        /// <summary>
        /// Method runs when the user clicks the appointments button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void appointBtn_Click(object sender, EventArgs e)
        {
            //put the sidescroll panel in the correct place, selection
            SidePanelScroll.Height = appointBtn.Height;
            SidePanelScroll.Top = appointBtn.Top;

            //removes "booking appointment" if it is present in the panel.
            AppointmentUserControl.RemoveBook();

            if (!userControlPanel.Controls.Contains(AppointmentUserControl.Instance))
            {
                userControlPanel.Controls.Add(AppointmentUserControl.Instance);
                AppointmentUserControl.Instance.Dock = DockStyle.Fill;
                AppointmentUserControl.Instance.BringToFront();
            }
            else
                AppointmentUserControl.Instance.BringToFront();
        }

        /// <summary>
        /// Method that runs when the user clicks the exit button. It closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// method the log the user out, presenting the login form again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void singOutPicture_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }

        //Code that will make the form movable
        //got it from stack overflow
        //https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //event for the main form. Run whenever we hold the mouse button down
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
