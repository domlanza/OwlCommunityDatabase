//Validator class is responsible for accepting the correct input from user in both creation and editing of 
//owlmember list items

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwlCommunityMemberLanzaDrafts
{
    [Serializable()]
    public static class Validators
    {


        public static bool ValidateOwlMember(string id, string name, string dob)
        {
            if (ValidateOwlMemberID(id) && ValidateOwlMemberName(name) && ValidateOwlMemberDOB(dob))
            {
                return true;
            }
            /*f.txtOwlMemberID.Clear();
            f.txtOwlMemberName.Clear();
            f.grpOwlMember.Focus();*/
            return false;
        }

        //Validate OwlMember ID
        public static bool ValidateOwlMemberID(string ID)
        {
            if (ID == " ")
            {
                MessageBox.Show("Owl Member ID has been left blank." + "\n" +
                                "Please enter the Owl Member ID.",
                                "Empty Owl Member ID");
                return false;
            }
            else if (ID.Length != 9)
            {
                MessageBox.Show("The Owl Member ID that was entered does not exactly match the 9 digit requirement." + "\n" +
                                "Please re-enter the Owl Member ID",
                                "Invalid ID Length");
                return false;
            }
            else
            {
                return true;

            }
            
        }   // End ValidateOwlMemberID

        public static bool ValidateOwlMemberName(string name)
        {
            if (name == "")
            {
                MessageBox.Show("Owl Member Name has been left blank." + "\n" +
                                "Please enter the Owl Member Name.",
                                "Empty Owl Member Name");
                return false;
            }
            return true;
        }   // End ValidateOwlMemberName

        public static bool ValidateOwlMemberDOB(string dob)
        {
            if(dob.Length == 0)
            {
                return false;
            }
            else
            {
                try
                {
                    DateTime bd = DateTime.Parse(dob);
                    //if(bd.Year - DateTime.Now.Year > 17)
                    //{
                    //    return true;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("DOB is is not greater than standard minimum age for Owlmember");
                    //    return false;
                    //}
                }
                catch(Exception e)
                {
                    MessageBox.Show("DOB is incorrect format");
                }
            }
            return true;
        }

        public static bool ValidateStudent(string major, string gpa)
        {
                if ( gpa.Length == 0)
                {
                    MessageBox.Show("Student GPA has been left blank." + "\n" +
                                   "Please enter the Student GPA.",
                                   "Empty Student GPA");
                    return false;
                }
                else if (major.Length == 0)
                {
                    MessageBox.Show("Student Major has been left blank." + "\n" +
                                   "Please enter the Student Major.",
                                   "Empty Student Major");
                    /*f.txtStudentMajor.Focus();*/
                    return false;
                }
                else
                {
                    try
                    {
                        decimal Gpa = Convert.ToDecimal(gpa);
                        string Major = Convert.ToString(major);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Student input can not be accepted");
                        /*f.txtStudentGPA.Clear();
                        f.txtStudentMajor.Clear();
                        f.txtStudentGPA.Focus();
                        f.txtStudentMajor.Focus();*/
                        return false;
                    }
                }
                return true;
            
        }

        public static bool ValidateUndergraduateStudent(string tuition, string year, string credits)
        {
                if (ValidateUndergraduateStudentTution(tuition) && 
                    ValidateUndergraduateStudentCredits(credits) && year != null)
                {
                    return true;
                }
                else
                {
                return false;
                }
                /*f.txtUndergraduateStudentTuition.Clear();
                f.txtUndergraduateStudentCredits.Clear();
                f.grpUndergraduateStudent.Focus();*/
           
        }

        public static bool ValidateUndergraduateStudentTution(string tuition)
        {
            if(tuition == "" || tuition == null)
            {
                MessageBox.Show("No value present for Tution");
                return false;
            }
            else
            {
                try
                {
                    decimal t = Convert.ToDecimal(tuition);
                }
                catch(Exception e)
                {
                    MessageBox.Show("Student tuition can not be accepted");
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateUndergraduateStudentCredits(string credits)
        {
            if (credits == "" || credits == null)
            {
                MessageBox.Show("No value present for Credits");
                return false;
            }
            else
            {
                try
                {
                    int c = Convert.ToInt32(credits);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Student credits can not be accepted");
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateGraduateStudent(string stipend, string degree)
        {
                if (ValidateGraduateStudentStipend(stipend) &&
                    ValidateGraduateStudentDegreeProgram(degree))
                {
                    return true;
                }
                else
                {
                /*f.txtGraduateStudentStipend.Clear();
                f.grpGraduateStudent.Focus();*/
                return false;
                }
                
        }

        public static bool ValidateGraduateStudentDegreeProgram(string deg)
        {
            if (deg == "" || deg == null)
            {
                MessageBox.Show("No value present for Degree Program, please choose");
                return false;
            }
           
            return true;
        }

        public static bool ValidateGraduateStudentStipend(string stipend)
        {
            if (stipend == "" || stipend == null)
            {
                MessageBox.Show("No value present for Graduate Student Stipend");
                return false;
            }
            else
            {
                try
                {
                    decimal c = Convert.ToDecimal(stipend);
                    if(c < 0)
                    {
                        MessageBox.Show("Stipend must be greater than zero");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("GraduateStudent stipend can not be accepted");
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateFaculty(string dep, string rank)
        {
                if (ValidateFacultyDepartment(dep) 
                    && ValidateFacultyRank(rank))
                {
                    return true;
                }
                else
                {
                return false;
                }  
        }

        public static bool ValidateFacultyRank(string rank)
        {
            if (rank == "" || rank == null)
            {
                MessageBox.Show("No value present for Faculty Rank");
                return false;
            }

            return true;
        }

        public static bool ValidateFacultyDepartment(string dep)
        {
            if (dep == "" || dep == null)
            {
                MessageBox.Show("No value present for Faculty Department");
                return false;
            }
            return true;
        }

        public static bool ValidateFacultyChairPerson(string stipend)
        {
            if (ValidateChairPersonStipend(stipend))
                return true;
            else
                return false;
        }

        public static bool ValidateChairPersonStipend(string stipend)
        {
            if (stipend == "" || stipend == null)
            {
                MessageBox.Show("No value present for Chair Person Stipend");
                return false;
            }
            else
            {
                try
                {
                    decimal c = Convert.ToDecimal(stipend);
                    if (c < 0)
                    {
                        MessageBox.Show("Stipend must be greater than zero");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("ChairPerson stipend can not be accepted");
                    return false;
                }
            }
            return true;
        }
    }


   
}
