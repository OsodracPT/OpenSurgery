using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main_Project
{
    public partial class PrescriptionUserControl : UserControl
    {
        private static PrescriptionUserControl _instance;
        public static PrescriptionUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PrescriptionUserControl();
                return _instance;
            }
        }
        public PrescriptionUserControl()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'oversurgeryDataSet.userdata' table. You can move, or remove it, as needed.
            

            DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectAllPatients);

            //get the table to be displayed from the data set
            DataTable dtPatient = dsPatient.Tables[0];

            //set the data source for the data grid view
            dataGridView1.DataSource = dtPatient;
        }

        private void Prescription_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(DBConnection.connectionString);
            con.Open();
            
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT patientName, dob, postCode, patientID FROM PatientData WHERE patientName like '" + textBox1.Text + "%'", DBConnection.connectionString);
            DataTable dt;
            
            dt = new DataTable();
            
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string DGCell = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                                                  

                    DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.SelectPrescription(DGCell));
                    DataTable dtPatient = dsPatient.Tables[0];
                    dataGridView1.DataSource = dtPatient;
                
                
            }
            catch (Exception ex)
            {
                
            }








        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectAllPatients);

            //get the table to be displayed from the data set
            DataTable dtPatient = dsPatient.Tables[0];

            //set the data source for the data grid view
            dataGridView1.DataSource = dtPatient;
        }
    }
}
