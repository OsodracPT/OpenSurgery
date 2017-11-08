using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Main_Project
{
    public partial class LoginForm : Form
    {

        public static string UsernameText;


        public LoginForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Login button method that checks for the right credentials
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            int i = 0;

            try
            {

                i = DBConnection.getDBConnectionInstance().TryLogin(txtUsername.Text, txtPassword.Text);

                if (i == 0)
                {
                    MessageBox.Show("You have entered an invalid username or password.");
                }
                else
                {
                    this.Hide();
                    overSurgeryTitle mainMenu = new overSurgeryTitle();
                    //Rom addition
                    UsernameText = txtUsername.Text;
                    //
                    mainMenu.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //method that runs whenever we click the exit button. closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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

        //event for the Login form. Runs whenever we hold the mouse button down
        private void LoginForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
