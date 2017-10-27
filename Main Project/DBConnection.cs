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


    }
}
