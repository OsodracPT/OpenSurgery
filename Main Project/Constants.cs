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
        public static String selectAllPatients = "SELECT patientName AS [Patient Name], dob AS [D.O.B], postCode AS [Post Code], patientID AS [Patient ID] FROM PatientData";
        //gets all the patient names and order it alphabetically
        public static String selectPatientName = "SELECT  patientName FROM PatientData ORDER BY patientName";
        public static String selectStaff = "SELECT * FROM medicalStaff";
        //gets all the staff names and order it alphabetically
        public static String selectStaffName = "SELECT staffName FROM medicalstaff ORDER BY staffName";
        public static String selectPrescr = "SELECT * FROM medicalStaff";
        public static String selectTest = "SELECT test, patientID FROM medicalRecords";

        public static String selectAllAppointment = "SELECT appointmentID AS [Appointment ID], date AS Date," +
            "time AS Time, description AS [Description], staffName AS [Staff Name], patientName AS [Patient Name], " +
            "staffID AS [Staff ID], patientID AS [Patient ID] FROM appointment";


        //select the maximum value of patient ID
        public static String selectMaxID = "SELECT MAX(patientID) FROM PatientData";


        //sql statement that takes in the staff name and gives out his ID
        public static String GetStaffID(string staffName)
        {

            string staffID = "SELECT staffID FROM medicalstaff WHERE staffName='" + staffName + "'";
            return staffID;
        }

        //Sql statement that checks the user input with the data present in userdata
        public static String selectLogin(string username, string password)
        {

            string selectLogin = "SELECT * FROM userdata WHERE username='" + username + "' and password='" + password + "'";
            return selectLogin;
        }

        //Sql statement that checks for a specific staff member according to user input
        public static String SpecificStaffMember(string staffID, string date, string time)
        {
            Console.WriteLine(date + time);
            string selectStaffMember = "SELECT * FROM shift WHERE staffID='" + staffID + "' AND startDate='" + date + "' AND startTime='" + time + "'";
            return selectStaffMember;
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

        public static String SelectShiftQuery(string userInput)
        {
            string SelectShiftDate = "SELECT shift.staffID AS [Staff ID], medicalstaff.staffName AS [Name], startTime AS [From], endTime AS [To] FROM shift INNER JOIN medicalstaff ON shift.staffID = medicalstaff.staffID WHERE startDate= '" + userInput + "'";
            return SelectShiftDate;
        }

        public static String CheckFreeQuery(string userInput)
        {
            string SelectShiftDate = "SELECT shift.staffID AS [Staff ID] , medicalstaff.staffName AS [Name], medicalstaff.ocupation AS [Occupation] FROM shift INNER JOIN medicalstaff ON shift.staffID = medicalstaff.staffID WHERE NOT shift.startDate= '" + userInput + "'";
            return SelectShiftDate;
        }

        public static String CheckStaffAvailability(string userInput)
        {
            string SelectAvailability = "SELECT medicalstaff.staffID AS [Staff ID], medicalstaff.staffName AS [Name], shift.startDate AS [Date], shift.startTime AS [From], shift.endTime AS [To] FROM medicalstaff INNER JOIN shift ON medicalstaff.staffID = medicalstaff.staffID WHERE shift.startDate= '" + userInput + "'";
            return SelectAvailability;
        }

        public static String BookAppointment(string date, string time, string staffName, string patientName, string description, int staffID)
        {

            string bookAppointment = $"INSERT INTO appointment (date, time, description, staffName, patientName, staffID) VALUES('{date} ', '{time}', '{description} ', '{staffName}', '{patientName}','{staffID}')";
            return bookAppointment;
        }
        public static String SelectPrescription(string userInput)
        {

            string selectPrescription = "SELECT PatientData.patientName AS [Patient Name], medicalRecords.content AS[Prescription], PatientData.patientID AS[PatientID], medicalRecords.mostRecentPrescription AS [Most Recent Prescription] FROM medicalRecords INNER JOIN PatientData ON medicalRecords.medicalRecordID = PatientData.medicalRecordID WHERE medicalRecords.patientID ='"+userInput+"'";
            return selectPrescription;
        }

        public static String AddShift(string startDate, string startTime, string endTime, int staffID)
        {
            string addShift = $"INSERT INTO shift (startDate, startTime, endTime, staffID) VALUES('{startDate} ', '{startTime}', '{endTime} ', '{staffID}')";
            return addShift;
        }

    }
}
