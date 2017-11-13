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

        private void fileLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
