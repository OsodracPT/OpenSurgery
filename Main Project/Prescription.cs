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
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {


            DataSet dsPrescription = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectPatient);

            //get the table to be displayed from the data set
            DataTable dtPrescription = dsPrescription.Tables[0];

            //set the data source for the data grid view
            dgvPrescription.DataSource = dtPrescription;
        }
    }
}
