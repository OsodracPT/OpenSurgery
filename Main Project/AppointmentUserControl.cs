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
                if (_instance == null)
                    _instance = new AppointmentUserControl();
                return _instance;
            }
        }
        public AppointmentUserControl()
        {
            InitializeComponent();
            string tDate = Constants.Appointments(DateTime.Today.ToString("yyyy/MM/dd"));
            
            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(tDate);

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            //set the data source for the data grid view
            dgvUserdata.DataSource = dtUser;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tDate = Constants.Appointments(DateTime.Today.ToString(this.dateTimePicker1.Text));

            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(tDate);

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            //set the data source for the data grid view
            dgvUserdata.DataSource = dtUser;
        }

        private void dgvUserdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
