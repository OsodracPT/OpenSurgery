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
                //check if any previous instance was properly disposed

                if (_instance == null || _instance.IsDisposed == true)
                    _instance = new BookAppointUserControl();
                return _instance;
            }
        }

        public BookAppointUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load method for the book appointment user control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookAppointUserControl_Load(object sender, EventArgs e)
        {

            //fill the combo boxes with data from the database
            FillComboBoxes();

        }


        //Button Related Methods

        /// <summary>
        /// Method that tries to book an appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookBtn_Click(object sender, EventArgs e)
        {
            try
            {

                //get all the user input from the combo boxes
                string patientInput = patientCombox.Text;
                string staffInput = staffComboBox.Text;
                string timeInput = timeComboBox.Text + ":00";

                string date = dateTimePicker1.Text;

                string description = descriptionTxt.Text;

                //check if all the combo boxes have values selected and then run the code
                if (patientCombox.Text != String.Empty && staffComboBox.Text != String.Empty && timeComboBox.Text != String.Empty)
                {
                    //Add this appointment as a shift to a staff member
                    //get the staff id based on the name selected by the user in the combo box
                    string str = DBConnection.getDBConnectionInstance().GetStringValue(Constants.GetStaffID(staffInput));


                    int staffID = Convert.ToInt32(str);

                    //check too see if the staff member is already busy
                    int i = 0;

                    try
                    {

                        i = DBConnection.getDBConnectionInstance().CheckStaffBusy(staffID, date, timeInput);

                        if (i != 0)
                        {
                            MessageBox.Show("The staff member selected is already busy in that time period.");
                        }
                        else
                        {
                            //Try to register patient by getting the data from the user input textboxes
                            DBConnection.getDBConnectionInstance().SqlStatementExecute(Constants.BookAppointment(date, timeInput, staffInput, patientInput, description, staffID));


                            Console.WriteLine(date + " " + timeInput + " " + AddHourTime(timeInput) + " " + staffID);

                            //Need to get the id from the appointment created
                            string appointID = DBConnection.getDBConnectionInstance().GetStringValue(Constants.GetAppointmentNoID(date, timeInput, staffInput, patientInput, description, staffID));

                            //insert appointment as a shift in the shift table for a specific member of staff
                            DBConnection.getDBConnectionInstance().SqlStatementExecute(Constants.AddShift(date, timeInput, AddHourTime(timeInput), staffID, appointID));

                            //Show success message and close form
                            MessageBox.Show("Booking was successfull!");

                            AppointmentUserControl.RemoveBook();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                //warning for the user to select a staff
                else if (string.IsNullOrEmpty(staffComboBox.Text))
                {
                    MessageBox.Show("Please select a staff member.");
                }
                //warning for the user to select a time
                else if (string.IsNullOrEmpty(timeComboBox.Text))
                {
                    MessageBox.Show("Please select a time period.");
                }
                //warning for the user to select a patient
                else if (string.IsNullOrEmpty(patientCombox.Text))
                {
                    MessageBox.Show("Please select a patient.");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// This method adds an hour to the time selected by the user in the combo box
        /// </summary>
        /// <param name="timeInput"></param>
        /// <returns></returns>
        private string AddHourTime(string timeInput)
        {
            //Add an hour to the time selected
            var input = timeInput.ToCharArray();
            int index = input[1] - '0';
            int firstIndex = input[0] - '0';

            if (index < 9 && firstIndex == 0)
            {
                input[1]++;

            }
            else if (index == 9)
            {
                if (firstIndex == 0)
                {
                    input[0] = '1';
                    input[1] = '0';
                }
                else if (firstIndex == 1)
                {
                    input[0] = '2';
                    input[1] = '0';
                }
            }
            else if (index < 9 && firstIndex == 1)
            {
                input[0] = '1';
                input[1]++;
            }
            else
            {
                input[0] = '2';
                if (index == 3)
                {
                    input[1] = '0';
                    input[0] = '0';
                }

                else
                    input[1]++;
            }


            String endTime = new String(input);
            return endTime;
        }

        /// <summary>
        /// Method that fill the combo boxes with the correct data from the database
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
