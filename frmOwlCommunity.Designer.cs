namespace OwlCommunityMemberLanzaDrafts
{
    partial class frmOwlCommunity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEdit = new System.Windows.Forms.Button();
            this.TitleLbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateUndergraduateStudent = new System.Windows.Forms.Button();
            this.btnCreateGraduateStudent = new System.Windows.Forms.Button();
            this.btnCreateFaculty = new System.Windows.Forms.Button();
            this.btnCreateChairperson = new System.Windows.Forms.Button();
            this.grpOwlMember = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpOwlMemberBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOwlMemberName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtOwlMemberID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpFaculty = new System.Windows.Forms.GroupBox();
            this.cbFacultyRank = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFacultyDepartment = new System.Windows.Forms.TextBox();
            this.grpChairperson = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChairPersonStipend = new System.Windows.Forms.TextBox();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudentMajor = new System.Windows.Forms.TextBox();
            this.txtStudentGPA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpUndergraduateStudent = new System.Windows.Forms.GroupBox();
            this.cbUndergraduateStudentYear = new System.Windows.Forms.ComboBox();
            this.lblStudentYear = new System.Windows.Forms.Label();
            this.lblStudentCredits = new System.Windows.Forms.Label();
            this.txtUndergraduateStudentCredits = new System.Windows.Forms.TextBox();
            this.lblTuition = new System.Windows.Forms.Label();
            this.txtUndergraduateStudentTuition = new System.Windows.Forms.TextBox();
            this.grpGraduateStudent = new System.Windows.Forms.GroupBox();
            this.cbGraduateStudentDegreeProgram = new System.Windows.Forms.ComboBox();
            this.lblGradProgram = new System.Windows.Forms.Label();
            this.txtGraduateStudentStipend = new System.Windows.Forms.TextBox();
            this.lblGradStipend = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpFormControls = new System.Windows.Forms.GroupBox();
            this.btnEnterID = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveEditUpdate = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblEnterID = new System.Windows.Forms.Label();
            this.txtTargetID = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.grpOwlMember.SuspendLayout();
            this.grpFaculty.SuspendLayout();
            this.grpChairperson.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.grpUndergraduateStudent.SuspendLayout();
            this.grpGraduateStudent.SuspendLayout();
            this.grpFormControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(178, 64);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TitleLbl1
            // 
            this.TitleLbl1.AutoSize = true;
            this.TitleLbl1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl1.Location = new System.Drawing.Point(11, 25);
            this.TitleLbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLbl1.Name = "TitleLbl1";
            this.TitleLbl1.Size = new System.Drawing.Size(234, 22);
            this.TitleLbl1.TabIndex = 2;
            this.TitleLbl1.Text = "Owl Community Data Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please select the action you wish to complete";
            // 
            // btnCreateUndergraduateStudent
            // 
            this.btnCreateUndergraduateStudent.Location = new System.Drawing.Point(18, 78);
            this.btnCreateUndergraduateStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateUndergraduateStudent.Name = "btnCreateUndergraduateStudent";
            this.btnCreateUndergraduateStudent.Size = new System.Drawing.Size(158, 23);
            this.btnCreateUndergraduateStudent.TabIndex = 4;
            this.btnCreateUndergraduateStudent.Text = "New Undergraduate Student";
            this.btnCreateUndergraduateStudent.UseVisualStyleBackColor = true;
            this.btnCreateUndergraduateStudent.Click += new System.EventHandler(this.btnCreateUndergraduateStudent_Click);
            // 
            // btnCreateGraduateStudent
            // 
            this.btnCreateGraduateStudent.Location = new System.Drawing.Point(196, 78);
            this.btnCreateGraduateStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateGraduateStudent.Name = "btnCreateGraduateStudent";
            this.btnCreateGraduateStudent.Size = new System.Drawing.Size(158, 23);
            this.btnCreateGraduateStudent.TabIndex = 5;
            this.btnCreateGraduateStudent.Text = "New Graduate Student";
            this.btnCreateGraduateStudent.UseVisualStyleBackColor = true;
            this.btnCreateGraduateStudent.Click += new System.EventHandler(this.btnCreateGraduateStudent_Click);
            // 
            // btnCreateFaculty
            // 
            this.btnCreateFaculty.Location = new System.Drawing.Point(371, 78);
            this.btnCreateFaculty.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateFaculty.Name = "btnCreateFaculty";
            this.btnCreateFaculty.Size = new System.Drawing.Size(158, 23);
            this.btnCreateFaculty.TabIndex = 6;
            this.btnCreateFaculty.Text = "New Faculty Member";
            this.btnCreateFaculty.UseVisualStyleBackColor = true;
            this.btnCreateFaculty.Click += new System.EventHandler(this.btnCreateFaculty_Click);
            // 
            // btnCreateChairperson
            // 
            this.btnCreateChairperson.Location = new System.Drawing.Point(547, 78);
            this.btnCreateChairperson.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateChairperson.Name = "btnCreateChairperson";
            this.btnCreateChairperson.Size = new System.Drawing.Size(158, 23);
            this.btnCreateChairperson.TabIndex = 7;
            this.btnCreateChairperson.Text = "New Chairperson";
            this.btnCreateChairperson.UseVisualStyleBackColor = true;
            this.btnCreateChairperson.Click += new System.EventHandler(this.btnCreateChairperson_Click);
            // 
            // grpOwlMember
            // 
            this.grpOwlMember.Controls.Add(this.label3);
            this.grpOwlMember.Controls.Add(this.dtpOwlMemberBirthDate);
            this.grpOwlMember.Controls.Add(this.label1);
            this.grpOwlMember.Controls.Add(this.txtOwlMemberName);
            this.grpOwlMember.Controls.Add(this.lblID);
            this.grpOwlMember.Controls.Add(this.txtOwlMemberID);
            this.grpOwlMember.Location = new System.Drawing.Point(18, 241);
            this.grpOwlMember.Margin = new System.Windows.Forms.Padding(2);
            this.grpOwlMember.Name = "grpOwlMember";
            this.grpOwlMember.Padding = new System.Windows.Forms.Padding(2);
            this.grpOwlMember.Size = new System.Drawing.Size(623, 65);
            this.grpOwlMember.TabIndex = 8;
            this.grpOwlMember.TabStop = false;
            this.grpOwlMember.Text = "Owl Member";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birthdate";
            // 
            // dtpOwlMemberBirthDate
            // 
            this.dtpOwlMemberBirthDate.CustomFormat = "dd-MM-yyyy";
            this.dtpOwlMemberBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOwlMemberBirthDate.Location = new System.Drawing.Point(452, 25);
            this.dtpOwlMemberBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpOwlMemberBirthDate.Name = "dtpOwlMemberBirthDate";
            this.dtpOwlMemberBirthDate.Size = new System.Drawing.Size(135, 20);
            this.dtpOwlMemberBirthDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // txtOwlMemberName
            // 
            this.txtOwlMemberName.Location = new System.Drawing.Point(237, 27);
            this.txtOwlMemberName.Margin = new System.Windows.Forms.Padding(2);
            this.txtOwlMemberName.Name = "txtOwlMemberName";
            this.txtOwlMemberName.Size = new System.Drawing.Size(128, 20);
            this.txtOwlMemberName.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(19, 29);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // txtOwlMemberID
            // 
            this.txtOwlMemberID.Location = new System.Drawing.Point(47, 27);
            this.txtOwlMemberID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOwlMemberID.Name = "txtOwlMemberID";
            this.txtOwlMemberID.Size = new System.Drawing.Size(128, 20);
            this.txtOwlMemberID.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(699, 173);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 42);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpFaculty
            // 
            this.grpFaculty.Controls.Add(this.cbFacultyRank);
            this.grpFaculty.Controls.Add(this.label5);
            this.grpFaculty.Controls.Add(this.label4);
            this.grpFaculty.Controls.Add(this.txtFacultyDepartment);
            this.grpFaculty.Location = new System.Drawing.Point(18, 310);
            this.grpFaculty.Margin = new System.Windows.Forms.Padding(2);
            this.grpFaculty.Name = "grpFaculty";
            this.grpFaculty.Padding = new System.Windows.Forms.Padding(2);
            this.grpFaculty.Size = new System.Drawing.Size(623, 72);
            this.grpFaculty.TabIndex = 9;
            this.grpFaculty.TabStop = false;
            this.grpFaculty.Text = "Faculty";
            // 
            // cbFacultyRank
            // 
            this.cbFacultyRank.FormattingEnabled = true;
            this.cbFacultyRank.Items.AddRange(new object[] {
            "Prof",
            "Lect",
            "Ast P",
            "Act P",
            "Inst"});
            this.cbFacultyRank.Location = new System.Drawing.Point(374, 30);
            this.cbFacultyRank.Margin = new System.Windows.Forms.Padding(2);
            this.cbFacultyRank.Name = "cbFacultyRank";
            this.cbFacultyRank.Size = new System.Drawing.Size(82, 21);
            this.cbFacultyRank.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department";
            // 
            // txtFacultyDepartment
            // 
            this.txtFacultyDepartment.Location = new System.Drawing.Point(156, 32);
            this.txtFacultyDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.txtFacultyDepartment.Name = "txtFacultyDepartment";
            this.txtFacultyDepartment.Size = new System.Drawing.Size(128, 20);
            this.txtFacultyDepartment.TabIndex = 6;
            // 
            // grpChairperson
            // 
            this.grpChairperson.Controls.Add(this.label6);
            this.grpChairperson.Controls.Add(this.txtChairPersonStipend);
            this.grpChairperson.Location = new System.Drawing.Point(18, 397);
            this.grpChairperson.Margin = new System.Windows.Forms.Padding(2);
            this.grpChairperson.Name = "grpChairperson";
            this.grpChairperson.Padding = new System.Windows.Forms.Padding(2);
            this.grpChairperson.Size = new System.Drawing.Size(623, 56);
            this.grpChairperson.TabIndex = 10;
            this.grpChairperson.TabStop = false;
            this.grpChairperson.Text = "Chair Person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Chairperson Stipend";
            // 
            // txtChairPersonStipend
            // 
            this.txtChairPersonStipend.Location = new System.Drawing.Point(275, 26);
            this.txtChairPersonStipend.Margin = new System.Windows.Forms.Padding(2);
            this.txtChairPersonStipend.Name = "txtChairPersonStipend";
            this.txtChairPersonStipend.Size = new System.Drawing.Size(128, 20);
            this.txtChairPersonStipend.TabIndex = 11;
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.label7);
            this.grpStudent.Controls.Add(this.txtStudentMajor);
            this.grpStudent.Controls.Add(this.txtStudentGPA);
            this.grpStudent.Controls.Add(this.label8);
            this.grpStudent.Location = new System.Drawing.Point(18, 473);
            this.grpStudent.Margin = new System.Windows.Forms.Padding(2);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Padding = new System.Windows.Forms.Padding(2);
            this.grpStudent.Size = new System.Drawing.Size(623, 60);
            this.grpStudent.TabIndex = 11;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "GPA";
            // 
            // txtStudentMajor
            // 
            this.txtStudentMajor.Location = new System.Drawing.Point(114, 25);
            this.txtStudentMajor.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentMajor.Name = "txtStudentMajor";
            this.txtStudentMajor.Size = new System.Drawing.Size(128, 20);
            this.txtStudentMajor.TabIndex = 6;
            // 
            // txtStudentGPA
            // 
            this.txtStudentGPA.Location = new System.Drawing.Point(365, 25);
            this.txtStudentGPA.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentGPA.Name = "txtStudentGPA";
            this.txtStudentGPA.Size = new System.Drawing.Size(113, 20);
            this.txtStudentGPA.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Major";
            // 
            // grpUndergraduateStudent
            // 
            this.grpUndergraduateStudent.Controls.Add(this.cbUndergraduateStudentYear);
            this.grpUndergraduateStudent.Controls.Add(this.lblStudentYear);
            this.grpUndergraduateStudent.Controls.Add(this.lblStudentCredits);
            this.grpUndergraduateStudent.Controls.Add(this.txtUndergraduateStudentCredits);
            this.grpUndergraduateStudent.Controls.Add(this.lblTuition);
            this.grpUndergraduateStudent.Controls.Add(this.txtUndergraduateStudentTuition);
            this.grpUndergraduateStudent.Location = new System.Drawing.Point(18, 560);
            this.grpUndergraduateStudent.Margin = new System.Windows.Forms.Padding(2);
            this.grpUndergraduateStudent.Name = "grpUndergraduateStudent";
            this.grpUndergraduateStudent.Padding = new System.Windows.Forms.Padding(2);
            this.grpUndergraduateStudent.Size = new System.Drawing.Size(297, 92);
            this.grpUndergraduateStudent.TabIndex = 12;
            this.grpUndergraduateStudent.TabStop = false;
            this.grpUndergraduateStudent.Text = "Undergraduate Student";
            // 
            // cbUndergraduateStudentYear
            // 
            this.cbUndergraduateStudentYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUndergraduateStudentYear.FormattingEnabled = true;
            this.cbUndergraduateStudentYear.Items.AddRange(new object[] {
            "Fr",
            "So",
            "Jr",
            "Sr"});
            this.cbUndergraduateStudentYear.Location = new System.Drawing.Point(85, 70);
            this.cbUndergraduateStudentYear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbUndergraduateStudentYear.Name = "cbUndergraduateStudentYear";
            this.cbUndergraduateStudentYear.Size = new System.Drawing.Size(100, 21);
            this.cbUndergraduateStudentYear.TabIndex = 20;
            // 
            // lblStudentYear
            // 
            this.lblStudentYear.AutoSize = true;
            this.lblStudentYear.Location = new System.Drawing.Point(37, 71);
            this.lblStudentYear.Name = "lblStudentYear";
            this.lblStudentYear.Size = new System.Drawing.Size(29, 13);
            this.lblStudentYear.TabIndex = 19;
            this.lblStudentYear.Text = "Year";
            // 
            // lblStudentCredits
            // 
            this.lblStudentCredits.AutoSize = true;
            this.lblStudentCredits.Location = new System.Drawing.Point(37, 47);
            this.lblStudentCredits.Name = "lblStudentCredits";
            this.lblStudentCredits.Size = new System.Drawing.Size(39, 13);
            this.lblStudentCredits.TabIndex = 18;
            this.lblStudentCredits.Text = "Credits";
            // 
            // txtUndergraduateStudentCredits
            // 
            this.txtUndergraduateStudentCredits.Location = new System.Drawing.Point(85, 44);
            this.txtUndergraduateStudentCredits.Name = "txtUndergraduateStudentCredits";
            this.txtUndergraduateStudentCredits.Size = new System.Drawing.Size(56, 20);
            this.txtUndergraduateStudentCredits.TabIndex = 17;
            this.txtUndergraduateStudentCredits.Tag = "";
            // 
            // lblTuition
            // 
            this.lblTuition.AutoSize = true;
            this.lblTuition.Location = new System.Drawing.Point(36, 21);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(39, 13);
            this.lblTuition.TabIndex = 16;
            this.lblTuition.Text = "Tuition";
            // 
            // txtUndergraduateStudentTuition
            // 
            this.txtUndergraduateStudentTuition.Location = new System.Drawing.Point(85, 18);
            this.txtUndergraduateStudentTuition.Name = "txtUndergraduateStudentTuition";
            this.txtUndergraduateStudentTuition.Size = new System.Drawing.Size(100, 20);
            this.txtUndergraduateStudentTuition.TabIndex = 15;
            this.txtUndergraduateStudentTuition.Tag = "";
            // 
            // grpGraduateStudent
            // 
            this.grpGraduateStudent.Controls.Add(this.cbGraduateStudentDegreeProgram);
            this.grpGraduateStudent.Controls.Add(this.lblGradProgram);
            this.grpGraduateStudent.Controls.Add(this.txtGraduateStudentStipend);
            this.grpGraduateStudent.Controls.Add(this.lblGradStipend);
            this.grpGraduateStudent.Location = new System.Drawing.Point(348, 560);
            this.grpGraduateStudent.Margin = new System.Windows.Forms.Padding(2);
            this.grpGraduateStudent.Name = "grpGraduateStudent";
            this.grpGraduateStudent.Padding = new System.Windows.Forms.Padding(2);
            this.grpGraduateStudent.Size = new System.Drawing.Size(293, 92);
            this.grpGraduateStudent.TabIndex = 13;
            this.grpGraduateStudent.TabStop = false;
            this.grpGraduateStudent.Text = "Graduate Student";
            // 
            // cbGraduateStudentDegreeProgram
            // 
            this.cbGraduateStudentDegreeProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraduateStudentDegreeProgram.FormattingEnabled = true;
            this.cbGraduateStudentDegreeProgram.Items.AddRange(new object[] {
            "Ph.D",
            "MA",
            "MS ",
            "MBA",
            "EMBA",
            "PhDBA",
            "MFA",
            "MEd",
            "MD",
            "BA"});
            this.cbGraduateStudentDegreeProgram.Location = new System.Drawing.Point(111, 46);
            this.cbGraduateStudentDegreeProgram.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbGraduateStudentDegreeProgram.Name = "cbGraduateStudentDegreeProgram";
            this.cbGraduateStudentDegreeProgram.Size = new System.Drawing.Size(103, 21);
            this.cbGraduateStudentDegreeProgram.TabIndex = 19;
            // 
            // lblGradProgram
            // 
            this.lblGradProgram.AutoSize = true;
            this.lblGradProgram.Location = new System.Drawing.Point(21, 47);
            this.lblGradProgram.Name = "lblGradProgram";
            this.lblGradProgram.Size = new System.Drawing.Size(84, 13);
            this.lblGradProgram.TabIndex = 21;
            this.lblGradProgram.Text = "Degree Program";
            // 
            // txtGraduateStudentStipend
            // 
            this.txtGraduateStudentStipend.Location = new System.Drawing.Point(111, 18);
            this.txtGraduateStudentStipend.Name = "txtGraduateStudentStipend";
            this.txtGraduateStudentStipend.Size = new System.Drawing.Size(103, 20);
            this.txtGraduateStudentStipend.TabIndex = 18;
            this.txtGraduateStudentStipend.Tag = "";
            // 
            // lblGradStipend
            // 
            this.lblGradStipend.AutoSize = true;
            this.lblGradStipend.Location = new System.Drawing.Point(20, 21);
            this.lblGradStipend.Name = "lblGradStipend";
            this.lblGradStipend.Size = new System.Drawing.Size(43, 13);
            this.lblGradStipend.TabIndex = 20;
            this.lblGradStipend.Text = "Stipend";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(709, 634);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 29);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpFormControls
            // 
            this.grpFormControls.Controls.Add(this.btnEnterID);
            this.grpFormControls.Controls.Add(this.btnDelete);
            this.grpFormControls.Controls.Add(this.btnSaveEditUpdate);
            this.grpFormControls.Controls.Add(this.btnFind);
            this.grpFormControls.Controls.Add(this.lblEnterID);
            this.grpFormControls.Controls.Add(this.txtTargetID);
            this.grpFormControls.Controls.Add(this.btnEdit);
            this.grpFormControls.Location = new System.Drawing.Point(18, 142);
            this.grpFormControls.Name = "grpFormControls";
            this.grpFormControls.Size = new System.Drawing.Size(623, 94);
            this.grpFormControls.TabIndex = 14;
            this.grpFormControls.TabStop = false;
            this.grpFormControls.Text = "Data Processing Controls";
            // 
            // btnEnterID
            // 
            this.btnEnterID.Location = new System.Drawing.Point(297, 24);
            this.btnEnterID.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnterID.Name = "btnEnterID";
            this.btnEnterID.Size = new System.Drawing.Size(96, 23);
            this.btnEnterID.TabIndex = 20;
            this.btnEnterID.Text = "Enter";
            this.btnEnterID.UseVisualStyleBackColor = true;
            this.btnEnterID.Click += new System.EventHandler(this.btnEnterID_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(331, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveEditUpdate
            // 
            this.btnSaveEditUpdate.Location = new System.Drawing.Point(469, 67);
            this.btnSaveEditUpdate.Name = "btnSaveEditUpdate";
            this.btnSaveEditUpdate.Size = new System.Drawing.Size(118, 23);
            this.btnSaveEditUpdate.TabIndex = 18;
            this.btnSaveEditUpdate.Text = "Save";
            this.btnSaveEditUpdate.UseVisualStyleBackColor = true;
            this.btnSaveEditUpdate.Click += new System.EventHandler(this.btnSaveEditUpdate_Click);
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(31, 64);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 23);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Find/Display";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Location = new System.Drawing.Point(30, 31);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(130, 13);
            this.lblEnterID.TabIndex = 15;
            this.lblEnterID.Text = "Please Enter Target TUID";
            // 
            // txtTargetID
            // 
            this.txtTargetID.Location = new System.Drawing.Point(170, 27);
            this.txtTargetID.Name = "txtTargetID";
            this.txtTargetID.Size = new System.Drawing.Size(100, 20);
            this.txtTargetID.TabIndex = 14;
            this.txtTargetID.Tag = "";
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Location = new System.Drawing.Point(15, 114);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(75, 13);
            this.lblUserMessage.TabIndex = 17;
            this.lblUserMessage.Text = "User Message";
            // 
            // frmOwlCommunity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpFormControls);
            this.Controls.Add(this.grpGraduateStudent);
            this.Controls.Add(this.grpUndergraduateStudent);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.grpChairperson);
            this.Controls.Add(this.grpFaculty);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpOwlMember);
            this.Controls.Add(this.btnCreateChairperson);
            this.Controls.Add(this.btnCreateFaculty);
            this.Controls.Add(this.btnCreateGraduateStudent);
            this.Controls.Add(this.btnCreateUndergraduateStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleLbl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOwlCommunity";
            this.Text = "Owl Community";
            this.Load += new System.EventHandler(this.frmOwlCommunity_Load);
            this.grpOwlMember.ResumeLayout(false);
            this.grpOwlMember.PerformLayout();
            this.grpFaculty.ResumeLayout(false);
            this.grpFaculty.PerformLayout();
            this.grpChairperson.ResumeLayout(false);
            this.grpChairperson.PerformLayout();
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.grpUndergraduateStudent.ResumeLayout(false);
            this.grpUndergraduateStudent.PerformLayout();
            this.grpGraduateStudent.ResumeLayout(false);
            this.grpGraduateStudent.PerformLayout();
            this.grpFormControls.ResumeLayout(false);
            this.grpFormControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Label TitleLbl1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnCreateUndergraduateStudent;
        internal System.Windows.Forms.Button btnCreateGraduateStudent;
        internal System.Windows.Forms.Button btnCreateFaculty;
        internal System.Windows.Forms.Button btnCreateChairperson;
        internal System.Windows.Forms.GroupBox grpOwlMember;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtOwlMemberName;
        internal System.Windows.Forms.Label lblID;
        internal System.Windows.Forms.TextBox txtOwlMemberID;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.GroupBox grpFaculty;
        internal System.Windows.Forms.GroupBox grpChairperson;
        internal System.Windows.Forms.GroupBox grpStudent;
        internal System.Windows.Forms.GroupBox grpUndergraduateStudent;
        internal System.Windows.Forms.DateTimePicker dtpOwlMemberBirthDate;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cbFacultyRank;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtFacultyDepartment;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtChairPersonStipend;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtStudentMajor;
        internal System.Windows.Forms.TextBox txtStudentGPA;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.GroupBox grpGraduateStudent;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.GroupBox grpFormControls;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSaveEditUpdate;
        internal System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.Label lblEnterID;
        internal System.Windows.Forms.TextBox txtTargetID;
        internal System.Windows.Forms.ComboBox cbUndergraduateStudentYear;
        internal System.Windows.Forms.Label lblStudentYear;
        internal System.Windows.Forms.Label lblStudentCredits;
        internal System.Windows.Forms.TextBox txtUndergraduateStudentCredits;
        internal System.Windows.Forms.Label lblTuition;
        internal System.Windows.Forms.TextBox txtUndergraduateStudentTuition;
        internal System.Windows.Forms.ComboBox cbGraduateStudentDegreeProgram;
        internal System.Windows.Forms.Label lblGradProgram;
        internal System.Windows.Forms.TextBox txtGraduateStudentStipend;
        internal System.Windows.Forms.Label lblGradStipend;
        internal System.Windows.Forms.Button btnEnterID;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblUserMessage;
    }
}

