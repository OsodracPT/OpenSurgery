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
    public partial class BookAppointUserControl : UserControl
    {


        //singleton initiation
        private static BookAppointUserControl _instance;

        public static BookAppointUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BookAppointUserControl();
                return _instance;
            }
        }

        public BookAppointUserControl()
        {
            InitializeComponent();
        }

        private void BookAppointUserControl_Load(object sender, EventArgs e)
        {

            FillComboBoxes();

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            try
            {


                //get all the user input
                string patientInput = patientCombox.Text;
                string staffInput = staffComboBox.Text;
                string timeInput = timeComboBox.Text + ":00";

                string date = dateTimePicker1.Text;

                string description = descriptionTxt.Text;

                //Try to register patient by getting the data from the user input textboxes
                DBConnection.getDBConnectionInstance().BookAppointment(date, timeInput, staffInput, patientInput, description);

                //Show success message and close form
                MessageBox.Show("Booking was successfull!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AppointmentUserControl.RemoveBook();
        }

        /// <summary>
        /// Method that fill the combo boxes with the correct data
        /// </summary>
        private void FillComboBoxes()
        {
            //get data to fill the patient combo box
            DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectPatientName);

            //get the table to be displayed from the data set
            DataTable dtPatient = dsPatient.Tables[0];

            for (int i = 0; i < dtPatient.Rows.Count; i++)
            {
                patientCombox.Items.Add(dtPatient.Rows[i]["patientName"]);
            }

            //get data to fill the staff combo box
            DataSet dsStaff = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectStaff);

            //get the table to be displayed from the data set
            DataTable dtStaff = dsStaff.Tables[0];

            for (int i = 0; i < dtStaff.Rows.Count; i++)
            {
                staffComboBox.Items.Add(dtStaff.Rows[i]["staffName"]);
            }

            //fill the time combo box
            for (int i = 8; i <= 24; i++)
                if (i < 10)
                    timeComboBox.Items.Add("0" + i + ":00");
                else
                    timeComboBox.Items.Add(i + ":00");
        }
    }
}
