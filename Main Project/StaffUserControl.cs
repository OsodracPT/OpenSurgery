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
    public partial class StaffUserControl : UserControl
    {
        //singleton initiation
        private static StaffUserControl _instance;

        public static StaffUserControl Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed == true)
                    _instance = new StaffUserControl();
                return _instance;
            }
        }
        public StaffUserControl()
        {
            InitializeComponent();
        }

        private void StaffUserControl_Load(object sender, EventArgs e)
        {
            //I want to add a listview
            listView1.Columns.Add("Time");

            DataSet dsMedicalStaff = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectStaff);

            //get the table to be displayed from the data set
            DataTable dtStaff = dsMedicalStaff.Tables[0];

            //load the list view with data
            int max = DBConnection.getDBConnectionInstance().GetIntValue(Constants.countStaff);
            for (int i = 0; i < max; i++)
            {
                listView1.Columns.Add(dtStaff.Rows[i]["staffName"].ToString(), 120);
            }

            for (int i = 8; i < 24; i++)
            {
                if (i < 10)
                {
                    listView1.Items.Add("0" + i + ":00");
                }
                else
                {
                    listView1.Items.Add(i + ":00");
                }
            }

            for (int index = 0; index < max; index++)
            {
                for (int i = 0; i < 16; i++)
                {
                    listView1.Items[i].SubItems.Add(index + " column");
                }

            }






            //
            DataSet dsStaff = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectStaff);

            //get the table to be displayed from the data set
            //DataTable dtStaff = dsStaff.Tables[0];

            //set the data source for the data grid view
            dgvUserdata.DataSource = dtStaff;
        }


        //additions by Rom
        private void checkdutyBtn_Click(object sender, EventArgs e)
        {

            string date = dateTimePicker1.Text;
            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(Constants.SelectShiftQuery(date));

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            //set the data source for the data grid view
            dgvUserdata.DataSource = dtUser;
        }

        private void checkavailBtn_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;
            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(Constants.CheckStaffAvailability(date));

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            //set the data source for the data grid view
            dgvUserdata.DataSource = dtUser;
        }

        private void checkfreeBtn_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;
            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(Constants.CheckFreeQuery(date));

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            //set the data source for the data grid view
            dgvUserdata.DataSource = dtUser;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;
            Console.WriteLine("HI");

            DataSet dsStaffAvail = DBConnection.getDBConnectionInstance().getDataSet(Constants.SelectShiftQuery(date));

            //get the table to be displayed from the data set
            DataTable dtStaffAvail = dsStaffAvail.Tables[0];

            if ((dtStaffAvail.Rows[0]["Name"].ToString()) == "Pedro Cardoso")
            {
                //change the subitems value to change the staff member
                listView1.Items[4].SubItems[1].Text = "working";

                //analyse the datatable in search of startTimes
            }


        }
    }
}
