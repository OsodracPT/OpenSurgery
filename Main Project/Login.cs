using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Main_Project
{
    class Login
    {
        public static int TryLogin(string username, string password)
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

