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

            LoadlistView();
        }


        //additions by Rom
        private void checkdutyBtn_Click(object sender, EventArgs e)
        {

            string date = dateTimePicker1.Text;
            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(Constants.SelectShiftQuery(date));

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            //set the data source for the data grid view
        }

        private void checkavailBtn_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;
            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(Constants.CheckStaffAvailability(date));

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            //set the data source for the data grid view
        }

        private void checkfreeBtn_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;
            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(Constants.CheckFreeQuery(date));

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            //set the data source for the data grid view
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            //reload the listview
            LoadlistView();

            //Get the number of staff for the loop
            int staffNumber = DBConnection.getDBConnectionInstance().GetIntValue(Constants.countStaff);
            for (int i = 0; i < staffNumber; i++)
            {
                string staffID = Convert.ToString(i);
                AddShiftToListView(staffID);
            }




        }

        private void LoadlistView()
        {

            listView1.Items.Clear();

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
                    listView1.Items[i].SubItems.Add("Available");
                    //property to add colour
                    listView1.Items[i].UseItemStyleForSubItems = false;
                }

            }

        }

        private void AddShiftToListView(string staffID)
        {

            string date = dateTimePicker1.Text;

            DataSet dsStaffAvail = DBConnection.getDBConnectionInstance().getDataSet(Constants.SelectShiftQuery(date));

            //get the table to be displayed from the data set
            DataTable dtStaffAvail = dsStaffAvail.Tables[0];

            //find out how many shifts a member of staff has in that specific day
            int shiftAmount = DBConnection.getDBConnectionInstance().GetIntValue(Constants.Countshifts(date));
            Console.WriteLine("Shift Amount=" + shiftAmount);
            
            //debug
            Console.WriteLine("Passed Value:"+staffID);
            for (int i = 0; i < shiftAmount; i++)
            {
                Console.WriteLine("Value from the datatable:"+(dtStaffAvail.Rows[i]["Staff ID"].ToString()));
                if ((dtStaffAvail.Rows[i]["Staff ID"].ToString()) == staffID)
                {
                    //change the subitems value to change the staff member

                    string value = (dtStaffAvail.Rows[i]["From"].ToString());
                    Console.WriteLine("Row value=" + value);
                    int staffInt = Convert.ToInt32(staffID);

                    switch (value)
                    {
                        case "08:00:00":
                            listView1.Items[0].SubItems[staffInt].Text = "Working";
                            listView1.Items[4].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "09:00:00":
                            listView1.Items[1].SubItems[staffInt].Text = "Working";
                            listView1.Items[1].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "10:00:00":
                            listView1.Items[2].SubItems[staffInt].Text = "Working";
                            listView1.Items[2].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "11:00:00":
                            listView1.Items[3].SubItems[staffInt].Text = "Working";
                            listView1.Items[3].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "12:00:00":
                            listView1.Items[4].SubItems[staffInt].Text = "Working";
                            listView1.Items[4].SubItems[staffInt].ForeColor = Color.Green;
                            break;
                        case "13:00:00":
                            listView1.Items[5].SubItems[staffInt].Text = "Working";
                            listView1.Items[5].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "14:00:00":
                            listView1.Items[6].SubItems[staffInt].Text = "Working";
                            listView1.Items[6].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "15:00:00":
                            listView1.Items[7].SubItems[staffInt].Text = "Working";
                            listView1.Items[7].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "16:00:00":
                            listView1.Items[8].SubItems[staffInt].Text = "Working";
                            listView1.Items[8].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "17:00:00":
                            listView1.Items[9].SubItems[staffInt].Text = "Working";
                            listView1.Items[9].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "18:00:00":
                            listView1.Items[10].SubItems[staffInt].Text = "Working";
                            listView1.Items[10].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "19:00:00":
                            listView1.Items[11].SubItems[staffInt].Text = "Working";
                            listView1.Items[11].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "20:00:00":
                            listView1.Items[12].SubItems[staffInt].Text = "Working";
                            listView1.Items[12].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "21:00:00":
                            listView1.Items[13].SubItems[staffInt].Text = "Working";
                            listView1.Items[13].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "22:00:00":
                            listView1.Items[14].SubItems[staffInt].Text = "Working";
                            listView1.Items[14].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        case "23:00:00":
                            listView1.Items[15].SubItems[staffInt].Text = "Working";
                            listView1.Items[15].SubItems[staffInt].ForeColor = Color.Green;

                            break;
                        default:
                            Console.WriteLine("No time found");
                            break;
                    }
                }

            }
        }
    }
}
