using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class PatientUserControl : UserControl
    {

        //singleton initiation
        private static PatientUserControl _instance;

        public static PatientUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PatientUserControl();
                return _instance;
            }
        }

        public PatientUserControl()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterPatient registerForm = new RegisterPatient();
            registerForm.Show();
        }


        private void findBtn_Click(object sender, EventArgs e)
        {

            DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.FindPatient(findInputTxtBox.Text));

            //get the table to be displayed from the data set
            DataTable dtPatient = dsPatient.Tables[0];

            //set the data source for the data grid view
            dataGridView1.DataSource = dtPatient;

        }

        private void PrescriptionBtn_Click(object sender, EventArgs e)
        {
            Prescription prescriptionForm = new Prescription();
            prescriptionForm.Show();
        }


        private void TestBtn_Click(object sender, EventArgs e)
        {
            TestsForm testForm = new TestsForm();
            testForm.Show();
        }

        private void PatientUserControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oversurgeryDataSet.userdata' table. You can move, or remove it, as needed.
            this.userdataTableAdapter.Fill(this.oversurgeryDataSet.userdata);

            DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectPatient);

            //get the table to be displayed from the data set
            DataTable dtPatient = dsPatient.Tables[0];

            //set the data source for the data grid view
            dataGridView1.DataSource = dtPatient;
        }

        //Check for any special characters and prevent the user from typing them.
        private void findInputTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                Console.WriteLine("Invalid Character inserted");
            }
            //if there are no special characters then we can run the find method and connect the string to the DB
            else
            {
                findBtn_Click(sender, e);
            }
        }
    }
}


