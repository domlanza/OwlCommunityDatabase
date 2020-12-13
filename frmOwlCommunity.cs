using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OwlCommunityMemberLanzaDrafts
{
    public partial class frmOwlCommunity : Form
    {
        // OwlMemberList thisOwlMemberList = new OwlMemberList();

        OwlMemberDB dbFunctions = new OwlMemberDB();
        OleDbDataReader myDataReader;
        string type = " ";
        string operationType = " ";
        //private bool addMode = false;
        //private int selectedMember;
        //private bool editMode = false;
        //private OwlMember member;
        public frmOwlCommunity()
        {
            InitializeComponent();
            /*SFManager.readFromFile(ref thisOwlMemberList, FileName);
            thisOwlMemberList.addToList(new UndergraduateStudent("John", 123456789, DateTime.Today, 455, "Math", 455, 12, "Fr"));
            SFManager.writeToFile(thisOwlMemberList, FileName);*/


        }

        // This index keeps track of the current Owl
        //int currentIndex = -1;
        int recordsProcessedCount = 0;
        int id;
        //// File to read or write to
        //string FileName = "PersistentObject.bin";

        // Tooltip messages
        string ttCreateUndergraduateStudent = "Click to enter Make Undergrad mode to add an Undergrad to the List of Owl Members.";
        string ttCreateGraduateStudent = "Click to enter Make GradStudent mode to add a GradStudent to the List of Owl Members.";
        string ttCreateFaculty = "Click to enter Make Faculty mode to add a Faculty to the List of Owl Members.";
        string ttCreateChairperson = "Click to enter Make ChairOwl mode to add a ChairOwl to the List of Owl Members.";
        string ttSaveUndergraduateStudent = "Click to Save the Undergrad to the List of Owl Members.";
        string ttSaveGraduateStudent = "Click to Save the GradStudent to the List of Owl Members.";
        string ttSaveChairperson = "Click to Save a Chairperson to the list of Owl Members.";
        string ttSaveFaculty = "Click to Save the Faculty to the List of Owl Members.";
        string ttClear = "Click to Clear Form.";
        string ttFind = "Click to Find a Owl in the List of Owl Members.";
        string ttDelete = "Click to Delete Owl from the List of Owl Members.";
        string ttEdit = "Click to Edit a Owl's data.";
        string ttExit = "Click to exit application.";

        string ttStudentMajor = "Enter 2 to 4 character major title - e.g., CIS, I&ST, MATH, Soc, Mus";
        string ttStudentGPA = "Enter a decimal between 0.0 and 4.0 inclusive";
        string ttUndergradTuition = "Enter dollars and cents.   No $.";
        string ttUndergradYear = "Enter mm/dd/yyyy";
        string ttUndergradCredits = "Enter an integer between 0 and 200";
        string ttGraduateStudentStipend = "Enter dollars and cents >= 0.0.  NO $";
        string ttGraduateStudentDegreeProgram = "Enter valid degree program name from table.";
        string ttOwlName = "Enter A .. Z and a .. z ONLY";
        string ttOwlBirthDate = "Enter mm/dd/yyyy";
        string ttOwlID = "Enter Exactly 9 Digits";
        string ttFacultyDepartment = "Enter department ID (two or three capital letters)";
        string ttFacultyRank = "Enter Faculty Rank as AstP, AscP, Prof, Lect, or Inst";
        string ttChairpersonStipend = "Enter dollars and cents >= 0.0.  NO $";


        private void frmOwlCommunity_Load(System.Object sender, System.EventArgs e)
        {
            // Read serialized binary data file
            /*SFManager.readFromFile(ref thisOwlMemberList, FileName);*/

            FormController.clear(this);
            FormController.activateAddButtons(this);

            // get initial Tooltips
            toolTip1.SetToolTip(btnCreateGraduateStudent, ttCreateGraduateStudent);
            toolTip1.SetToolTip(btnCreateUndergraduateStudent, ttCreateUndergraduateStudent);
            toolTip1.SetToolTip(btnCreateFaculty, ttCreateFaculty);
            toolTip1.SetToolTip(btnCreateChairperson, ttCreateChairperson);

            toolTip1.SetToolTip(btnClear, ttClear);
            toolTip1.SetToolTip(btnDelete, ttDelete);
            toolTip1.SetToolTip(btnEdit, ttEdit);
            toolTip1.SetToolTip(btnFind, ttFind);
            toolTip1.SetToolTip(btnExit, ttExit);

            toolTip1.SetToolTip(txtUndergraduateStudentTuition, ttUndergradTuition);
            toolTip1.SetToolTip(cbUndergraduateStudentYear, ttUndergradYear);
            toolTip1.SetToolTip(txtUndergraduateStudentCredits, ttUndergradCredits);
            toolTip1.SetToolTip(txtGraduateStudentStipend, ttGraduateStudentStipend);
            toolTip1.SetToolTip(cbGraduateStudentDegreeProgram, ttGraduateStudentDegreeProgram);
            toolTip1.SetToolTip(txtOwlMemberName, ttOwlName);
            toolTip1.SetToolTip(dtpOwlMemberBirthDate, ttOwlBirthDate);
            toolTip1.SetToolTip(txtOwlMemberID, ttOwlID);
            toolTip1.SetToolTip(txtStudentMajor, ttStudentMajor);
            toolTip1.SetToolTip(txtStudentMajor, ttStudentGPA);
            toolTip1.SetToolTip(txtFacultyDepartment, ttFacultyDepartment);
            toolTip1.SetToolTip(cbFacultyRank, ttFacultyRank);
            toolTip1.SetToolTip(txtChairPersonStipend, ttChairpersonStipend);
        } // end frmEmpMan_Load



        // Checks if Owl List is empty and, if not, copies the data for the
        // ith Owl to the appropriate group textboxes using the display sub.
        // Also checks to determine if the next button should be enabled.
        /*private void getItem(int i)
        {
            if (thisOwlMemberList.getCount() == 0)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                // btnToString.Enabled = false;
                lblUserMessage.Text = "Please select an operation";
            }
            else if (i < 0 || i >= thisOwlMemberList.getCount())
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
        } // end getItem*/




        //Displays the part of the form for Faculty processing
        void DisplayFacultyForm()
        {
            // Display form for Create/Insert or Find/SELECT or Edit/Update or Delete a Faculty
            btnCreateFaculty.Text = "Save Faculty";
            FormController.formAddMode(this);
            txtOwlMemberID.Enabled = true;
            txtOwlMemberName.Enabled = true;
            dtpOwlMemberBirthDate.Enabled = true;
            txtFacultyDepartment.Enabled = true;
            cbFacultyRank.Enabled = true;
            btnCreateGraduateStudent.Enabled = false;
            btnCreateUndergraduateStudent.Enabled = false;
            btnCreateChairperson.Enabled = false;
            btnEnterID.Enabled = false;
            //txtChairPersonStipend.Enabled = false;
            FormController.activateFaculty(this);
            FormController.deactivateGraduateStudent(this);
            FormController.deactivateChairperson(this);
            FormController.deactivateUndergraduateStudent(this);
            toolTip1.SetToolTip(btnCreateFaculty, ttSaveFaculty);
            // txtFacultyDepartment.Enabled = true;   
            // cbFacultyRank.Enabled = true;
        } // end DisplayFacultyForm

        void DisplayChairPersonForm()
        {
            // Display form for Create/Insert or Find/SELECT or Edit/Update or Delete a Faculty
            btnCreateChairperson.Text = "Save Chairperson";
            FormController.formAddMode(this);
            txtOwlMemberID.Enabled = true;
            txtOwlMemberName.Enabled = true;
            dtpOwlMemberBirthDate.Enabled = true;
            txtFacultyDepartment.Enabled = true;
            cbFacultyRank.Enabled = true;
            btnCreateGraduateStudent.Enabled = false;
            btnCreateUndergraduateStudent.Enabled = false;
            btnCreateFaculty.Enabled = false;
            btnCreateChairperson.Enabled = true;
            txtChairPersonStipend.Enabled = true;
            btnEnterID.Enabled = false;
            FormController.activateFaculty(this);
            FormController.deactivateGraduateStudent(this);
            FormController.activateChairperson(this);
            FormController.deactivateUndergraduateStudent(this);
            toolTip1.SetToolTip(btnCreateChairperson, ttSaveChairperson);
        } // end DisplayChairpersonForm

        //Displays the part of the form for Undergrad processing
        void DisplayUndergraduateStudentForm()
        {
            // Display form for Create/Insert or Find/SELECT or Edit/Update or Delete a Undergrad
            btnCreateUndergraduateStudent.Text = "Save Undersgraduatestudent";
            FormController.formAddMode(this);
            txtOwlMemberID.Enabled = true;
            txtOwlMemberName.Enabled = true;
            dtpOwlMemberBirthDate.Enabled = true;
            txtFacultyDepartment.Enabled = false;
            cbFacultyRank.Enabled = false;
            btnCreateGraduateStudent.Enabled = false;
            btnCreateUndergraduateStudent.Enabled = true;
            btnCreateFaculty.Enabled = false;
            btnCreateChairperson.Enabled = false;
            txtChairPersonStipend.Enabled = false;
            btnEnterID.Enabled = false;
            FormController.deactivateFaculty(this);
            FormController.deactivateGraduateStudent(this);
            FormController.deactivateChairperson(this);
            FormController.activateUndergraduateStudent(this);

            toolTip1.SetToolTip(btnCreateUndergraduateStudent, ttSaveUndergraduateStudent);
        } // end DisplayFacultyForm

        //Displays the part of the form for Undergrad processing
        void DisplayGraduateStudentForm()
        {
            // Display form for Create/Insert or Find/SELECT or Edit/Update or Delete a Undergrad
            btnCreateGraduateStudent.Text = "Save GraduateStudent";
            FormController.formAddMode(this);
            txtOwlMemberID.Enabled = true;
            txtOwlMemberName.Enabled = true;
            dtpOwlMemberBirthDate.Enabled = true;
            txtFacultyDepartment.Enabled = false;
            cbFacultyRank.Enabled = false;
            btnCreateGraduateStudent.Enabled = true;
            btnCreateUndergraduateStudent.Enabled = false;
            btnCreateFaculty.Enabled = false;
            btnCreateChairperson.Enabled = false;
            txtChairPersonStipend.Enabled = false;
            btnEnterID.Enabled = false;
            FormController.deactivateFaculty(this);
            FormController.activateGraduateStudent(this);
            FormController.deactivateChairperson(this);
            FormController.deactivateUndergraduateStudent(this);
            toolTip1.SetToolTip(btnCreateGraduateStudent, ttSaveGraduateStudent);
        } // end DisplayGraduateForm

        /*private void btnEdit_Click(object sender, EventArgs e)
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
                txtOwlMemberID.Text = p.OwlID.ToString();
                dtpOwlMemberBirthDate.Text = Convert.ToDateTime(p.OwlBirthDate).ToString("MM/dd/yyyy");
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
                    txtStudentMajor.Text = ((Student)p).getStudentMajor();
                    txtStudentGPA.Text = ((Student)p).getStudentGPA().ToString();
                    txtUndergraduateStudentTuition.Text = (((UndergraduateStudent)p).getUndergraduateStudentTuition()).ToString();
                    cbUndergraduateStudentYear.Text = (((UndergraduateStudent)p).getUndergraduateStudentYear());
                    txtUndergraduateStudentCredits.Text = (((UndergraduateStudent)p).getUndergraduateStudentCredits()).ToString();
                }
                else if (p.GetType() == typeof(GraduateStudent))
                {
                    FormController.activateGraduateStudent(this);
                    FormController.deactivateFaculty(this);
                    FormController.deactivateUndergraduateStudent(this);
                    FormController.deactivateChairperson(this);
                    FormController.deactivateAddButtons(this);
                    txtStudentMajor.Text = ((Student)p).getStudentMajor();
                    txtStudentGPA.Text = ((Student)p).getStudentGPA().ToString();
                    txtGraduateStudentStipend.Text = (((GraduateStudent)p).getGraduateStudentStipend()).ToString();
                    cbGraduateStudentDegreeProgram.Text = (((GraduateStudent)p).getGraduateStudentDegreeProgram()).ToString();
                }
                else if (p.GetType() == typeof(FacultyMember))
                {
                    FormController.activateFaculty(this);
                    FormController.deactivateGraduateStudent(this);
                    FormController.deactivateUndergraduateStudent(this);
                    FormController.deactivateChairperson(this);
                    FormController.deactivateAddButtons(this);
                    txtFacultyDepartment.Text = ((FacultyMember)p).getFacultyDepartment();
                    cbFacultyRank.Text = ((FacultyMember)p).getFacultyRank();

                }
                else if (p.GetType() == typeof(FacultyChairPerson))
                {
                    FormController.deactivateFaculty(this);
                    FormController.deactivateGraduateStudent(this);
                    FormController.deactivateUndergraduateStudent(this);
                    FormController.activateChairperson(this);
                    FormController.deactivateAddButtons(this);
                    txtFacultyDepartment.Text = ((FacultyMember)p).getFacultyDepartment();
                    cbFacultyRank.Text = ((FacultyMember)p).getFacultyRank();
                    txtChairPersonStipend.Text = (((FacultyChairPerson)p).getChairPersonStipend()).ToString();
                }


            }
        }*/

        // Display Undergrad, Faculty, or GradStudent Form Depending on Type of Object Found
        void displayRelevantFormPart(string type)
        {
            if (type == "UndergraduateStudent")
            {
                FormController.activateUndergraduateStudent(this);
                FormController.deactivateGraduateStudent(this);
                FormController.deactivateFaculty(this);
                FormController.deactivateChairperson(this);

            }
            else if (type == "GraduateStudent")
            {
                FormController.activateGraduateStudent(this);
                FormController.deactivateUndergraduateStudent(this);
                FormController.deactivateFaculty(this);
                FormController.deactivateChairperson(this);
            }
            else if (type == "Faculty")
            {
                FormController.deactivateStudent(this);
                FormController.deactivateGraduateStudent(this);
                FormController.deactivateUndergraduateStudent(this);
                FormController.activateFaculty(this);
                FormController.deactivateChairperson(this);
            }
            else if (type == "Chairperson")
            {
                FormController.deactivateStudent(this);
                FormController.deactivateGraduateStudent(this);
                FormController.deactivateUndergraduateStudent(this);
                FormController.activateFaculty(this);
                FormController.activateChairperson(this);
            }

        }//end displayRelevatnFormPart


        //private void btnFind_Click(object sender, EventArgs e)
        //{
        //    //findAnItem("Find");
        //    bool OKFlag = true;
        //    if (Validators.ValidateOwlMemberID(txtTargetID.Text))
        //    {
        //        int id = Convert.ToInt32(txtTargetID.Text);
        //        myDataReader = dbFunctions.SelectOwlMemberFromOwlMember(id, out OKFlag);
        //        if (OKFlag)
        //        {
        //            type = myDataReader["fldMemberType"].ToString();
        //            displayDbInformation(type);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error occurred");
        //    }

        //}//end btnFind



        //Validates OwlID and Tries to Find It
        private bool findAnItem
            (string operationType)
        {
            bool success;
            int id = Convert.ToInt32(txtTargetID.Text);

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveEditUpdate.Enabled = false;
            if (Validators.ValidateOwlMemberID(txtTargetID.Text) == false)
            {
                MessageBox.Show("Valid Owl ID required for a " + operationType + " Renter ID.",
                    "Invalid ID for " + operationType, MessageBoxButtons.OK);
                FormController.clear(this);
                //txtOwlMemberID.Text = "";
                txtTargetID.Text = " ";
                //txtOwlMemberID.Focus();
                // FormController.resetForm(this);
                success = false;
            }
            else
            {
                myDataReader = dbFunctions.SelectOwlMemberFromOwlMember(id, out success);
                if (success)  // Display results for processing (Find, Delete, or Edit/Update)
                {
                    //myDataReader.Read();
                    //how to get datastring????
                    //id = convert.toint32(mydatareader["fldid"]);
                    //txtowlmemberid.text = id.tostring();
                    type = myDataReader["fldMemberType"].ToString();
                    displayDbInformation(type);
                }
                else
                {
                    MessageBox.Show("No data returned succesfully");
                }

            }// end multiple alternative if
            return success;
        }  // end findAnItem 


        private void btnExit_Click(object sender, EventArgs e)
        {
            //SFManager.writeToFile(thisOwlMemberList, FileName);
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormController.clear(this);
            FormController.activateAddButtons(this);
            clickCounter = 0;
        }

        private int clickCounter = 0;

        //creates and validates Undergrad student object and inputs
        private void btnCreateUndergraduateStudent_Click(object sender, EventArgs e)
        {
            type = "UndergraduateStudent";
            if (clickCounter == 0)
            {
                DisplayUndergraduateStudentForm();
                //MessageBox.Show("Clickcounter = " + clickCounter);
                clickCounter++;
                //MessageBox.Show("Clickcounter = " + clickCounter);

            }
            else
            {
                if (Validators.ValidateOwlMember(txtOwlMemberID.Text, txtOwlMemberName.Text, dtpOwlMemberBirthDate.Text))
                {
                    bool success = dbFunctions.InsertOwlMember(Convert.ToInt32(txtOwlMemberID.Text),
                        txtOwlMemberName.Text, Convert.ToDateTime(dtpOwlMemberBirthDate.Text), type);

                    if (success)
                    {
                        if (Validators.ValidateUndergraduateStudent(txtUndergraduateStudentTuition.Text, cbUndergraduateStudentYear.Text,
                           txtUndergraduateStudentCredits.Text) && Validators.ValidateStudent(txtStudentMajor.Text, txtStudentGPA.Text))
                        {
                            dbFunctions.InsertStudent(Convert.ToInt32(txtOwlMemberID.Text), txtStudentMajor.Text, Convert.ToDecimal(txtStudentGPA.Text));
                            string tt = txtUndergraduateStudentTuition.Text;
                            string cc = txtUndergraduateStudentCredits.Text;
                            int c = Convert.ToInt32(cc);
                            decimal t = Convert.ToDecimal(tt);
                            dbFunctions.InsertUndergraduateStudent(Convert.ToInt32(txtOwlMemberID.Text), t, cbUndergraduateStudentYear.Text,
                            c);
                            MessageBox.Show("Insertion of Student Successful");
                            FormController.clear(this);
                            FormController.activateAddButtons(this);
                            clickCounter = 0;
                        }
                        else
                        {
                            MessageBox.Show("Insertion of Student failed");
                            return;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Insertion of current OwlMember failed");
                        clickCounter = 0;
                        FormController.clear(this);
                        FormController.activateAddButtons(this);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Validation failed");

                }
            }
        }


        //creates and validates Grad Student object and inputs
        private void btnCreateGraduateStudent_Click(object sender, EventArgs e)
        {
            type = "GraduateStudent";
            DisplayGraduateStudentForm();
            if (clickCounter == 0)
            {
                DisplayGraduateStudentForm();
                //MessageBox.Show("Clickcounter = " + clickCounter);
                clickCounter++;
                //MessageBox.Show("Clickcounter = " + clickCounter);

            }
            else
            {
                if (Validators.ValidateOwlMember(txtOwlMemberID.Text, txtOwlMemberName.Text, dtpOwlMemberBirthDate.Text))
                {
                    bool success = dbFunctions.InsertOwlMember(Convert.ToInt32(txtOwlMemberID.Text),
                        txtOwlMemberName.Text, Convert.ToDateTime(dtpOwlMemberBirthDate.Text), type);

                    if (success)
                    {
                        if (Validators.ValidateGraduateStudent(txtGraduateStudentStipend.Text, cbGraduateStudentDegreeProgram.Text) &&
                            Validators.ValidateStudent(txtStudentMajor.Text, txtStudentGPA.Text))
                        {
                            dbFunctions.InsertStudent(Convert.ToInt32(txtOwlMemberID.Text), txtStudentMajor.Text, Convert.ToDecimal(txtStudentGPA.Text));
                            string xx = txtGraduateStudentStipend.Text;
                            decimal x = Convert.ToDecimal(xx);
                            dbFunctions.InsertGraduateStudent(Convert.ToInt32(txtOwlMemberID.Text), x, cbGraduateStudentDegreeProgram.Text);
                            MessageBox.Show("Insertion of GraduateStudent Successful");
                            FormController.clear(this);
                            FormController.activateAddButtons(this);
                            clickCounter = 0;
                        }
                        else
                        {
                            MessageBox.Show("Insertion of GraduateStudent Was Unsuccessful");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insertion of current OwlMember failed");
                        clickCounter = 0;
                        FormController.clear(this);
                        FormController.activateAddButtons(this);
                        return;
                    }
                }//end if nested if
            }// end else statement
        }//end method


        //creates and validates Faculty member object and inputs
        private void btnCreateFaculty_Click(object sender, EventArgs e)
        {
            type = "Faculty";
            DisplayFacultyForm();
            if (clickCounter == 0)
            {
                DisplayFacultyForm();
                // MessageBox.Show("Clickcounter = " + clickCounter);
                clickCounter++;
                // MessageBox.Show("Clickcounter = " + clickCounter);

            }
            else
            {
                if (Validators.ValidateOwlMember(txtOwlMemberID.Text, txtOwlMemberName.Text, dtpOwlMemberBirthDate.Text))
                {
                    bool success = dbFunctions.InsertOwlMember(Convert.ToInt32(txtOwlMemberID.Text),
                        txtOwlMemberName.Text, Convert.ToDateTime(dtpOwlMemberBirthDate.Text), type);

                    if (success)
                    {

                        if (Validators.ValidateFaculty(txtFacultyDepartment.Text, cbFacultyRank.Text))
                        {
                            dbFunctions.InsertFaculty(Convert.ToInt32(txtOwlMemberID.Text), txtFacultyDepartment.Text, cbFacultyRank.Text);
                            MessageBox.Show("Successful Insertion of Faculty");
                            FormController.clear(this);
                            FormController.activateAddButtons(this);
                            clickCounter = 0;

                        }
                        else
                        {
                            MessageBox.Show("Unsuccessful Insertion of Faculty");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insertion of current OwlMember failed");
                        clickCounter = 0;
                        FormController.clear(this);
                        FormController.activateAddButtons(this);
                        return;
                    }
                }
            }
        }

        //creates and validates ChairPerson object and inputs
        private void btnCreateChairperson_Click(object sender, EventArgs e)
        {
            type = "Chairperson";
            DisplayChairPersonForm();
            if (clickCounter == 0)
            {
                DisplayChairPersonForm();
                //MessageBox.Show("Clickcounter = " + clickCounter);
                clickCounter++;
                //MessageBox.Show("Clickcounter = " + clickCounter);

            }
            else
            {
                if (Validators.ValidateOwlMember(txtOwlMemberID.Text, txtOwlMemberName.Text, dtpOwlMemberBirthDate.Text))
                {
                    bool success = dbFunctions.InsertOwlMember(Convert.ToInt32(txtOwlMemberID.Text),
                        txtOwlMemberName.Text, Convert.ToDateTime(dtpOwlMemberBirthDate.Text), type);

                    if (success)
                    {
                        if (Validators.ValidateFacultyChairPerson(txtChairPersonStipend.Text) &&
                            Validators.ValidateFaculty(txtFacultyDepartment.Text, cbFacultyRank.Text))
                        {
                            string ss = txtChairPersonStipend.Text;
                            decimal st = Convert.ToDecimal(ss);
                            dbFunctions.InsertFaculty(Convert.ToInt32(txtOwlMemberID.Text), txtFacultyDepartment.Text, cbFacultyRank.Text);

                            dbFunctions.InsertChairperson(Convert.ToInt32(txtOwlMemberID.Text), st);
                            MessageBox.Show("Successful Insertion of ChairPerson");
                            FormController.clear(this);
                            FormController.activateAddButtons(this);
                            clickCounter = 0;
                        }
                        else
                        {
                            MessageBox.Show("Unsuccessful Insertion of ChairPerson");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insertion of current OwlMember failed");
                        clickCounter = 0;
                        FormController.clear(this);
                        FormController.activateAddButtons(this);
                        return;
                    }
                }
            }
        }     


        //validates target ID
        private void btnEnterID_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTargetID.Text.Length != 9)
                {
                    MessageBox.Show("Please enter an ID of 9 intergers.");
                    txtTargetID.Text = "";
                    txtTargetID.Focus();
                }
                else
                {
                    btnFind.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid 9 integers ID number");
                txtTargetID.Text = "";
                txtTargetID.Focus();
            }
        }

        //finds items in owlmember list by ID
        private void btnFind_Click_1(object sender, EventArgs e)
        {
           if(findAnItem("Find") == true)
            {
                MessageBox.Show("found it");
            }
            else //findAnItem == false
            {
                MessageBox.Show("Unsuccessful sorry!");
            }   

        }

        //deletes items from owlmember list
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool isFound = findAnItem("Delete"); ;
            //int member2 = thisOwlMemberList.searchOwlMemberList(Convert.ToInt32(txtTargetID.Text), out isFound); 
            if (isFound)
            {
                //OwlMember p = thisOwlMemberList.getAnItem(member2);
                //p.Display(this);

                if (MessageBox.Show("Are you sure you want to delete", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {

                    //thisowlmemberlist.removefromlist(p);
                    //sfmanager.writetofile(thisowlmemberlist, filename);
                    id = Convert.ToInt32(txtTargetID.Text);
                    dbFunctions.Delete(id);
                    FormController.clear(this);
                    txtTargetID.Text = "";

                }
                else
                {
                    MessageBox.Show("Delete action aborted");
                    FormController.clear(this);

                }
            }
            else
            {
                MessageBox.Show("No member exists with that ID");
            }
        }

        //saves updates in owlmemberList
        /*  private void btnSaveEditUpdate_Click(object sender, EventArgs e)
          {
              bool isFound = false;
              int member2 = thisOwlMemberList.searchOwlMemberList(Convert.ToInt32(txtTargetID.Text), out isFound);
              if (isFound)
              {
                  OwlMember p = thisOwlMemberList.getAnItem(member2);

                  if (MessageBox.Show("Are you sure you want to Save update", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                  {
                      if (p.GetType() == typeof(UndergraduateStudent))
                      {
                          if (Validators.ValidateUndergraduateStudent(this))
                          {
                              string tt = txtUndergraduateStudentTuition.Text;
                              string cc = txtUndergraduateStudentCredits.Text;
                              string gg = txtStudentGPA.Text;

                              int c = Convert.ToInt16(cc);
                              decimal t = Convert.ToDecimal(tt);
                              decimal g = Convert.ToDecimal(gg);

                              this.SuspendLayout();

                              txtUndergraduateStudentCredits.Text = c.ToString();
                              txtUndergraduateStudentTuition.Text = t.ToString("N");
                              txtStudentGPA.Text = g.ToString("N");
                              this.ResumeLayout();
                              p.Save(this);
                              thisOwlMemberList.displayMembers();
                              SFManager.writeToFile(thisOwlMemberList, FileName);
                              FormController.clear(this);
                              txtTargetID.Text = "";
                              FormController.clear(this);
                              FormController.activateAddButtons(this);
                          }
                      }
                      else if (p.GetType() == typeof(GraduateStudent))
                      {
                          if (Validators.ValidateGraduateStudent(this))
                          {
                              string ss = txtGraduateStudentStipend.Text;
                              decimal s = Convert.ToDecimal(ss);
                              this.SuspendLayout();
                              txtGraduateStudentStipend.Text = s.ToString("N");
                              this.ResumeLayout();
                              p.Save(this);
                              thisOwlMemberList.displayMembers();
                              SFManager.writeToFile(thisOwlMemberList, FileName);
                              FormController.clear(this);
                              txtTargetID.Text = "";
                              FormController.clear(this);
                              FormController.activateAddButtons(this);

                          }
                      }

                      else if (p.GetType() == typeof(FacultyMember))
                      {
                          if (Validators.ValidateFaculty(this))
                          {
                              p.Save(this);
                              thisOwlMemberList.displayMembers();
                              SFManager.writeToFile(thisOwlMemberList, FileName);
                              FormController.clear(this);
                              txtTargetID.Text = "";
                              FormController.clear(this);
                              FormController.activateAddButtons(this);

                          }
                      }
                      else if (p.GetType() == typeof(FacultyChairPerson))
                      {
                          if (Validators.ValidateFacultyChairPerson(this))
                          {
                              p.Save(this);
                              thisOwlMemberList.displayMembers();
                              SFManager.writeToFile(thisOwlMemberList, FileName);
                              FormController.clear(this);
                              txtTargetID.Text = "";
                              FormController.clear(this);
                              FormController.activateAddButtons(this);
                          }
                      }
                      else
                      {
                          MessageBox.Show("Type unknown");

                      }
                  }
                  else
                  {
                      FormController.clear(this);
                      FormController.activateAddButtons(this);

                  }

                  }
              }*/



        void displayDbInformation(string type)
        {
            bool successFlag;

            if (myDataReader.HasRows == false)
            {
                MessageBox.Show("On OwlMember Select, null (no rows) returned. No match found.  Reenter ID",
                    "OwlMember SELECT Error", MessageBoxButtons.OK);
                this.Close();
                txtOwlMemberID.Text = "";
                txtOwlMemberID.Focus();
            }
            else
            {
                displayRelevantFormPart(type);
                //myDataReader.Read();
                txtOwlMemberID.Text = myDataReader["fldID"].ToString();
                txtOwlMemberName.Text = myDataReader["fldName"].ToString();
                dtpOwlMemberBirthDate.Text = ((DateTime)myDataReader["fldBirthDate"]).ToString("MM/dd/yyyy");
            }
            if (type == "Faculty")     // Process Faculty
                {
                    myDataReader = dbFunctions.SelectOwlMemberFromFaculty(Convert.ToInt32(txtTargetID.Text), out successFlag);
                    if (myDataReader.HasRows == false)
                    {
                        MessageBox.Show("On Faculty Select, no matching row found.  Reenter ID",
                            "Faculty SELECT Error", MessageBoxButtons.OK);
                        //this.Close();
                        //txtOwlMemberID.Text = "";
                        //txtOwlMemberID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Faculty record found and read.  ", "Faculty Record Found", MessageBoxButtons.OK);
                        displayRelevantFormPart(type);
                        myDataReader.Read();
                        txtFacultyDepartment.Text = myDataReader["fldDepartment"].ToString();
                        cbFacultyRank.Text = myDataReader["fldRank"].ToString();
                    }  // end else on myDataReader HasRows
                }  // end processing Faculty 

            else if (type == "Chairperson")     // Process Chairperson
                {
                    myDataReader = dbFunctions.SelectOwlMemberFromChairperson(Convert.ToInt32(txtTargetID.Text), out successFlag);
                    if (!myDataReader.HasRows == true)
                    {
                        MessageBox.Show("On Chairperson Select, no matching row found. Reenter ID",
                            "Chairperson SELECT Error", MessageBoxButtons.OK);
                        //this.Close();
                        //txtOwlMemberID.Text = "";
                        txtOwlMemberID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Chairperson record found and read.  ", "Chairperson Record Found", MessageBoxButtons.OK);
                        displayRelevantFormPart(type);
                        myDataReader.Read();
                        txtFacultyDepartment.Text = myDataReader["fldDepartment"].ToString();
                        cbFacultyRank.Text = myDataReader["fldRank"].ToString();
                        decimal stip = Convert.ToDecimal(myDataReader["fldStipend"].ToString());
                        txtChairPersonStipend.Text = stip.ToString("N");
                    }  // end else on myDataReader HasRows
                }  // end processing Chairperson 

            else if (type == "UndergraduateStudent")     // Process Undergrad
                {
                    myDataReader = dbFunctions.SelectOwlMemberFromUndergraduateStudent(Convert.ToInt32(txtTargetID.Text), out successFlag);
                    if (myDataReader.HasRows == false)
                    {
                        MessageBox.Show("On Undergraduate Select, no matching row found.  Reenter ID",
                            "Undergradaduate SELECT Error", MessageBoxButtons.OK);
                        //this.Close();
                       // txtOwlMemberID.Text = "";
                       // txtOwlMemberID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Undergraduate record found and read.  ", "Undergraduate Record Found", MessageBoxButtons.OK);
                        displayRelevantFormPart(type);
                        myDataReader.Read();
                        txtStudentMajor.Text = myDataReader["fldMajor"].ToString();
                        decimal gpa = Convert.ToDecimal(myDataReader["fldGPA"]);
                        txtStudentGPA.Text = gpa.ToString("N");
                        txtUndergraduateStudentTuition.Text = myDataReader["fldTuition"].ToString();
                        cbUndergraduateStudentYear.Text = myDataReader["fldYear"].ToString();
                        txtUndergraduateStudentCredits.Text = myDataReader["fldCredits"].ToString();
                    }  // end else on myDataReader HasRows
                }  // end Processing Undergraduate Student

                else if (type == "GraduateStudent")   /// Process GradStudent
	            {
                    
                    myDataReader = dbFunctions.SelectOwlMemberFromGraduateStudent(Convert.ToInt32(txtTargetID.Text), out successFlag);
             
                    if (myDataReader.HasRows == false)
                    {
                        MessageBox.Show("On Graduate Select, no matching row found.  Reenter ID",
                            "Gradaduate SELECT Error", MessageBoxButtons.OK);
                        //this.Close();
                       // txtOwlMemberID.Text = "";
                       // txtOwlMemberID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Graduate record found and read.  ", "Graduate Record Found", MessageBoxButtons.OK);
                        displayRelevantFormPart(type);
                        myDataReader.Read();
                        txtStudentMajor.Text = myDataReader["fldMajor"].ToString();
                        decimal gpa = Convert.ToDecimal(myDataReader["fldGPA"]);
                        txtStudentGPA.Text = gpa.ToString("N");
                        string stip =myDataReader["fldStipend"].ToString();
                        txtGraduateStudentStipend.Text = String.Format("{0:0.##}", stip);
                        cbGraduateStudentDegreeProgram.Text = myDataReader["fldDegreeProgram"].ToString();
                    }  // end else on myDataReader HasRows
                }  // end Processing Graduate Student
            }


        private void btnSaveEditUpdate_Click(object sender, EventArgs e)
        {
            {

                if (Validators.ValidateOwlMember(txtOwlMemberID.Text, txtOwlMemberName.Text, dtpOwlMemberBirthDate.Text))
                {
                    if (type == "UndergraduateStudent")
                    {
                        if (Validators.ValidateStudent(txtStudentMajor.Text, txtStudentGPA.Text) &&
                            Validators.ValidateUndergraduateStudent(txtUndergraduateStudentTuition.Text, cbUndergraduateStudentYear.Text,
                            txtUndergraduateStudentCredits.Text))
                        {
                            try
                            {
                                dbFunctions.UpdateOwlMember(Convert.ToInt32(txtOwlMemberID.Text), txtOwlMemberName.Text,
                                    Convert.ToDateTime(dtpOwlMemberBirthDate.Text));
                                dbFunctions.UpdateStudent(Convert.ToInt32(txtOwlMemberID.Text), txtStudentMajor.Text,
                                    Convert.ToDecimal(txtStudentGPA.Text));
                                dbFunctions.UpdateUndergraduateStudent(Convert.ToInt32(txtOwlMemberID.Text),
                                    Convert.ToDecimal(txtUndergraduateStudentTuition.Text),
                                             cbUndergraduateStudentYear.Text,
                                    Convert.ToInt32(txtUndergraduateStudentCredits.Text));
                                recordsProcessedCount++;
                            }
                            catch
                            {
                                MessageBox.Show("Update Undergraduate Failed. Conversion or DB Problem.  Program Terminated.",
                                             "Update Undergraduate Failed", MessageBoxButtons.OK);
                                this.Close();
                            }
                            MessageBox.Show("Undergrad Record Update is Complete", "Successful Undergrad Update",
                                         MessageBoxButtons.OK);

                            FormController.clear(this);
                        }

                    }
                    else if (type == "GraduateStudent")
                    {
                        if (Validators.ValidateStudent(txtStudentMajor.Text, txtStudentGPA.Text) &&
                               Validators.ValidateGraduateStudent(txtGraduateStudentStipend.Text, cbGraduateStudentDegreeProgram.Text))
                        {
                            try
                            {
                                dbFunctions.UpdateOwlMember(Convert.ToInt32(txtOwlMemberID.Text), txtOwlMemberName.Text,
                                    Convert.ToDateTime(dtpOwlMemberBirthDate.Text));
                                dbFunctions.UpdateStudent(Convert.ToInt32(txtOwlMemberID.Text), txtStudentMajor.Text,
                                    Convert.ToDecimal(txtStudentGPA.Text));
                                dbFunctions.UpdateGraduateStudent(Convert.ToInt32(txtOwlMemberID.Text),
                                    Convert.ToDecimal(txtGraduateStudentStipend.Text),
                                             cbGraduateStudentDegreeProgram.Text);
                                recordsProcessedCount++;
                            }
                            catch
                            {
                                MessageBox.Show("Update Graduate Failed. Conversion or DB Problem.  Program Terminated.",
                                             "Update Graduate Failed", MessageBoxButtons.OK);
                                this.Close();
                            }
                            MessageBox.Show("Graduate Record Update is Complete", "Successful Graduate Update",
                                         MessageBoxButtons.OK);

                            FormController.clear(this);
                        }
                    }
                    else if (type == "Faculty")
                    {
                        if (Validators.ValidateFaculty(txtFacultyDepartment.Text, cbFacultyRank.Text))
                        {
                            try
                            {
                                dbFunctions.UpdateOwlMember(Convert.ToInt32(txtOwlMemberID.Text), txtOwlMemberName.Text,
                                    Convert.ToDateTime(dtpOwlMemberBirthDate.Text));
                                dbFunctions.UpdateFaculty(Convert.ToInt32(txtOwlMemberID.Text), txtFacultyDepartment.Text,
                                    cbFacultyRank.Text);
                                recordsProcessedCount++;
                            }
                            catch
                            {
                                MessageBox.Show("Update Faculty Failed. Conversion or DB Problem.  Program Terminated.",
                                             "Update Faculty Failed", MessageBoxButtons.OK);
                                this.Close();
                            }
                            MessageBox.Show("Faculty Record Update is Complete", "Successful Faculty Update",
                                         MessageBoxButtons.OK);

                            FormController.clear(this);
                        }
                    }
                    else if (type == "Chairperson")
                    {
                        if (Validators.ValidateFaculty(txtFacultyDepartment.Text, cbFacultyRank.Text) &&
                           (Convert.ToDecimal(txtChairPersonStipend.Text) > 0))
                        {

                            try
                            {
                                dbFunctions.UpdateOwlMember(Convert.ToInt32(txtOwlMemberID.Text), txtOwlMemberName.Text,
                                    Convert.ToDateTime(dtpOwlMemberBirthDate.Text));
                                dbFunctions.UpdateFaculty(Convert.ToInt32(txtOwlMemberID.Text), txtFacultyDepartment.Text,
                                    cbFacultyRank.Text);
                                dbFunctions.UpdateChairperson(Convert.ToInt32(txtOwlMemberID.Text),
                                    Convert.ToDecimal(txtChairPersonStipend.Text));
                                recordsProcessedCount++;
                            }
                            catch
                            {
                                MessageBox.Show("Update Chairperson Failed. Conversion or DB Problem.  Program Terminated.",
                                             "Update Chairperson Failed", MessageBoxButtons.OK);
                                this.Close();
                            }
                            MessageBox.Show("Chairperson Record Update is Complete", "Successful Chairperson Update",
                                         MessageBoxButtons.OK);

                            FormController.clear(this);
                        }
                    }
                }
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool success;
            btnFind.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            success = findAnItem("Edit/Update");
            if (success)
            {
                btnSaveEditUpdate.Enabled = true;
                btnEdit.Enabled = true;

                if (myDataReader.HasRows == false)
                {
                    MessageBox.Show("OlwMemeber with ID: " + txtOwlMemberID.Text + " was not found. Please try again.", "Invalid Person ID");
                    txtOwlMemberID.Enabled = true;
                    txtOwlMemberID.Focus();
                }
                else
                {
                    txtOwlMemberID.Enabled = false;
                    txtOwlMemberID.Text = myDataReader["fldID"].ToString();
                    txtOwlMemberName.Text = myDataReader["fldName"].ToString();
                    dtpOwlMemberBirthDate.Text = Convert.ToDateTime(myDataReader["fldBirthDate"]).ToString("MM/dd/yyyy");


                    MessageBox.Show("Edit/UPDATE current Owl (as shown). Press Save Updates Button", "Edit/Update Notice",
                               MessageBoxButtons.OK);

                    if (type == "UndergraduateStudent")
                    {
                        FormController.activateUndergraduateStudent(this);
                        FormController.deactivateFaculty(this);
                        FormController.deactivateGraduateStudent(this);
                        FormController.deactivateChairperson(this);
                        FormController.deactivateAddButtons(this);

                        txtStudentMajor.Text = myDataReader["fldMajor"].ToString();
                        txtStudentGPA.Text = myDataReader["fldGPA"].ToString();
                        txtUndergraduateStudentTuition.Text = myDataReader["fldTuition"].ToString();
                        cbUndergraduateStudentYear.Text = myDataReader["fldYear"].ToString();
                        txtUndergraduateStudentCredits.Text = myDataReader["fldCredits"].ToString();
                    }
                    else if (type == "GraduateStudent")
                    {
                        FormController.activateGraduateStudent(this);
                        FormController.deactivateFaculty(this);
                        FormController.deactivateUndergraduateStudent(this);
                        FormController.deactivateChairperson(this);
                        FormController.deactivateAddButtons(this);
                        txtStudentMajor.Text = myDataReader["fldMajor"].ToString();
                        txtStudentGPA.Text = myDataReader["fldGPA"].ToString();
                        cbGraduateStudentDegreeProgram.Text = myDataReader["fldDegreeProgram"].ToString();
                        txtGraduateStudentStipend.Text = myDataReader["fldStipend"].ToString();
                    }
                    else if (type == "Faculty")
                    {
                        FormController.deactivateGraduateStudent(this);
                        FormController.activateFaculty(this);
                        FormController.deactivateUndergraduateStudent(this);
                        FormController.deactivateChairperson(this);
                        FormController.deactivateAddButtons(this);
                        txtFacultyDepartment.Text = myDataReader["fldDepartment"].ToString();
                        cbFacultyRank.Text = myDataReader["fldRank"].ToString();
                    }
                    else if (type == "Chairperson")
                    {
                        FormController.deactivateGraduateStudent(this);
                        FormController.activateFaculty(this);
                        FormController.deactivateUndergraduateStudent(this);
                        FormController.activateChairperson(this);
                        FormController.deactivateAddButtons(this);
                        cbFacultyRank.Text = myDataReader["fldRank"].ToString();
                        txtFacultyDepartment.Text = myDataReader["fldDepartment"].ToString();
                        txtChairPersonStipend.Text = myDataReader["fldStipend"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error in edit mode");
                    }

                }
            }
        }
    }


}

                  