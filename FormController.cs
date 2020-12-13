// Form Controller Class
// Responsible for all processing related to frmOwlCommunity


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace OwlCommunityMemberLanzaDrafts
{
    class FormController
    {
        private frmOwlCommunity f;

        // Parametrized Constructor

        public FormController(frmOwlCommunity parentForm)
        {
            f = parentForm;
        }  // end Parameterized Constructor

        public static void resetForm(frmOwlCommunity f)
        {
            //  Reset label or button components
            //f.lblOR.Visible = true;
            f.btnClear.Enabled = true;
            f.btnDelete.Enabled = false;
            f.btnEdit.Enabled = false;
            f.btnFind.Enabled = false;
            f.btnSaveEditUpdate.Enabled = false;
            f.btnEnterID.Enabled = true;
            f.btnCreateFaculty.Enabled = false;
            f.btnCreateFaculty.Text = "Create Faculty";
            f.btnCreateChairperson.Enabled = false;
            f.btnCreateChairperson.Text = "Create Chairperson";
            f.btnCreateGraduateStudent.Enabled = false;
            f.btnCreateGraduateStudent.Text = "Create Graduate Student";
            f.btnCreateUndergraduateStudent.Enabled = false;
            f.btnCreateUndergraduateStudent.Text = "Create Undergraduate";

            // Reset group components
            f.grpOwlMember.Enabled = true;
            f.grpOwlMember.BackColor = Color.Gainsboro;
            f.grpStudent.Enabled = false;
            f.grpStudent.BackColor = Color.Gainsboro;
            f.grpFaculty.Enabled = false;
            f.grpFaculty.BackColor = Color.Gainsboro;
            f.grpUndergraduateStudent.Enabled = false;
            f.grpUndergraduateStudent.BackColor = Color.Gainsboro;
            f.grpGraduateStudent.Enabled = false;
            f.grpGraduateStudent.BackColor = Color.Gainsboro;
            f.grpChairperson.BackColor = Color.Gainsboro;
            f.grpChairperson.Enabled = false;

            // Reset Text boxes
            f.txtOwlMemberID.Enabled = false;
            // f.txtOwlMemberID.Focus();
            f.txtOwlMemberName.Enabled = false;
            f.dtpOwlMemberBirthDate.Enabled = false;
            f.txtFacultyDepartment.Enabled = false;
            f.cbFacultyRank.Enabled = false;
            f.txtStudentMajor.Enabled = false;
            f.txtStudentMajor.Enabled = false;
            f.txtUndergraduateStudentTuition.Enabled = false;
            f.cbUndergraduateStudentYear.Enabled = false;
            f.txtUndergraduateStudentCredits.Enabled = false;
            f.cbGraduateStudentDegreeProgram.Enabled = false;
            f.txtGraduateStudentStipend.Enabled = false;
            f.txtFacultyDepartment.Enabled = false;
            f.cbFacultyRank.Enabled = false;
            f.txtChairPersonStipend.Enabled = false;
        } // end resetForm


        // Activates and deactivates necessary form buttons
        //    when in add mode
        public static void formAddMode(frmOwlCommunity f)
        {
            f.btnClear.Enabled = true;
            f.btnDelete.Enabled = false;
            f.btnEdit.Enabled = false;
            f.btnFind.Enabled = false;
        }  // end formAddMode


        // Enable/disable buttons when not in edit mode

        public static void activateAddButtons(frmOwlCommunity f)
        {
            f.btnCreateGraduateStudent.Enabled = true;
            f.btnCreateChairperson.Enabled = true;
            f.btnCreateUndergraduateStudent.Enabled = true;
            f.btnCreateFaculty.Enabled = true;
        }  // end activateAddButtons


        // Enable/disable buttons when not in edit mode
        public static void deactivateAddButtons(frmOwlCommunity f)
        {
            f.btnCreateGraduateStudent.Enabled = false;
            f.btnCreateChairperson.Enabled = false;
            f.btnCreateUndergraduateStudent.Enabled = false;
            f.btnCreateFaculty.Enabled = false;
        }  // end deactivateAddButtons


        //  Enables Employee textboxes and highlights the OwlMember groupbox
        public static void activateOwlMember(frmOwlCommunity f)
        {
            f.grpOwlMember.Enabled = true;
            f.grpOwlMember.BackColor = Color.LimeGreen;
            f.txtOwlMemberName.Enabled = true;
            f.dtpOwlMemberBirthDate.Enabled = true;
        }  // end activatePerson


        //  Enables Employee textboxes and highlights the Student groupbox
        public static void activateStudent(frmOwlCommunity f)
        {
            activateOwlMember(f);
            f.grpStudent.Enabled = true;
            f.grpStudent.BackColor = Color.LimeGreen;
            f.txtStudentMajor.Enabled = true;
            f.txtStudentGPA.Enabled = true;
        }  // end ActivateStudent


        // Enables Faculty textboxes and highlights the Faculty groupbox
        public static void activateFaculty(frmOwlCommunity f)
        {
            activateOwlMember(f);
            f.grpFaculty.Enabled = true;
            f.grpFaculty.BackColor = Color.LimeGreen;
            f.grpStudent.BackColor = Color.Red;
            f.txtFacultyDepartment.Enabled = true;
            f.cbFacultyRank.Enabled = true;
        }  // end activateFaculty


        // Enables Manager textboxes and highlights the Undergraduate groupbox
        public static void activateUndergraduateStudent(frmOwlCommunity f)
        {
            activateStudent(f);   // Employee must be activated too
            f.grpUndergraduateStudent.Enabled = true;
            f.grpUndergraduateStudent.BackColor = Color.LimeGreen;
            f.txtUndergraduateStudentTuition.Enabled = true;
            f.cbUndergraduateStudentYear.Enabled = true;
            f.txtUndergraduateStudentCredits.Enabled = true;
        }  // end activateManager


        // Enables Worker textboxes and highlights the Graduate Student groupbox
        public static void activateGraduateStudent(frmOwlCommunity f)
        {
            activateStudent(f);  // Employee must be activated too
            f.grpGraduateStudent.Enabled = true;
            f.grpGraduateStudent.BackColor = Color.LimeGreen;
            f.txtGraduateStudentStipend.Enabled = true;
            f.cbGraduateStudentDegreeProgram.Enabled = true;
        }  // end activateWorker


        // Enables Worker textboxes and highlights the Chairperson groupbox
        public static void activateChairperson(frmOwlCommunity f)
        {
            activateOwlMember(f);  // Employee must be activated too
            f.grpChairperson.Enabled = true;
            f.grpChairperson.BackColor = Color.LimeGreen;
            f.txtChairPersonStipend.Enabled = true;
        }  // end activateWorker

        // Disables OwlMember textboxes and highlights the OwlMember groupbox
        public static void deactivateOwlMember(frmOwlCommunity f)
        {
            deactivateStudent(f);
            deactivateFaculty(f);
            f.grpOwlMember.Enabled = false;
            f.grpOwlMember.BackColor = Color.Red;
        }  // end deactivatePerson


        // Disables Employee textboxes and highlights the Student groupbox
        public static void deactivateStudent(frmOwlCommunity f)
        {
            deactivateUndergraduateStudent(f);   // Must deactivate Manager too
            deactivateGraduateStudent(f);    // Must deactivate Worker too
            f.grpStudent.Enabled = false;
            f.grpStudent.BackColor = Color.Red;
        }  // end deactivateEmployee


        // Disables Client textboxes and highlights the Client groupbox
        public static void deactivateFaculty(frmOwlCommunity f)
        {
            f.grpFaculty.Enabled = false;
            f.grpFaculty.BackColor = Color.Red;
        }  // end deactivateClient


        // Disables Undergraduate Student textboxes and highlights the Manager groupbox
        public static void deactivateUndergraduateStudent(frmOwlCommunity f)
        {
            f.grpUndergraduateStudent.Enabled = false;
            f.grpUndergraduateStudent.BackColor = Color.Red;
        }  // end deactivateManager


        // Disables Graduate Student textboxes and highlights the Worker groupbox
        public static void deactivateGraduateStudent(frmOwlCommunity f)
        {
            f.grpGraduateStudent.Enabled = false;
            f.grpGraduateStudent.BackColor = Color.Red;
        }  // end deativateWorker


        // Disables Graduate Student textboxes and highlights the Worker groupbox
        public static void deactivateChairperson(frmOwlCommunity f)
        {
            f.grpChairperson.Enabled = false;
            f.grpChairperson.BackColor = Color.Red;
        }  // end deativateChairperson


        // Clear all textboxes on the form
        public static void clear(frmOwlCommunity f)
        {
            f.txtTargetID.Text = "";
            f.txtOwlMemberName.Text = "";
            f.dtpOwlMemberBirthDate.Text = "";
            f.txtOwlMemberID.Text = "";
            f.txtOwlMemberID.Focus();
            f.txtFacultyDepartment.Text = "";
            f.cbFacultyRank.Text = "";
            f.txtStudentMajor.Text = "";
            f.txtStudentGPA.Text = "";
            f.txtUndergraduateStudentTuition.Text = "";
            f.cbUndergraduateStudentYear.Text = "";
            f.txtUndergraduateStudentCredits.Text = "";
            f.txtGraduateStudentStipend.Text = "";
            f.cbGraduateStudentDegreeProgram.Text = "";
            f.txtChairPersonStipend.Text = "";
            resetForm(f);
        } // end Clear

    }  // end FormController class
}  // end namespace



    


