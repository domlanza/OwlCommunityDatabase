// Responsible for all processing related to a Student

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;


namespace OwlCommunityMemberLanzaDrafts
{
    [Serializable()]
    public class Student: OwlMember
    {
        private string hiddenStudentMajor;
        private decimal hiddenStudentGPA;

        //Parameterless Constructor
        public Student()
        {
            hiddenStudentMajor = "";
            hiddenStudentGPA = 0.0m;
        }

        //Parameterized COnstructor

        public Student(string name, int id, DateTime dob, string maj, decimal gpa) : base(id, name, dob)
        {
            hiddenStudentMajor = maj;
            hiddenStudentGPA = gpa;

        }

        // Accessor/mutator
        public string getStudentMajor()
        {
            return hiddenStudentMajor;
        }

        public void  setStudentMajor(string value)
        {
            hiddenStudentMajor = value;
        }


        // Accessor/mutator 
        public decimal getStudentGPA()
        {
            return hiddenStudentGPA;
        }

        public void setStudentGPA(decimal value)
        { 
           hiddenStudentGPA = value;
        }


        public override void Save(frmOwlCommunity f)
        {
            base.Save(f);
            hiddenStudentGPA = Convert.ToDecimal(f.txtStudentGPA.Text);
            hiddenStudentMajor = f.txtStudentMajor.Text;

        }

        public override void Display(frmOwlCommunity f)
        {
            base.Display(f);
            f.txtStudentGPA.Text = Convert.ToString(hiddenStudentGPA);
            f.txtStudentMajor.Text = hiddenStudentMajor;
        }

        public override string ToString()
        {
            string s =  
            base.ToString() + "\n" +
            "Student Major:  " + hiddenStudentMajor + "\n" +
            "Student Gpa:  " +  hiddenStudentGPA.ToString();
            return s;
        }

    }
}
