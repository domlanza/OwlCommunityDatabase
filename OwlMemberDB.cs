/*
 * Owl Member Database Class
 * Authors: Nick Filauro & Erika Gepilano
 * April 2016 * Version 1
 * 
 * Updated 11/18/2016 * Version 2 * Elliot Stoner
 * Updated 06/17/2017 * Version 3 * Frank Friedman
 * Updated 06/30/2018 * Version 4 * Frank Friedman
 * 
 * Purpose: A class that interacts and performs database operations for OwlMember
 * in a Microsoft Access database using an OLEDB Data Reader.
 * It will contain methods for CRUD (Create, Read, Update, Delete) operations.
 * 
 * !! Requirements !!
 * You must have the Access Database Engine installed on the system you are runni;ng the program on.
 * https://www.microsoft.com/en-us/download/details.aspx?id=13255
 * 
 * No constructors were written
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace OwlCommunityMemberLanzaDrafts
{
    public class OwlMemberDB
    {
        string dbOwlMemberType = "";
        // Connection string for OwlMemberDB (type: Microsoft Access) in the Resources folder
        string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source= OwlCommunityDBSample-1 (3).accdb";
        // "provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=../Debug/ProductDB.accdb"


        // *********** INSERTION METHODS **********
        // Inserts a new record for OwlMember in the OwlMember table with parameters name, birthDate and OwlMemberID
        public bool InsertOwlMember(int OwlMemberID, string OwlMemberName, DateTime OwlMemberBirthDate, string newType)  // DOB striing or DateTime
        {
			// SQL insert statement for OwlMember
			// String dobStringTemp = OwlMemberBirthdate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)

			string strInsertOwlMember = "INSERT INTO OWLMEMBER (fldID, fldName, fldBirthdate, fldMemberType)" +
                "VALUES(" + OwlMemberID + " , '" + OwlMemberName + "' , '" + Convert.ToDateTime(OwlMemberBirthDate)+ "' , '" + newType + "' );"; 
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertOwlMember, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("There was an Insert OwlMember error: " + ex.Message);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }
            
        }  // end InsertOwlMember


        // Inserts a new record for Student into Student table with parameters OwlMemberID and jobTitle
        public bool InsertStudent(int StudentID, string StudentMajor, decimal StudentGPA)
        {
            string strInsertStudent = "INSERT INTO STUDENT (fldID, fldMajor, fldGPA) " + 
                "VALUES(" + StudentID + ", '" + StudentMajor + "', " + StudentGPA + " );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertStudent, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Student error: " + ex.Message);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }
 
        }  // // end InsertStudent


        // Inserts a new record for Faculty into Faculty table with parameters OwlMemberID and type
        public bool InsertFaculty(int FacultyID, string FacultyDepartment, string FacultyRank)
        {
            string strInsertFaculty = "INSERT INTO FACULTY (fldID, fldDepartment, fldRank) " +
                "VALUES(" + FacultyID + ", '" + FacultyDepartment + "', '" + FacultyRank + "' );"; 
       
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertFaculty, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Faculty error: " + ex.Message);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }
 
        }  // end InsertFaculty

        
        // Inserts a new record for UndergraduateStudent into UndergraduateStudent table with parameters OwlMemberID, salary and bonus
        public bool InsertUndergraduateStudent(int UGStudentID, decimal UGStudentTuition, 
			string UGStudentYear, int UGStudentCredits)
        {
            string strInsertUndergraduateStudent = "INSERT INTO UNDERGRADUATESTUDENT (fldID, fldTuition, fldYear, fldCredits) " +
                "VALUES(" + UGStudentID + ", " + UGStudentTuition + ", '" + UGStudentYear + "', "  + UGStudentCredits + ");"; 
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertUndergraduateStudent, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert UndergraduateStudent error: " + ex.Message);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }  // end InsertUndergraduateStudent


        // Inserts a new record for GraduateStudent in GraduateStudent table with integer parameters OwlMemberID, Stipend and DegreeProgram
        public bool InsertGraduateStudent(int GrStudentID, decimal GrStudentStipend, string GrStudentDegreeProgram)
        {
            string strInsertGraduateStudent = "INSERT INTO GRADUATESTUDENT (fldID, fldStipend, fldDegreeProgram) " +
                "VALUES(" + GrStudentID + ", " + GrStudentStipend + ", '" + GrStudentDegreeProgram +"') ;"; 
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertGraduateStudent, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert GraduateStudent error: " + ex.Message);
                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }
        }  // end InsertGraduateStudent



		// Inserts a new record for Chairperson into Chairperson table with parameters OwlMemberID, salary and bonus
		public bool InsertChairperson(int ChairpersonID, decimal ChairpersonStipend)
		{
			string strInsertChairperson = "INSERT INTO CHAIRPERSON (fldID, fldStipend) " +
				"VALUES(" + ChairpersonID + ", " + ChairpersonStipend + "); "; 

			OleDbConnection myConnection = new OleDbConnection(strConnection);
			OleDbCommand myCommand = new OleDbCommand(strInsertChairperson, myConnection);
			OleDbDataReader myDataReader;

			try
			{
				myConnection.Open();
				myDataReader = myCommand.ExecuteReader();
				myDataReader.Close();
				return true; // returns true if Insert was successful
			}
			catch (OleDbException ex)
			{
				Console.Write("There was an Insert Chairperson error: " + ex.Message);
				return false; // returns false if Insert was unsuccessful
			}
			finally
			{
				myConnection.Close();
			}

		}  // end InsertChairperson

		// ********** End of INSERT methods **********



		// ********** SELECT (Query) Methods ********** 
        // Queries/selects records from OwlMember table that match integer parameter OwlMemberID
        // Returns a reference to the retrieved record
        public OleDbDataReader SelectOwlMemberFromOwlMember(int OwlMemberID, out bool OKFlag)
        {
            // string strSelectOwlMember = "SELECT * FROM OWLMEMBER WHERE OWLMEMBER.fldID = " + OwlMemberID; 
            string strSelectOwlMember = "SELECT * FROM OWLMEMBER WHERE OWLMEMBER.fldID = " + OwlMemberID + ";"; 

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectOwlMember, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows == false)
                {
                    MessageBox.Show("OwlMemberID not found. ",
                         "Select from OwlMemberID Yields Not Found", MessageBoxButtons.OK);
                    myConnection.Close();
                    OKFlag = false; // returns false if Select was unsuccessful
                    myDataReader = null;
                    return myDataReader;
                }
                else OKFlag = true;
                myDataReader.Read();
            }

            catch (OleDbException ex)
            {
                MessageBox.Show("There was a Select from OwlMember error. Command or Open Error: " + ex.Message);
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
                myDataReader = null;
            }
            return myDataReader;
        } // end SelectOwlMemberFromOwlMember


        // Queries/selects records from Faculty table that match integer parameter OwlMemberID
        // Returns a reference to the retrieved record
        public OleDbDataReader SelectOwlMemberFromFaculty(int OwlMemberID, out bool OKFlag)
        { 
            string strSelectOwlMember = "SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, OWLMEMBER.fldBirthdate, " 
               + "FACULTY.fldDepartment, FACULTY.fldRank FROM OWLMEMBER "
               + "INNER JOIN FACULTY ON FACULTY.fldID = OWLMEMBER.fldID "
               + "WHERE FACULTY.fldID = " + OwlMemberID + ";"; 

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectOwlMember, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true; // returns true if Select was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Open or Select Command failure.  Terminate execution." + ex.Message);
                myDataReader = null;
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
            }
 
            return myDataReader;
        }  // end SelectOwlMemberFromFaculty


 
        // Queries/selects records from UndergraduateStudent table that match integer parameter OwlMemberID
        // Returns a reference to the retrieved record
        public OleDbDataReader SelectOwlMemberFromUndergraduateStudent(int OwlMemberID, out bool OKFlag)
        {
            string strSelectOwlMember = "SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, OWLMEMBER.fldBirthdate, "
                + "STUDENT.fldMajor, STUDENT.fldGPA, "
                + "UNDERGRADUATESTUDENT.fldTuition, UNDERGRADUATESTUDENT.fldYear, UNDERGRADUATESTUDENT.fldCredits "
                + "FROM (OWLMEMBER "
				+ "INNER JOIN STUDENT ON STUDENT.fldID = OWLMEMBER.fldID) "
                + "INNER JOIN UNDERGRADUATESTUDENT ON UNDERGRADUATESTUDENT.fldID = OWLMEMBER.fldID "
				+ "WHERE OWLMEMBER.fldID = " + OwlMemberID + ";"; 

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectOwlMember, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true;
            }
            catch (OleDbException ex)
            {
                Console.Write("There was a Select Undergraduate Student error: " + ex.Message);
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
                myDataReader = null;
            }

            return myDataReader; 
        } // end SelectOwlMemberFromUndergraduateStudent

        
        // Queries/selects records from GraduateStudent table that match integer parameter OwlMemberID
        public OleDbDataReader SelectOwlMemberFromGraduateStudent(int OwlMemberID, out bool OKFlag)
        {
            string strSelectOwlMember = "SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, OWLMEMBER.fldBirthdate, "
                + "STUDENT.fldMajor, STUDENT.fldGPA, "
				+ "GRADUATESTUDENT.fldStipend, GRADUATESTUDENT.fldDegreeProgram FROM (OWLMEMBER "
				+ "INNER JOIN STUDENT ON STUDENT.fldID = OWLMEMBER.fldID) "
                + "INNER JOIN GRADUATESTUDENT ON GRADUATESTUDENT.fldID = OWLMEMBER.fldID "
                + "WHERE OWLMEMBER.fldID = " + OwlMemberID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectOwlMember, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true;
            }
            catch (OleDbException ex)
            {
                Console.Write("There was a Select Graduate Student error: " + ex.Message);
                myConnection.Close();
                myDataReader = null;
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader; 
        } // end SelectOwlMemberFromGraduateStudent


		// Queries/selects records from UndergraduateStudent table that match integer parameter OwlMemberID
		// Returns a reference to the retrieved record
		public OleDbDataReader SelectOwlMemberFromChairperson(int OwlMemberID, out bool OKFlag)
		{
			string strSelectOwlMember = "SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, OWLMEMBER.fldBirthdate, "
				+ "FACULTY.fldDepartment, FACULTY.fldRank, CHAIRPERSON.fldStipend FROM (OWLMEMBER "
				+ "INNER JOIN FACULTY ON FACULTY.fldID = OWLMEMBER.fldID) "
				+ "INNER JOIN CHAIRPERSON ON CHAIRPERSON.fldID = OWLMEMBER.fldID "
				+ "WHERE OWLMEMBER.fldID = " + OwlMemberID + ";";

			OleDbConnection myConnection = new OleDbConnection(strConnection);
			OleDbCommand myCommand = new OleDbCommand(strSelectOwlMember, myConnection);
			OleDbDataReader myDataReader;

			try
			{
				myConnection.Open();
				myDataReader = myCommand.ExecuteReader();
				OKFlag = true;
			}
			catch (OleDbException ex)
			{
				Console.Write("There was a Select Chairperson error: " + ex.Message);
				myConnection.Close();
				OKFlag = false; // returns false if Select was unsuccessful
				myDataReader = null;
			}

			return myDataReader;
		} // end SelectOwlMemberFromChairperson

		// ********** End of SELECT methods **********



		// ********** UPDATE Methods ********** 

		// Updates records from OwlMember, Faculty, Student, UndergraduateStudent and GraduateStudent tables that match integer parameter OwlMemberID
		public bool UpdateOwlMember(int OwlMemberID, string OwlMemberName, DateTime OwlMemberBirthdate)   // ***** DateTime ???
        {
            string strUpdateOwlMember = "UPDATE OWLMEMBER SET " + 
                                     "fldName = '" + OwlMemberName + "', fldBirthdate = '" + OwlMemberBirthdate + "' " +
                                     " WHERE fldID = " + OwlMemberID ;  // Update OwlMember record that matches the ID

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateOwlMember, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update OwlMember error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }
            return true; // returns true if Update was successful
        }  // end UpdateOwlMember



        // Updates record from Faculty table that match integer parameter OwlMemberID
        public bool UpdateFaculty(int FacultyID, string FacultyDepartment, string FacultyRank)
        {
            string strUpdateFaculty = "UPDATE FACULTY SET " +
				                    "fldDepartment = '" + FacultyDepartment + "' , fldRank = '" + FacultyRank + "' " + 
				                    "WHERE fldID = " + FacultyID ;  

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateFaculty, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Faculty error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }  // end Update Faculty



        // Updates records from Student table that match integer parameter OwlMemberID
        public bool UpdateStudent(int StudentID, String StudentMajor, Decimal StudentGPA)
        {
            // string strUpdateStudent = "SELECT * FROM STUDENT WHERE Student.StudentID = " + OwlMemberID; // string select statement
            string strUpdateStudent = "UPDATE STUDENT SET fldMajor = '" + StudentMajor + "' , fldGPA = " + StudentGPA + 
				                       " WHERE fldID = " + StudentID;   
        

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateStudent, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Student error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        }  // end UpdateStudent



        // Updates records from UndergraduateStudent table that match integer parameter OwlMemberID
        public bool UpdateUndergraduateStudent(int UndergraduateStudentID, decimal UndergraduateStudentTuition, 
			string UndergraduateStudentYear, decimal UndergraduateStudentCredits)
        {
            string strUpdateUndergraduateStudent = 
				"UPDATE UNDERGRADUATESTUDENT SET fldTuition = " + UndergraduateStudentTuition + 
				", fldYear = '"+ UndergraduateStudentYear + "', fldCredits = " + UndergraduateStudentCredits +
                " WHERE fldID = " + UndergraduateStudentID;   

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateUndergraduateStudent, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update UndergraduateStudent error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        } // end UpdateUndergraduateStudent



        // Updates records from GraduateStudent table that match integer parameter OwlMemberID
        public bool UpdateGraduateStudent(int GraduateStudentID, decimal GraduateStudentStipend, string GraduateStudentDegreeProgram)
        {
            string strUpdateGraduateStudent = "UPDATE GRADUATESTUDENT SET fldStipend = " + GraduateStudentStipend + 
				", '" + GraduateStudentDegreeProgram + "' WHERE fldID = " + GraduateStudentID;   

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateGraduateStudent, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update GraduateStudent error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
        } // end UpdateGraduateStudent



		// Updates records from Chairperson table that match integer parameter OwlMemberID
		public bool UpdateChairperson(int ChairpersonID, decimal ChairpersonStipend)
		{
			string strUpdateGraduateStudent = "UPDATE GRADUATESTUDENT SET fldStipend = " + ChairpersonStipend +
				 " WHERE fldID = " + ChairpersonID;

			OleDbConnection myConnection = new OleDbConnection(strConnection);      			OleDbCommand myCommand = new OleDbCommand(strUpdateGraduateStudent, myConnection);

			try
			{
				myConnection.Open();
				myCommand.ExecuteNonQuery();
			}
			catch (OleDbException ex)
			{
				Console.Write("There was an Update GraduateStudent error: " + ex.Message);
				myConnection.Close();
				return false; // returns false if Update was unsuccessful
			}

			return true; // returns true if Update was successful
		} // end UpdateChairperson

		// ********** End of UPDATE methods **********



		// ********** DELETE Method ********** 
		// Deletes records from OwlMember, Faculty, Student, Manager, and GraduateStudent tables that match integer parameter OwlMemberID

		// Uses strConnection to open a connection with the database
		// Deletes OwlMember with given ID from every table in the database
		// If a OwlMember with the given ID is not in a table, the Delete command does nothing
		// Code written by Christopher Tither and Frank Branigan, CIS 3309 Section 1, April 2017
		public void Delete(int OwlMemberID)
        {
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command1 = new OleDbCommand("DELETE FROM OwlMember WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command1.ExecuteReader();
                    }
                    using (OleDbCommand command2 = new OleDbCommand("DELETE FROM Faculty WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command2.ExecuteReader();
                    }
                    using (OleDbCommand command3 = new OleDbCommand("DELETE FROM Student WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command3.ExecuteReader();
                    }
                    using (OleDbCommand command4 = new OleDbCommand("DELETE FROM UndergraduateStudent WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command4.ExecuteReader();
                    }
					using (OleDbCommand command5 = new OleDbCommand("DELETE FROM GraduateStudent WHERE fldID = " + OwlMemberID, connection))
					{
						OleDbDataReader reader = command5.ExecuteReader();
					}
					using (OleDbCommand command6 = new OleDbCommand("DELETE FROM Chairperson WHERE fldID = " + OwlMemberID, connection))
					{
						OleDbDataReader reader = command6.ExecuteReader();
					}
					connection.Close();
                }
                 catch (OleDbException ex)
                {
                    Console.Write("Error: " + ex.Message);
                    connection.Close();
                }
            }  // end using block
            // FormController.clear(this);
        }  // end Delete


        // Close connection
        void closeConnection()
        {
            // CloseConnection();

        }  // end close connection
    } // end of OwlMember class
} // end of namespace
