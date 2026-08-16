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
            ContactNo = new Label();
            Address = new Label();
            cbProgram = new ComboBox();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            txtContactNo = new TextBox();
            txtAddress = new RichTextBox();
            button1 = new Button();
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
            LastName.Click += LastName_Click;
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
            // ContactNo
            // 
            ContactNo.AutoSize = true;
            ContactNo.Location = new Point(249, 147);
            ContactNo.Name = "ContactNo";
            ContactNo.Size = new Size(71, 15);
            ContactNo.TabIndex = 6;
            ContactNo.Text = "Contact No.";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(56, 209);
            Address.Name = "Address";
            Address.Size = new Size(49, 15);
            Address.TabIndex = 7;
            Address.Text = "Address";
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
            txtMiddleName.Size = new Size(161, 23);
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
            // txtContactNo
            // 
            txtContactNo.BorderStyle = BorderStyle.FixedSingle;
            txtContactNo.Location = new Point(249, 165);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(161, 23);
            txtContactNo.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(56, 227);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(544, 96);
            txtAddress.TabIndex = 15;
            txtAddress.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(250, 347);
            button1.Name = "button1";
            button1.Size = new Size(160, 23);
            button1.TabIndex = 16;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 407);
            Controls.Add(button1);
            Controls.Add(txtAddress);
            Controls.Add(txtContactNo);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(cbProgram);
            Controls.Add(Address);
            Controls.Add(ContactNo);
            Controls.Add(Age);
            Controls.Add(MiddleName);
            Controls.Add(FirstName);
            Controls.Add(LastName);
            Controls.Add(Program);
            Controls.Add(StudentNo);
            Name = "frmRegistration";
            Text = "frmConfirmation";
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
        private Label ContactNo;
        private Label Address;
        private ComboBox cbProgram;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtAge;
        private TextBox txtContactNo;
        private RichTextBox txtAddress;
        private Button button1;
    }
}
