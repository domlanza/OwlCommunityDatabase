// Owl Memeber Class
// Responsible for all processing related to an Owl Member


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// For serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;


namespace OwlCommunityMemberLanzaDrafts
{
    [Serializable()]
    public abstract class OwlMember
    {
        private int hiddenID;
        private string hiddenName;
        private DateTime hiddenBirthDate;

        //parameterless Constructor
        public OwlMember()
        {
            hiddenID = 0;
            hiddenName = "";
            hiddenBirthDate = DateTime.Now;

        }

        // Parameterized constructor
        public OwlMember(int id, string name, DateTime bd)
        {
            hiddenName = name;
            hiddenBirthDate = bd;
            hiddenID = id;
        }

        // Accessor Mutator for id
        public int OwlID
        {
            get
            {
                return hiddenID;
            }
            set   // (string value)
            {
                hiddenID = value;
            }
        }


        // Accessor Mutator for name
        public string OwlName
        {
            get
            {
                return hiddenName;
            }
            set   
            {
                hiddenName = value;
            }
        }


        // Accessor Mutator for birth date
        public DateTime OwlBirthDate
        {
            get
            {
                return hiddenBirthDate;
            }
            set   
            {
                hiddenBirthDate = value;
            }
        }


        public virtual void Save(frmOwlCommunity f)
        {
            hiddenName = f.txtOwlMemberName.Text;
            hiddenBirthDate = DateTime.Parse(f.dtpOwlMemberBirthDate.Text);
            hiddenID = Convert.ToInt32(f.txtOwlMemberID.Text);

        }

        public virtual void Display(frmOwlCommunity f)
        {
            f.txtOwlMemberName.Text = hiddenName;
            f.dtpOwlMemberBirthDate.Text = hiddenBirthDate.ToShortDateString();
            f.txtOwlMemberID.Text = hiddenID.ToString();

        }

        public override string ToString()
        {
            string s = 
            "OwlName:   " + hiddenName + "\n" +
            "OwlBirthDate:   " + hiddenBirthDate.ToShortDateString() + "\n" +
            "OwlID:   " + hiddenID;
            return s;

        }
    }
}
