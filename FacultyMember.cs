using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlCommunityMemberLanzaDrafts
{
    [Serializable()]
   public class FacultyMember: OwlMember
    {
        private string facultyDepartment;
        private string facultyRank;

        //Empty constructor
        public FacultyMember()
        {
            facultyDepartment = "";
            facultyRank = "";
        }

        public FacultyMember(string name, int id, DateTime dob, string dept, string rank) 
            : base(id, name, dob)
        {
            facultyDepartment = dept;
            facultyRank = rank;
        }

        // Mutator and Accessor for Department
        public string getFacultyDepartment()
        {
            return facultyDepartment;
        }
        public void setFacultyDepartment(string value)
        {
                facultyDepartment = value;
        }
        

        // Mutator and Accessor for Rank
        public string getFacultyRank()
        {
            return facultyRank;
        }
         public void setFacultyRank(string value)
        {
                facultyRank = value;
        }
        

        public override void Save(frmOwlCommunity f)
        {
            base.Save(f);
            facultyDepartment = f.txtFacultyDepartment.Text;
            facultyRank = f.cbFacultyRank.Text;

        }

        public override void Display(frmOwlCommunity f)
        {
            base.Display(f);
            f.txtFacultyDepartment.Text = facultyDepartment;
            f.cbFacultyRank.Text = facultyRank;
        }

        public override string ToString()
        {
            string s = 
                "FacultyMember" + "\n" +
                 base.ToString() + "\n" +
                "Department:  " + facultyDepartment.ToString() + " \n" + 
                "Rank:  " + facultyRank;
            return s+"\n";
        }


    }
}
