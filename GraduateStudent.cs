using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlCommunityMemberLanzaDrafts
{
    [Serializable()]
    public class GraduateStudent : Student
    {
        private decimal studentStipend;
        private string studentDegreeProgram;

        //parameterless constructor
        public GraduateStudent()
        {
            studentStipend = 0;
            studentDegreeProgram = "";
        }

        public GraduateStudent(string name, int id, DateTime dob, string major, decimal gpa,
            decimal stip, string dp) : base(name, id, dob, major, gpa)
        {
            studentStipend = stip;
            studentDegreeProgram = dp;
        }

        // Accessor Mutator for Stipend
        public decimal getGraduateStudentStipend()
        {
           return studentStipend;
        }
        public void setGraduateStudentStipend(decimal value)
        {
           studentStipend = value;
        }

        // Accessor Mutator for degreeProgram
        public string getGraduateStudentDegreeProgram()
        {
           return studentDegreeProgram;
        }
        public void setGraduateStudentDegreeProgram(string value)
        {
           studentDegreeProgram = value;
        }

        public override void Save(frmOwlCommunity f)
        {
            base.Save(f);
            studentStipend = Convert.ToDecimal(f.txtGraduateStudentStipend.Text);
            studentDegreeProgram = f.cbGraduateStudentDegreeProgram.Text;
        }
        public override void Display(frmOwlCommunity f)
        {
            base.Display(f);
            f.txtGraduateStudentStipend.Text = studentStipend.ToString();
            f.cbGraduateStudentDegreeProgram.Text = studentDegreeProgram;
        }
        public override string ToString()
        {
            string s =
            "GraduateSudent \n" +
            base.ToString() + "\n" +
            "Student Stipend:  " + studentStipend.ToString() + "\n " +
            "Student Degree Program:  " + studentDegreeProgram;
            return s + "\n";
        }


    }
}
