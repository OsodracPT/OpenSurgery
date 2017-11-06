using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main_Project
{
    public partial class RegisterPatient : Form
    {
        public RegisterPatient()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

            try
            {
                //Try to register patient by getting the data from the user input textboxes
                DBConnection.getDBConnectionInstance().RegisterPatient(nameTxt.Text, addressTxt.Text, pstCodeTxt.Text, cityTxt.Text, dobTimePick.Value, Convert.ToInt32(phoneNumberTxt.Text));

                //Show success message and close form
                MessageBox.Show("Patient added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterPatient_Load(object sender, EventArgs e)
        {
            dobTimePick.MaxDate = DateTime.Now;
        }
    }
}
