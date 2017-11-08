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
        public static String selectPatient = "SELECT patientID AS [Patient ID], patientName AS Name," +
            "address AS Address, postCode AS [Post Code], city AS City, Dob AS [Date of Birth], " + 
            "phoneNumber AS [Phone Number], medicalRecordID AS [Medical Record ID]  FROM PatientData";
        public static String selectStaff = "SELECT * FROM medicalStaff";
        public static String selectPrescr = "SELECT * FROM medicalStaff";
        public static String selectTest = "SELECT test, patientID FROM medicalRecords";

        //select the maximum value of patient ID
        public static String selectMaxID = "SELECT MAX(patientID) FROM PatientData";





        public static String selectLogin(string username, string password)
        {

            string selectLogin = "SELECT * FROM userdata WHERE username='" + username + "' and password='" + password + "'";
            return selectLogin;
        }

        public static String RegisterPatient(string name, string address, string postcode, string city, string DoB, int phoneNumber)
        {

            string registerPatient = $"INSERT INTO PatientData (patientName, address, postCode, city, dob, phoneNumber) VALUES('{name} ', '{address}', '{postcode} ', '{city}', '{DoB}', '{phoneNumber}')";
            return registerPatient;
        }

        public static String FindPatient(string userInput)
        {
            string findPatient = "SELECT patientID AS [Patient ID], patientName AS Name,"+
                " address AS Address, postCode AS [Post Code], city AS City, Dob AS [Date of Birth],"+
                " phoneNumber AS [Phone Number], medicalRecordID AS [Medical Record ID] FROM PatientData"+
                " WHERE (patientName LIKE '%" + userInput + "%'OR patientID LIKE '%" + userInput + "%'"+
                " OR address LIKE '%" + userInput + "%' OR dob LIKE '%" + userInput + "%')";
            return findPatient;
        }

        public static String SelectPatientTest(string userInput)
        {
            string patientTest = "SELECT test, patientID FROM medicalRecords WHERE patientID=" + userInput;
            return patientTest;
        }

    }
}
