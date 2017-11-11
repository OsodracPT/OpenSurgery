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
                if (_instance == null)
                    _instance = new RegisterPatientUserControl();
                return _instance;
            }
        }

        public RegisterPatientUserControl()
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

                PatientUserControl.RemoveRegister();
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

        private void RegisterPatientUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
