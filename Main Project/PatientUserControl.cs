using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Main_Project
{
    public partial class PatientUserControl : UserControl
    {
        private bool patientTest_btn_focus = false;


        

        //singleton initiation
        private static PatientUserControl _instance;
        private string @id = null;

        public static PatientUserControl Instance
        {
            get
            {
                //check if any previous instance was properly disposed
                if (_instance == null || _instance.IsDisposed == true)
                    _instance = new PatientUserControl();
                return _instance;
            }
        }

        public PatientUserControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button that initialises the register patient usercontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            FocusTestPrint_Btn(false);
            FocusRepetePrescription_Btn(false);


            Instance.Controls.Add(RegisterPatientUserControl.Instance);


            RegisterPatientUserControl.Instance.Dock = DockStyle.Fill;
            RegisterPatientUserControl.Instance.BringToFront();

        }

        /// <summary>
        /// Method that removes any usercontrol present in front of the patient usercontrol
        /// </summary>
        public static void RemoveRegister()
        {
            Instance.Controls.Remove(RegisterPatientUserControl.Instance);
        }

        /// <summary>
        /// Method that runs whenever the user enter a key in order to find a patient in the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findBtn_Click(object sender, EventArgs e)
        {

            DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.FindPatient(findInputTxtBox.Text));

            //get the table to be displayed from the data set
            DataTable dtPatient = dsPatient.Tables[0];

            //set the data source for the data grid view
            dataGridView1.DataSource = dtPatient;

        }

        /// <summary>
        /// Method for the prescription button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrescriptionBtn_Click(object sender, EventArgs e)
        {
            string dataTest;
            try
            {
                dataTest = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                prescriptionBtn();
            }

            catch (Exception)
            {
                MessageBox.Show("No Patient Selected");
            }





        }
        private void prescriptionBtn()

        {
            FocusTestPrint_Btn(false);
            FocusRepetePrescription_Btn(true);


            if (@id != null)
            {

                try
                {



                    DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.SelectPrescriptions(@id));
                    DataTable dtPatient = dsPatient.Tables[0];
                    dataGridView1.DataSource = dtPatient;

                    if (dataGridView1 != null)
                    {
                        FocusRepetePrescription_Btn(true);                              
                    }
                    else
                    {
                    }
                }
                catch (Exception ex)
                {
                }

            }
            else if (@id == null)
            {
                try
                {
                    string dgCell = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

                    @id = dgCell;

                    prescriptionBtn();
                }
                catch (Exception ex)
                {
                }
            }
        }




        private void PatientUserControl_Load(object sender, EventArgs e)
        {
            FocusTestPrint_Btn(false);
            FocusRepetePrescription_Btn(false);

            findInputTxtBox.Text = "";
            @id = null;




            // TODO: This line of code loads data into the 'oversurgeryDataSet.userdata' table. You can move, or remove it, as needed.
            this.userdataTableAdapter.Fill(this.oversurgeryDataSet.userdata);

            DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectPatient);

            //get the table to be displayed from the data set
            DataTable dtPatient = dsPatient.Tables[0];

            //set the data source for the data grid view
            dataGridView1.DataSource = dtPatient;
        }

        internal void PatientUserControlRefresh()
        {
            refreshBtn.PerformClick();
        }

        //Check for any special characters and prevent the user from typing them.
        private void findInputTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)&& e.KeyChar != '/')
            {
                e.Handled = true;
                Console.WriteLine("Invalid Character inserted");
            }
            //if there are no special characters then we can run the find method and connect the string to the DB
            else
            {
                findBtn_Click(sender, e);
            }
        }
                

        private void findInputTxtBox_TextChanged(object sender, EventArgs e)
        {

            FocusTestPrint_Btn(false);
            FocusRepetePrescription_Btn(false);

            @id = null;


        }

        /// <summary>
        /// Test button click method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestBtn_Click(object sender, EventArgs e)
        {
            string dataTest;
            try
            {
                dataTest = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                TestButton();
            }

            catch (Exception)
            {
                MessageBox.Show("No Patient Selected");
            }

        }
        private void TestButton()
        {
            FocusTestPrint_Btn(true);
            FocusRepetePrescription_Btn(false);
            if (@id != null)
            {
                try
                {



                    DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.SelectPatientTest(@id));
                    DataTable dtPatient = dsPatient.Tables[0];
                    dataGridView1.DataSource = dtPatient;
                    




                }
                catch (Exception ex)
                {

                }
            }
            else if (@id == null)
            {
                string dgCell = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                @id = dgCell;

                TestButton();
            }
        }

        /// <summary>
        /// Method that prints the test results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printButton_Click(object sender, EventArgs e)
        {
            if (patientTest_btn_focus == true)
            {
                //Printing the Contents
                //https://www.codeproject.com/Articles/28046/Printing-of-DataGridView


                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument1;
                printDialog.UseEXDialog = true;
                //Get the document
                if (DialogResult.OK == printDialog.ShowDialog())
                {
                    printDocument1.DocumentName = "Test Page Print";
                    printDocument1.Print();
                }

            }
            else
            {
                MessageBox.Show("Please Select Tests then a Patient");
            }
        }

        
        private void FocusRepetePrescription_Btn(bool i)
        {
            if (i == false)
            {
                Repete_Prescription_Btn.Visible = false;
            }
            else
            {
                Repete_Prescription_Btn.Visible = true;

            }

        }
        private void FocusTestPrint_Btn(bool i)
        {
            if (i == false)
            {
                TestPrint_Btn.Visible = false;
            }
            else
            {
                TestPrint_Btn.Visible = true;
            }

        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            testPrintGridview();
            //Open the print preview dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument2;
            printDialog.UseEXDialog = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument2.DocumentName = "Test Page Print";
                printDocument2.Print();
            }

            
        }
        private void testPrintGridview()
        {
            DataSet dsPatient = DBConnection.getDBConnectionInstance().getDataSet(Constants.PrintTests(@id));
            DataTable dtPatient = dsPatient.Tables[0];
            
            dataGridView1.DataSource = dtPatient;

            DataGridViewColumn column3 = dataGridView1.Columns[3];
            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column3.Width = 330;
            column0.Width = 150;

        }



        private void RePrescriptionBtn(object sender, EventArgs e)
        {
            
            if (id != null)
            {
                DateTime currentDateTime = DateTime.Now;
                int restrictionDays;
                int NumberOfDaysFromInitialPrescription;

            try
                {
                    string prescription_id = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                    string re_prescription_status = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                    string sqlReplyDate = DBConnection.getDBConnectionInstance().GetStringValue(Constants.PrescriptionDateReply(prescription_id));
                    string sqlReplyRestrictionDays = DBConnection.getDBConnectionInstance().GetStringValue(Constants.PrescriptionDaysReply(prescription_id));                   

                    DateTime queryDate = Convert.ToDateTime(sqlReplyDate);                    
                    Int32.TryParse(sqlReplyRestrictionDays, out restrictionDays);
                    TimeSpan ts = currentDateTime - queryDate;

                    NumberOfDaysFromInitialPrescription = ts.Days;                    
                    if (NumberOfDaysFromInitialPrescription >= restrictionDays && re_prescription_status == "NO")
                    {
                        var result = MessageBox.Show("This patient is permitted for Re-Prescription. Are you sure you want to extend the selected Prescription for selected Patient?", "Re-Prescription Form", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {


                            string formatted_date = currentDateTime.ToString("yyyy/MM/dd HH:mm");


                            string prescription_medicat = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                            string prescription_course_days = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                            string rePrescription_day_limit = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);


                            try
                            {
                                DBConnection.getDBConnectionInstance().SqlStatementExecute(Constants.RePrescriptions(@id, formatted_date, prescription_medicat, prescription_course_days, rePrescription_day_limit));
                                DBConnection.getDBConnectionInstance().SqlStatementExecute(Constants.ChangeRePrescriptionStatus(prescription_id));
                                MessageBox.Show("Complete");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Exeption Error Occoured");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Re-Prescription Cancelled");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Re-Prescription Denied.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No selected Patient");
                }
            }
            else
            {
                MessageBox.Show(@id);
            }                                                             
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string sqlNameReply = DBConnection.getDBConnectionInstance().GetStringValue(Constants.NameReply(id));
                        

            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            String drawString = sqlNameReply;

            // Create font and brush.
            Font drawFont = new Font("Arial", 20);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(90.0F, 100.0F);

            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);


            e.Graphics.DrawImage(bm, 35, 200);
            
        }

        
    }
}


