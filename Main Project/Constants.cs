using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{
    class Constants
    {
        public static String selectUserData = "SELECT * FROM userdata";
        public static String selectPatient = "SELECT * FROM PatientData";
        public static String selectStaff = "SELECT * FROM medicalStaff";

        public static String selectLogin(string username, string password)
        {
            
            string selectLogin= "SELECT * FROM userdata WHERE username='" + username + "' and password='" + password + "'";
            return selectLogin;
        }
            

    }
}
