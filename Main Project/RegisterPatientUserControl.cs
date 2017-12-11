using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class RegisterPatientUserControl : UserControl
    {

        //singleton initiation
        private static RegisterPatientUserControl _instance;

        public static RegisterPatientUserControl Instance
        {
            get
            {
                //check if any previous instance was properly disposed
                if (_instance == null || _instance.IsDisposed == true)
                    _instance = new RegisterPatientUserControl();
                return _instance;
            }
        }

        public RegisterPatientUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that tries to register the patient into the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTxt.Text) || string.IsNullOrWhiteSpace(addressTxt.Text) || string.IsNullOrWhiteSpace(pstCodeTxt.Text) || string.IsNullOrWhiteSpace(pstCodeTxt.Text) || string.IsNullOrWhiteSpace(cityTxt.Text) || string.IsNullOrWhiteSpace(dobTimePick.Text) || string.IsNullOrWhiteSpace(phoneNumberTxt.Text))
            {
                // Message box
                MessageBox.Show("Please don't leave any blank space.");
            }
            else
            {
                try
                {
                    Logger.Instance.Log("RegisterPatientUserControl:registerBtn_Click() -> Registering a patient");

                    //Try to register patient by getting the data from the user input textboxes
                    //Convert the date time from the value picker to a desired value
                    string dobTemp = dobTimePick.Value.ToString("d");
                    DBConnection.getDBConnectionInstance().SqlStatementExecute(Constants.RegisterPatient(nameTxt.Text, addressTxt.Text, pstCodeTxt.Text, cityTxt.Text, dobTemp, phoneNumberTxt.Text));
                    //Show success message and close form
                    MessageBox.Show("Patient added successfully!");

                    PatientUserControl.RemoveRegister();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        /// <summary>
        /// Load method for the register patient user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterPatient_Load(object sender, EventArgs e)
        {
            //add maximum date to the date time picker
            dobTimePick.MaxDate = DateTime.Now;
        }

        //only allow number to be entered in the phone number text box
        private void phoneNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
