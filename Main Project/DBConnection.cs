using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{
    //class structure base on Module Leader: dr. Cristina Luca Lecture Notes on week 4
    class DBConnection
    {
        //attributes
        private static DBConnection _instance;

        private static string connectionString;

        //theSqlConnection object used to store the connection to the database
        private SqlConnection connectionToDB;

        // the DataAdapter object used to open a table of the database
        private SqlDataAdapter dataAdapter;


        //properties
        public static string ConnectionStr
        {
            set
            {
                connectionString = value;
            }
        }

        //methods
        public static DBConnection getDBConnectionInstance()
        {
            if (_instance == null)
                _instance = new DBConnection();

            return _instance;
        }

        // Open the connection
        public void openConnection()
        {
            // create the connection to the database as an instance of SqlConnection
            connectionToDB = new SqlConnection(connectionString);

            //open connection
            connectionToDB.Open();
        }

        public void closeConnection()
        {
            connectionToDB.Close();
        }


        //create a data set for a certain request
        public DataSet getDataSet(String sqlStatement)
        {
            DataSet dataSet = new DataSet();

            //open connection
            openConnection();

            //create the data adapter object
            dataAdapter = new SqlDataAdapter(sqlStatement, connectionToDB);

            //fill in the data set
            dataAdapter.Fill(dataSet);

            //close connection
            closeConnection();

            return dataSet;
        }

        public int TryLogin(string username, string password)
        {
            int i = 0;


            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(Constants.selectLogin(username, password));

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            i = Convert.ToInt32(dtUser.Rows.Count.ToString());
            return i;
        }

        public void RegisterPatient(string name, string address, string postcode, string city, DateTime DoB, int phoneNumber)
        {
            connectionToDB.Open();

            string dobTemp = DoB.ToString("d");
            SqlCommand cmd = connectionToDB.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Constants.RegisterPatient(name, address, postcode, city, dobTemp, phoneNumber);
            cmd.ExecuteNonQuery();

            connectionToDB.Close();
        }

        public int SelectMax()
        {
            connectionToDB.Open();

            SqlCommand cmd = connectionToDB.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Constants.selectMaxID;
            int maxId = Convert.ToInt32(cmd.ExecuteScalar());

            return maxId;
        }

        public void BookAppointment(string date, string time, string staffName, string patientName, string description)
        {
            connectionToDB.Open();

            SqlCommand cmd = connectionToDB.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Constants.BookAppointment(date, time, staffName, patientName, description);
            cmd.ExecuteNonQuery();

            connectionToDB.Close();
        }

        public void AddShift(string startDate, string startTime, string endTime, int staffID)
        {
            connectionToDB.Open();

            SqlCommand cmd = connectionToDB.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Constants.AddShift(startDate, startTime, endTime, staffID);
            cmd.ExecuteNonQuery();

            connectionToDB.Close();
        }

        public string GetStaffID(string staffName)
        {
            connectionToDB.Open();

            SqlCommand cmd = connectionToDB.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Constants.GetStaffID(staffName);
            cmd.ExecuteNonQuery();
            string str = Convert.ToString(cmd.ExecuteScalar());
            connectionToDB.Close();

            return str;
        }
    }
}
