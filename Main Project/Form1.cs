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
    public partial class Form1 : Form
    {
        public Form1()
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
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
