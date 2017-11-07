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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            overSurgeryTitle mainMenu = new overSurgeryTitle();
            mainMenu.Show();

        }

        private void appointBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm appointForm = new AppointmentForm();
            appointForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterPatient registerForm = new RegisterPatient();
            registerForm.Show();
        }

        private void PatientForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oversurgeryDataSet.userdata' table. You can move, or remove it, as needed.
            this.userdataTableAdapter.Fill(this.oversurgeryDataSet.userdata);

            DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectPatient);

            //get the table to be displayed from the data set
            DataTable dtPatient = dsPatient.Tables[0];

            //set the data source for the data grid view
            dataGridView1.DataSource = dtPatient;

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
    }
}
