using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectAll);

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            //set the data source for the data grid view
            dgvUserdata.DataSource = dtUser;
        }

    }
}
