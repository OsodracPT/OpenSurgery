using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Main_Project
{
    class DBConnect
    {

        private MySqlConnection myConn;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {

        }

        /// <summary>
        /// Method that tries to open a connection to the database
        /// </summary>
        /// <returns></returns>
        static public bool OpenConnection()
        {

            try
            {
                MySqlConnection myConn = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=assignmentdata;User Id=root;password=''");
                myConn.Open();
                MessageBox.Show("Connected");
                myConn.Close();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                myConn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        //Insert statement
        public void Insert()
        {
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }


        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
        /*
        //Select statement
        public List<string>[] Select()
        {
        }

        //Count statement
        public int Count()
        {
        }

        //open connection to database
        private bool OpenConnection()
        {
        }

        //Close connection
        private bool CloseConnection()
        {
        }
        */
    }
}

