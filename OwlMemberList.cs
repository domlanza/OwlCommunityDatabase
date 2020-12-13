using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwlCommunityMemberLanzaDrafts
{

    [Serializable()]
    public class OwlMemberList
    {
        private List<OwlMember> memberList = new List<OwlMember>();
        //private OwlMember currentMember;
        private int Count;

        //Parameterless Constructor
        public OwlMemberList()
        {
            Count = 0;
        }

        //Returns number of members in the member list
        public int getCount()
        {
            return Count;
        }

        //returns member at the given index
        public OwlMember getAnItem(int index)
        {
            return memberList[index];
        }

        //Add member to list
        public void addToList(OwlMember member)
        {

            bool found = false;
            int result = searchOwlMemberList(member.OwlID, out found);
            if(found  == false)
            {
                memberList.Add(member);
                Count++;
               //MessageBox.Show("just added " + member.ToString());
            }
            else
            {
                MessageBox.Show("Member already contained in list");
                displayMembers();
            }

           
           
        }

        //Remove from list
        public void removeFromList(OwlMember member)
        {
            memberList.Remove(member);
            Count--;
        }

        //Search member in the list
        public int searchOwlMemberList(int ID, out bool found)
        {
            found = false;
            int count = 0;
            foreach (OwlMember member in memberList)
            {
                if (member.OwlID == ID)
                {
                    found = true;
                    break;
                }
                else
                {
                    count++;
                    found = false;
                }
            }
            return count;
        }

        //Display the list
        public void displayMembers()
        {
            string display = "";
            foreach (OwlMember member in memberList)
            {
                display += member.ToString() +"\n";
            }

            MessageBox.Show(display);
        }
    }
}

