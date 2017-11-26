using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{
    class Constants
    {
        //selects all entries from userdata
        public static String selectUserData = "SELECT * FROM userdata";
        //selects all patient data
        public static String selectPatient = "SELECT patientID AS [Patient ID], patientName AS Name," +
            "address AS Address, postCode AS [Post Code], city AS City, Dob AS [Date of Birth], " +
            "phoneNumber AS [Phone Number], medicalRecordID AS [Medical Record ID]  FROM PatientData";
        //selects specific data from patient data
        public static String selectAllPatients = "SELECT patientName AS [Patient Name], dob AS [D.O.B], postCode AS [Post Code], patientID AS [Patient ID] FROM PatientData";
        //gets all the patient names and order it alphabetically
        public static String selectPatientName = "SELECT  patientName FROM PatientData ORDER BY patientName";
        //select all entries from the medicalstaff
        public static String selectStaff = "SELECT * FROM medicalStaff";
        //gets all the staff names and order it alphabetically
        public static String selectStaffName = "SELECT staffName FROM medicalstaff ORDER BY staffName";
        //counts the number of staff
        public static String countStaff = "SELECT COUNT(staffID) FROM medicalstaff";
        //select all the entries from medical staff
        public static String selectPrescr = "SELECT * FROM medicalStaff";
        //select specific test and patient ID from the medical records
        public static String selectTest = "SELECT test, patientID FROM medicalRecords";
        //selects all the appointments from the appointment table
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

        //Sql statement responsible for inserting a new patient into the patient table
        public static String RegisterPatient(string name, string address, string postcode, string city, string DoB, int phoneNumber)
        {

            string registerPatient = $"INSERT INTO PatientData (patientName, address, postCode, city, dob, phoneNumber) VALUES('{name} ', '{address}', '{postcode} ', '{city}', '{DoB}', '{phoneNumber}')";
            return registerPatient;
        }

        //Sql statement used for the find patient function using the Like statement
        public static String FindPatient(string userInput)
        {
            string findPatient = "SELECT patientID AS [Patient ID], patientName AS Name," +
                " address AS Address, postCode AS [Post Code], city AS City, Dob AS [Date of Birth]," +
                " phoneNumber AS [Phone Number], medicalRecordID AS [Medical Record ID] FROM PatientData" +
                " WHERE (patientName LIKE '%" + userInput + "%'OR patientID LIKE '%" + userInput + "%'" +
                " OR address LIKE '%" + userInput + "%' OR dob LIKE '%" + userInput + "%')";
            return findPatient;
        }

        //
        //Roms code add comments
        //
        public static String SelectPatientTest(string userInput)
        {
            // string patientTest = "SELECT patientID AS [Patient ID], test AS [Test] FROM medicalRecords WHERE patientID=" + userInput;
            string patientTest = " SELECT PatientData.patientID AS[Patient ID], PatientData.patientName AS [Name], medicalRecords.test AS[Test], CASE WHEN testResult = 1 THEN 'POSATIVE' ELSE 'NEGATIVE' END AS [Result] FROM medicalRecords INNER JOIN PatientData ON medicalRecords.medicalRecordID = PatientData.medicalRecordID WHERE medicalRecords.patientID ='" + userInput + "'";

            return patientTest;
        }

        //Sql statement that selects a specific shift based on the date
        public static String SelectShiftQuery(string userInput)
        {
            string SelectShiftDate = "SELECT shift.staffID AS [Staff ID], medicalstaff.staffName AS [Name], startTime AS [From], endTime AS [To] FROM shift INNER JOIN medicalstaff ON shift.staffID = medicalstaff.staffID WHERE startDate= '" + userInput + "'";
            return SelectShiftDate;
        }

        //Sql statement responsible for inserting new data into the appointment table
        public static String BookAppointment(string date, string time, string staffName, string patientName, string description, int staffID)
        {

            string bookAppointment = $"INSERT INTO appointment (date, time, description, staffName, patientName, staffID) VALUES('{date} ', '{time}', '{description} ', '{staffName}', '{patientName}','{staffID}')";
            return bookAppointment;
        }

        /// <summary>
        /// Roms code add comment
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public static String SelectPrescription(string userInput)
        {

            string selectPrescription = "SELECT PatientData.patientID AS[Patient ID],PatientData.patientName AS [Name], medicalRecords.content AS[Prescription], medicalRecords.mostRecentPrescription AS [Most Recent Prescription] FROM medicalRecords INNER JOIN PatientData ON medicalRecords.medicalRecordID = PatientData.medicalRecordID WHERE medicalRecords.patientID ='" + userInput + "'";
            return selectPrescription;
        }

        //Sql statement responsible for adding a shift to the shift table
        public static String AddShift(string startDate, string startTime, string endTime, int staffID, string appointID)
        {
            string addShift = $"INSERT INTO shift (startDate, startTime, endTime, staffID, appointmentID) VALUES('{startDate} ', '{startTime}', '{endTime} ', '{staffID}', '{appointID}')";
            return addShift;
        }

        //Sql statement responsible for deleting a shift in the shift table
        public static String DeleteShift(string appointID)
        {
            string deleteShift = "DELETE FROM shift WHERE appointmentID = '" + appointID + "'";
            return deleteShift;
        }

        //selects specific appointment based on the id, used in the edit appointment function
        public static String SelectAppointment(string userInput)
        {
            string selectSpecificAppointment = "SELECT * FROM appointment WHERE appointmentID='" + userInput + "'";
            return selectSpecificAppointment;
        }

        //get the appointment ID based on the other user entries
        public static String GetAppointmentNoID(string date, string time, string staffName, string patientName, string description, int staffID)
        {
            string selectSpecificAppointment = "SELECT appointmentID FROM appointment WHERE date = '" + date + "' AND time='" + time + "' AND staffName='" + staffName + "' AND patientName='" + patientName + "' AND description='" + description + "' AND staffID='" + staffID + "' ";
            return selectSpecificAppointment;
        }
        //Sql statment using the Update responsible for editing an existing appointment
        public static String UpdateAppointment(string appointID, string date, string time, string staffName, string patientName, string description, int staffID)
        {
            string updateSpecificAppointment = $"UPDATE appointment SET date = '" + date + "', time = '" + time + "', staffID = '" + staffID + "', description = '" + description + "', staffName = '" + staffName + "', patientName = '" + patientName + "' WHERE appointmentID ='" + appointID + "'";
            return updateSpecificAppointment;
        }

        //deletes the selected appointment statement
        public static String DeleteAppointment(string userInput)
        {
            string deleteAppointment = "DELETE FROM appointment WHERE appointmentID = '" + userInput + "'";
            return deleteAppointment;
        }
        //Sql statement responsible for editing an existing shift
        public static String UpdateShift(string startDate, string startTime, string endTime, int staffID, string appointID)
        {
            string updateShift = $"UPDATE shift SET startDate = '" + startDate + "', startTime = '" + startTime + "', endTime = '" + endTime + "', staffID = '" + staffID + "' WHERE appointmentID ='" + appointID + "'";
            return updateShift;
        }

        //count how many shifts a member of staff has in a specific day
        public static String Countshifts(string date)
        {
            string countShifts = "SELECT COUNT(staffID) FROM shift WHERE startDate= '" + date + "'";
            return countShifts;
        }
    }
}
