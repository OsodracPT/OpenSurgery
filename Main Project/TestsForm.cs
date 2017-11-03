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
    public partial class TestsForm : Form
    {
        public TestsForm()
        {
            InitializeComponent();
        }

        private void TestsForm_Load(object sender, EventArgs e)
        {
            DataSet dsTest = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectTest);

            //get the table to be displayed from the data set
            DataTable dtTest = dsTest.Tables[0];

            //set the data source for the data grid view
            dgvTest.DataSource = dtTest;

            //get Patientid maximum value
            int maxValue = DBConnection.getDBConnectionInstance().SelectMax();

            for (int i = 0; i < maxValue; i++)
            {
                comboBox1.Items.Add(i + 1);
            }

        }

        private void btnSelectPatient_Click(object sender, EventArgs e)
        {

            DataSet dsTest = DBConnection.getDBConnectionInstance().getDataSet(Constants.SelectPatientTest(comboBox1.Text));

            //get the table to be displayed from the data set
            DataTable dtTest = dsTest.Tables[0];

            //set the data source for the data grid view
            dgvTest.DataSource = dtTest;
        }
    }
}
