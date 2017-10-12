using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Main_Project
{
    public partial class Form1 : Form
    {
        MySqlConnection myConn = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=assignmentdata;User Id=root;password=''");
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void databaseConnect_Click(object sender, EventArgs e)
        {
            DBConnect.OpenConnection();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            i = 0;

            try
            {
                myConn.Open();
                MySqlCommand cmd = myConn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select*from userdata where username='" + usernameTxt.Text + "' and password='" + passwordTxt.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable myDataTable = new DataTable();
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(cmd);
                myDataAdapter.Fill(myDataTable);
                i = Convert.ToInt32(myDataTable.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("You have entered an invalid username or password.");
                    myConn.Close();
                }
                else
                {
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    myConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Event_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
