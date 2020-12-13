using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlCommunityMemberLanzaDrafts
{
    [Serializable()]
    public class FacultyChairPerson : FacultyMember
    {
        private decimal chairStipend;

        // Parameterless Constructor
        public FacultyChairPerson()
        {
            chairStipend = 0;
        }

        public FacultyChairPerson(string name, int id, DateTime dob, string rank,
            string department, decimal stipend) : base(name, id, dob, department, rank)
        {
            chairStipend = stipend;
        }
        
        
        // Accessor and Mutator for Stipend
        public decimal getChairPersonStipend()
        {
            return chairStipend;
        }
        public void setChairPersonStipend(decimal value)
        {
             chairStipend = value;
        }

        public override void Save(frmOwlCommunity f)
        {
            base.Save(f);
            chairStipend = Convert.ToDecimal(f.txtChairPersonStipend.Text);
        }

        public override void Display(frmOwlCommunity f)
        {
            base.Display(f);
            f.txtChairPersonStipend.Text = chairStipend.ToString();
        }

        public override string ToString()
        {
            string s =
            "FacultyChairPerson"  + "\n" +
             base.ToString() +
            "ChairPersonStipend:   " + chairStipend.ToString();
            return s+"\n";
        }


    }
}
