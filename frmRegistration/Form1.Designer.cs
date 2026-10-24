namespace frmRegistration
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StudentNo = new Label();
            Program = new Label();
            LastName = new Label();
            FirstName = new Label();
            MiddleName = new Label();
            Age = new Label();
            Gender = new Label();
            Birthday = new Label();
            cbProgram = new ComboBox();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            Register = new Button();
            txtContact = new TextBox();
            label1 = new Label();
            txtDate = new DateTimePicker();
            txtGender = new ComboBox();
            SuspendLayout();
            // 
            // StudentNo
            // 
            StudentNo.AutoSize = true;
            StudentNo.Location = new Point(55, 40);
            StudentNo.Name = "StudentNo";
            StudentNo.Size = new Size(70, 15);
            StudentNo.TabIndex = 0;
            StudentNo.Text = "Student No.";
            // 
            // Program
            // 
            Program.AutoSize = true;
            Program.Location = new Point(249, 40);
            Program.Name = "Program";
            Program.Size = new Size(53, 15);
            Program.TabIndex = 1;
            Program.Text = "Program";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(55, 91);
            LastName.Name = "LastName";
            LastName.Size = new Size(63, 15);
            LastName.TabIndex = 2;
            LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(250, 91);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(64, 15);
            FirstName.TabIndex = 3;
            FirstName.Text = "First Name";
            // 
            // MiddleName
            // 
            MiddleName.AutoSize = true;
            MiddleName.Location = new Point(439, 91);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(79, 15);
            MiddleName.TabIndex = 4;
            MiddleName.Text = "Middle Name";
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(55, 147);
            Age.Name = "Age";
            Age.Size = new Size(28, 15);
            Age.TabIndex = 5;
            Age.Text = "Age";
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Location = new Point(249, 147);
            Gender.Name = "Gender";
            Gender.Size = new Size(45, 15);
            Gender.TabIndex = 6;
            Gender.Text = "Gender";
            // 
            // Birthday
            // 
            Birthday.AutoSize = true;
            Birthday.Location = new Point(55, 206);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(51, 15);
            Birthday.TabIndex = 7;
            Birthday.Text = "Birthday";
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(250, 58);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(268, 23);
            cbProgram.TabIndex = 8;
            // 
            // txtStudentNo
            // 
            txtStudentNo.BorderStyle = BorderStyle.FixedSingle;
            txtStudentNo.Location = new Point(55, 58);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(161, 23);
            txtStudentNo.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(56, 109);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(161, 23);
            txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(249, 109);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(161, 23);
            txtFirstName.TabIndex = 11;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.Location = new Point(439, 109);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(79, 23);
            txtMiddleName.TabIndex = 12;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(55, 165);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(161, 23);
            txtAge.TabIndex = 13;
            // 
            // Register
            // 
            Register.Location = new Point(203, 273);
            Register.Name = "Register";
            Register.Size = new Size(160, 38);
            Register.TabIndex = 16;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += button1_Click;
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Location = new Point(292, 224);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(226, 23);
            txtContact.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 206);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 17;
            label1.Text = "Contact No.";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(55, 224);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(189, 23);
            txtDate.TabIndex = 19;
            // 
            // txtGender
            // 
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            txtGender.Location = new Point(249, 165);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(269, 23);
            txtGender.TabIndex = 20;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 340);
            Controls.Add(txtGender);
            Controls.Add(txtDate);
            Controls.Add(txtContact);
            Controls.Add(label1);
            Controls.Add(Register);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(cbProgram);
            Controls.Add(Birthday);
            Controls.Add(Gender);
            Controls.Add(Age);
            Controls.Add(MiddleName);
            Controls.Add(FirstName);
            Controls.Add(LastName);
            Controls.Add(Program);
            Controls.Add(StudentNo);
            Name = "frmRegistration";
            Text = "FrmRegistration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentNo;
        private Label Program;
        private Label LastName;
        private Label FirstName;
        private Label MiddleName;
        private Label Age;
        private Label Gender;
        private Label Birthday;
        private ComboBox cbProgram;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtAge;
        private TextBox txtContactNo;
        private Button Register;
        private TextBox txtContact;
        private Label label1;
        private DateTimePicker txtDate;
        private ComboBox txtGender;
    }
}
