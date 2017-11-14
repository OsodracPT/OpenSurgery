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
    public partial class AppointmentUserControl : UserControl
    {
        //holds the value of the appointment ID
        private static string appointmentID;
        static bool valueNotSelected = false;

        //singleton initiation
        private static AppointmentUserControl _instance;

        public static AppointmentUserControl Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed == true)
                    _instance = new AppointmentUserControl();
                return _instance;
            }
        }

        public static string AppointmentID
        {
            get
            {
                return appointmentID;
            }

            set
            {
                appointmentID = value;
            }
        }

        public AppointmentUserControl()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Instance.Controls.Add(BookAppointUserControl.Instance);


            BookAppointUserControl.Instance.Dock = DockStyle.Fill;
            BookAppointUserControl.Instance.BringToFront();

        }

        public static void RemoveBook()
        {
            Instance.Controls.Remove(BookAppointUserControl.Instance);
            Instance.Controls.Remove(EditAppoinUserControl.Instance);

        }

        private void AppointmentUserControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oversurgeryDataSet.userdata' table. You can move, or remove it, as needed.
            this.userdataTableAdapter.Fill(this.oversurgeryDataSet.userdata);

            DataSet dsAppoint = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectAllAppointment);

            //get the table to be displayed from the data set
            DataTable dtAppoint = dsAppoint.Tables[0];

            //set the data source for the data grid view
            dataGridView1.DataSource = dtAppoint;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (valueNotSelected==true)
            {
                MessageBox.Show("Please select the appointment you want to edit.");
            }
            else
            {
                Instance.Controls.Add(EditAppoinUserControl.Instance);


                EditAppoinUserControl.Instance.Dock = DockStyle.Fill;
                EditAppoinUserControl.Instance.BringToFront();
            }
        }

        /// <summary>
        /// Gets the value from the selected row in the data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            valueNotSelected = false;

            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            try
            {
                AppointmentID = selectedRow.Cells[0].Value.ToString();

                int appointId = Convert.ToInt32(AppointmentID);
                Console.WriteLine(AppointmentID);
            }
            catch (Exception ex)
            {
                valueNotSelected = true;
            }
        }

        public static string returnValue()
        {
            return AppointmentID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (valueNotSelected == true)
            {
                MessageBox.Show("Please select the appointment you want to cancel.");
            }
            else
            {
                try
                {
                    //try to delete appointment
                    DBConnection.getDBConnectionInstance().SqlStatementExecute(Constants.DeleteAppointment(AppointmentID));

                    //try to delete the shift related to the same appointment
                    DBConnection.getDBConnectionInstance().SqlStatementExecute(Constants.DeleteShift(AppointmentID));


                    MessageBox.Show("Appointment deleted successfully!");
                }
                catch (Exception ex)
                {

                }
            }
        }

    }
}
