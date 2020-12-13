using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlCommunityMemberLanzaDrafts
{
    [Serializable()]
    public class UndergraduateStudent : Student
    {
        private decimal studentTuition;
        private int studentCredits;
        private string studentYear;

        //Default Constructor
        public UndergraduateStudent()
        {
            studentTuition = 0;
            studentCredits = 0;
            studentYear = "";

        }

        //Constructor to set fields
        public UndergraduateStudent(string name, int id, DateTime dob, decimal gpa, string major,
            decimal tuition, int credits, string year) : base(name, id, dob, major, gpa)
        {
            studentTuition = tuition;
            studentCredits = credits;
            studentYear = year;

        }
        // Accessor and Mutator 
        public decimal getUndergraduateStudentTuition()
        {
            return studentTuition;
        }

        public void setUndergraduateStudentTuition(decimal value)
        {
           studentTuition = value;
        }

        // Accessor and Mutator 
        public int getUndergraduateStudentCredits()
        {
                return studentCredits;
        }
        public void setUndergraduateStudentCredits(int value)
        {
                studentCredits = value;
        }
        

        // Accessor and Mutator 
        public string getUndergraduateStudentYear()
        {
           return studentYear;
        }
        public void setUndergraduateStudentYear(string value)
        {
                studentYear = value;
        }



        public override void Save(frmOwlCommunity f)
        {
            base.Save(f);
			studentTuition = Convert.ToDecimal(f.txtUndergraduateStudentTuition.Text);
			studentYear = f.cbUndergraduateStudentYear.Text;
			studentCredits = Convert.ToInt32(f.txtUndergraduateStudentCredits.Text);

        }




        public override void Display(frmOwlCommunity f)
        {
             base.Display(f);
             f.txtUndergraduateStudentTuition.Text = studentTuition.ToString();
             f.cbUndergraduateStudentYear.Text = studentYear;
             f.txtUndergraduateStudentCredits.Text = studentCredits.ToString();
        }

        public override string ToString()
        {
            string s = 
            "UndergraduateSudent \n" + 
            base.ToString() + "\n" +
            "Student Tuition:  " + studentTuition.ToString() + "\n " + 
            "Student Year:  " + studentYear + "\n" + 
            "Student Credits:  " + studentCredits.ToString();
            return s+"\n";

        }







    }
}
