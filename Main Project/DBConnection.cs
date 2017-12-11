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

        internal static string connectionString;

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

        //Methods that execute a query in the database

        /// <summary>
        /// This method executes an Slq statment based on the statements present in the Constants class. May need to reuse this method for better code efficiency
        /// </summary>
        /// <param name="sqlStatement"></param>
        public void SqlStatementExecute(String sqlStatement)
        {
            connectionToDB.Open();

            SqlCommand cmd = connectionToDB.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStatement;
            cmd.ExecuteNonQuery();

            connectionToDB.Close();
        }


        //Methods that return an int in from the database

        public int GetIntValue(String sqlStatement)
        {
            connectionToDB.Open();

            SqlCommand cmd = connectionToDB.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStatement;
            cmd.ExecuteNonQuery();
            int value = Convert.ToInt32(cmd.ExecuteScalar());
            connectionToDB.Close();

            return value;
        }

        /// <summary>
        /// Method that returns an in based on the amount of rows with the same data as the user input.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int TryLogin(string username, string password)
        {
            int i = 0;


            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(Constants.SelectLogin(username, password));

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            i = Convert.ToInt32(dtUser.Rows.Count.ToString());
            return i;
        }

        //check if a staff member is already busy according to the user input
        public int CheckStaffBusy(int staffID, string date, string time)
        {
            int i = 0;
            string staffString = Convert.ToString(staffID);
            DataSet dsUser = DBConnection.getDBConnectionInstance().getDataSet(Constants.SpecificStaffMember(staffString, date, time));

            //get the table to be displayed from the data set
            DataTable dtUser = dsUser.Tables[0];

            i = Convert.ToInt32(dtUser.Rows.Count.ToString());
            return i;
        }


        //Methods that return a string from the database
        public string GetStringValue(String sqlStatement)
        {
            connectionToDB.Open();

            SqlCommand cmd = connectionToDB.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStatement;
            cmd.ExecuteNonQuery();
            string str = Convert.ToString(cmd.ExecuteScalar());
            connectionToDB.Close();

            return str;
        }

    }
}
