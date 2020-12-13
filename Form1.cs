using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwlCommunityMemberLanzaDrafts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Checks if Owl List is empty and, if not, copies the data for the
        // ith Owl to the appropriate group textboxes using the display sub.
        // Also checks to determine if the next button should be enabled.
        private void getItem(int i)
        {
            if (thisOwlMemberList.Count() == 0)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                // btnToString.Enabled = false;
                lblUserMessage.Text = "Please select an operation";
            }
            else if (i < 0 || i >= thisOwlMemberList.Count())
            {
                MessageBox.Show("getItem error: index out of range");
                return;
            }
            else
            {
                currentIndex = i;
                thisOwlMemberList.getAnItem(i).Display(this);
                // thisOwlList.RemoveAt(i);
                lblUserMessage.Text = "Object Type: " + thisOwlMemberList.getAnItem(i).GetType().ToString() +
                        " List Index: " + i.ToString();
                btnFind.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }  // end else
        } // end getItem


        //Displays the part of the form for Faculty processing
        void DisplayFacultyForm()
        {
            // Display form for Create/Insert or Find/SELECT or Edit/Update or Delete a Undergrad
            btnCreateFaculty.Text = "Save Faculty";
            FormController.formAddMode(this);
            txtOwlMemberID.Enabled = true;
            txtOwlMemberName.Enabled = true;
            txtOwlMemberBirthDate.Enabled = true;
            txtFacultyDepartment.Enabled = true;
            txtFacultyRank.Enabled = true;
            btnCreateGraduateStudent.Enabled = false;
            btnCreateUndergraduateStudent.Enabled = false;
            btnCreateChairperson.Enabled = false;
            txtChairpersonStipend.Enabled = false;
            FormController.activateFaculty(this);
            FormController.deactivateGraduateStudent(this);
            FormController.deactivateChairperson(this);
            FormController.deactivateUndergraduateStudent(this);
            toolTip1.SetToolTip(btnCreateFaculty, ttSaveFaculty);
            // txtFacultyDepartment.Enabled = true;   
            // txtFacultyRank.Enabled = true;
        } // end DisplayFacultyForm

        private void btnEdit_Click(object sender, EventArgs e)
        {

            bool success;
            btnFind.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveEditUpdate.Enabled = false;
            success = findAnItem("Edit/Update");
            if (success)
            {
                btnSaveEditUpdate.Enabled = true;
                btnEdit.Enabled = false;

                OwlMember p = thisOwlMemberList.getAnItem(currentIndex);
                txtOwlMemberName.Text = p.OwlName;
                txtOwlMemberID.Text = p.owlID.ToString();
                txtOwlMemberBirthDate.Text = Convert.ToDateTime(p.owlBirthDate).ToString("MM/dd/yyyy");
                MessageBox.Show("Edit/UPDATE current Owl (as shown). Press Save Updates Button", "Edit/Update Notice",
                    MessageBoxButtons.OK);
                // if (thisOwlList.getAnItem(currentIndex).GetType().ToString() == "EmpMan.Undergrad")
                if (p.GetType() == typeof(UndergraduateStudent))
                {
                    FormController.activateUndergraduateStudent(this);
                    FormController.deactivateFaculty(this);
                    FormController.deactivateGraduateStudent(this);
                    FormController.deactivateChairperson(this);
                    FormController.deactivateAddButtons(this);
                    txtStudentMajor.Text = ((Student)p).studentMajor;
                    txtStudentGPA.Text = ((Student)p).studentGPA.ToString();
                    txtUndergraduateStudentTuition.Text = (((UndergraduateStudent)p).getUndergraduateStudentTuition()).ToString();
                    txtUndergraduateStudentYear.Text = (((UndergraduateStudent)p).getUndergraduateStudentYear());
                    txtUndergraduateStudentCredits.Text = (((UndergraduateStudent)p).getUndergraduateStudentCredits()).ToString();
                }
                else if (p.GetType() == typeof(GraduateStudent))
                {
                    FormController.activateGraduateStudent(this);
                    FormController.deactivateFaculty(this);
                    FormController.deactivateUndergraduateStudent(this);
                    FormController.deactivateChairperson(this);
                    FormController.deactivateAddButtons(this);
                    txtStudentMajor.Text = ((Student)p).studentMajor;
                    txtStudentGPA.Text = ((Student)p).studentGPA.ToString();
                    txtGraduateStudentStipend.Text = (((GraduateStudent)p).getGraduateStudentStipend()).ToString();
                    txtGraduateStudentDegreeProgram.Text = (((GraduateStudent)p).getGraduateStudentDegreeProgram()).ToString();
                }

            }
        }

        // Display Undergrad, Faculty, or GradStudent Form Depending on Type of Object Found
        void displayRelevantFormPart(OwlMember p)
        {
            if (p.GetType() == typeof(UndergraduateStudent))
            {
                FormController.activateUndergraduateStudent(this);
                FormController.deactivateGraduateStudent(this);
                FormController.deactivateFaculty(this);
                FormController.deactivateChairperson(this);

            }
            else if (p.GetType() == typeof(GraduateStudent))
            {



            }//close else if
        }//end displayRelevatnFormPart

        private void btnFind_Click(object sender, EventArgs e)
        {
            findAnItem("Find");
        }//end btnFind






        // Validates OwlID and Tries to Find It
        private bool findAnItem
            (string operationType)
        {
            bool success;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveEditUpdate.Enabled = false;
            if (Validators.ValidateOwlMemberID(txtOwlMemberID.Text) == false)
            {
                MessageBox.Show("Valid Owl ID required for a " + operationType + " Renter ID.",
                    "Invalid ID for " + operationType, MessageBoxButtons.OK);
                FormController.clear(this);
                txtOwlMemberID.Text = "";
                txtOwlMemberID.Focus();
                // FormController.resetForm(this);
                success = false;
            }
            else if (thisOwlMemberList.Count() == 0)
            {
                MessageBox.Show("No Owls to " + operationType + "Try a different command.",
                    "No " + operationType + " Empty List", MessageBoxButtons.OK);
                FormController.clear(this);
                txtOwlMemberID.Text = "";
                txtOwlMemberID.Focus();
                // FormController.resetForm(this);
                success = false;
            }
            else
            {
                // Try to find and display item to process
                bool found;
                currentIndex = thisOwlMemberList.searchOwlMemberList(Convert.ToInt32(txtOwlMemberID.Text), out found);
                if (!found)  // Display results for processing (Find, Delete, or Edit/Update)
                {
                    MessageBox.Show("Error. ID entered does not appear in the OwlList. Reenter.",
                        "ID Not Found Error on " + operationType, MessageBoxButtons.OK);
                    txtOwlMemberID.Text = "";
                    txtOwlMemberID.Focus();
                    success = false;
                }
                else
                // Verify and then display list element and DB element
                {
                    OwlMember p = thisOwlMemberList.getAnItem(currentIndex);
                    displayRelevantFormPart(p);
                    p.Display(this);
                    success = true;
                    recordsProcessedCount++;
                }  // end if-else on found
            }  // end multiple alternative if
            return success;
        }  // end findAnItem

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}

