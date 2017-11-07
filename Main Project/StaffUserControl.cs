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
                if (_instance == null)
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
            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectStaff);

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            //set the data source for the data grid view
            dgvUserdata.DataSource = dtUser;
        }
    }
}
