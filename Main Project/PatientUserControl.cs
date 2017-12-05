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
        private bool testfocus = false;

        //singleton initiation
        private static PatientUserControl _instance;

        public static PatientUserControl Instance
        {
            get
            {
                //check if any previous instance was properly disposed
                if (_instance == null || _instance.IsDisposed == true)
                    _instance = new PatientUserControl();
                return _instance;
            }
        }

        public PatientUserControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button that initialises the register patient usercontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            testfocus = false;

            Instance.Controls.Add(RegisterPatientUserControl.Instance);


            RegisterPatientUserControl.Instance.Dock = DockStyle.Fill;
            RegisterPatientUserControl.Instance.BringToFront();

        }

        /// <summary>
        /// Method that removes any usercontrol present in front of the patient usercontrol
        /// </summary>
        public static void RemoveRegister()
        {
            Instance.Controls.Remove(RegisterPatientUserControl.Instance);
        }

        /// <summary>
        /// Method that runs whenever the user enter a key in order to find a patient in the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findBtn_Click(object sender, EventArgs e)
        {

            DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.FindPatient(findInputTxtBox.Text));

            //get the table to be displayed from the data set
            DataTable dtPatient = dsPatient.Tables[0];

            //set the data source for the data grid view
            dataGridView1.DataSource = dtPatient;

        }

        /// <summary>
        /// Method for the prescription button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrescriptionBtn_Click(object sender, EventArgs e)
        {
            testfocus = false;
            try
            {
                string DGCell = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);


                DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.SelectPrescription(DGCell));
                DataTable dtPatient = dsPatient.Tables[0];
                dataGridView1.DataSource = dtPatient;

            }
            catch (Exception ex)
            {

            }
        }



        private void PatientUserControl_Load(object sender, EventArgs e)
        {
            testfocus = false;
            // TODO: This line of code loads data into the 'oversurgeryDataSet.userdata' table. You can move, or remove it, as needed.
            this.userdataTableAdapter.Fill(this.oversurgeryDataSet.userdata);

            DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectPatient);

            //get the table to be displayed from the data set
            DataTable dtPatient = dsPatient.Tables[0];

            //set the data source for the data grid view
            dataGridView1.DataSource = dtPatient;
        }

        internal void PatientUserControlRefresh()
        {
            refreshBtn.PerformClick();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            testfocus = false;
        }

        private void findInputTxtBox_TextChanged(object sender, EventArgs e)
        {
            testfocus = false;
        }

        /// <summary>
        /// Test button click method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestBtn_Click(object sender, EventArgs e)
        {
            testfocus = true;
            try
            {
                string DGCell = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);


                DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.SelectPatientTest(DGCell));
                DataTable dtPatient = dsPatient.Tables[0];
                dataGridView1.DataSource = dtPatient;

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Method that prints the test results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printButton_Click(object sender, EventArgs e)
        {
            if (testfocus == true)
            {
                //Printing the Contents
                //https://www.codeproject.com/Articles/28046/Printing-of-DataGridView


                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument1;
                printDialog.UseEXDialog = true;
                //Get the document
                if (DialogResult.OK == printDialog.ShowDialog())
                {
                    printDocument1.DocumentName = "Test Page Print";
                    printDocument1.Print();
                }

            }
            else
            {
                MessageBox.Show("Please Select Tests then a Patient");
            }
        }
    }
}


