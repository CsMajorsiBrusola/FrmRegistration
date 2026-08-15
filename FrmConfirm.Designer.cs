namespace FrmRegistration
{
    partial class FrmConfirm
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
            lblStudentNo = new Label();
            lblProgram = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblMiddleName = new Label();
            lblAge = new Label();
            lblContactNo = new Label();
            lblAddress = new Label();
            DelAddress = new Label();
            DelNumContactNo = new Label();
            DelNumAge = new Label();
            DelMiddleName = new Label();
            DelFirstName = new Label();
            DelLastName = new Label();
            DelProgram = new Label();
            DelStudNo = new Label();
            btSubmit = new Button();
            SuspendLayout();
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(64, 31);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(70, 15);
            lblStudentNo.TabIndex = 0;
            lblStudentNo.Text = "Student No.";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(64, 69);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(53, 15);
            lblProgram.TabIndex = 1;
            lblProgram.Text = "Program";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(64, 110);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(64, 152);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name ";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(64, 193);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(79, 15);
            lblMiddleName.TabIndex = 4;
            lblMiddleName.Text = "Middle Name";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(64, 234);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(64, 281);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(84, 15);
            lblContactNo.TabIndex = 6;
            lblContactNo.Text = "Contact Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(64, 324);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address";
            // 
            // DelAddress
            // 
            DelAddress.AutoSize = true;
            DelAddress.Location = new Point(205, 324);
            DelAddress.Name = "DelAddress";
            DelAddress.Size = new Size(38, 15);
            DelAddress.TabIndex = 15;
            DelAddress.Text = "label9";
            // 
            // DelNumContactNo
            // 
            DelNumContactNo.AutoSize = true;
            DelNumContactNo.Location = new Point(205, 281);
            DelNumContactNo.Name = "DelNumContactNo";
            DelNumContactNo.Size = new Size(44, 15);
            DelNumContactNo.TabIndex = 14;
            DelNumContactNo.Text = "label10";
            // 
            // DelNumAge
            // 
            DelNumAge.AutoSize = true;
            DelNumAge.Location = new Point(205, 234);
            DelNumAge.Name = "DelNumAge";
            DelNumAge.Size = new Size(44, 15);
            DelNumAge.TabIndex = 13;
            DelNumAge.Text = "label11";
            // 
            // DelMiddleName
            // 
            DelMiddleName.AutoSize = true;
            DelMiddleName.Location = new Point(205, 193);
            DelMiddleName.Name = "DelMiddleName";
            DelMiddleName.Size = new Size(44, 15);
            DelMiddleName.TabIndex = 12;
            DelMiddleName.Text = "label12";
            // 
            // DelFirstName
            // 
            DelFirstName.AutoSize = true;
            DelFirstName.Location = new Point(205, 152);
            DelFirstName.Name = "DelFirstName";
            DelFirstName.Size = new Size(44, 15);
            DelFirstName.TabIndex = 11;
            DelFirstName.Text = "label13";
            // 
            // DelLastName
            // 
            DelLastName.AutoSize = true;
            DelLastName.Location = new Point(205, 110);
            DelLastName.Name = "DelLastName";
            DelLastName.Size = new Size(44, 15);
            DelLastName.TabIndex = 10;
            DelLastName.Text = "label14";
            // 
            // DelProgram
            // 
            DelProgram.AutoSize = true;
            DelProgram.Location = new Point(205, 69);
            DelProgram.Name = "DelProgram";
            DelProgram.Size = new Size(44, 15);
            DelProgram.TabIndex = 9;
            DelProgram.Text = "label15";
            // 
            // DelStudNo
            // 
            DelStudNo.AutoSize = true;
            DelStudNo.Location = new Point(205, 31);
            DelStudNo.Name = "DelStudNo";
            DelStudNo.Size = new Size(44, 15);
            DelStudNo.TabIndex = 8;
            DelStudNo.Text = "label16";
            // 
            // btSubmit
            // 
            btSubmit.Location = new Point(205, 385);
            btSubmit.Name = "btSubmit";
            btSubmit.Size = new Size(75, 23);
            btSubmit.TabIndex = 16;
            btSubmit.Text = "Submit";
            btSubmit.UseVisualStyleBackColor = true;
            btSubmit.Click += btSubmit_Click;
            // 
            // FrmConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(btSubmit);
            Controls.Add(DelAddress);
            Controls.Add(DelNumContactNo);
            Controls.Add(DelNumAge);
            Controls.Add(DelMiddleName);
            Controls.Add(DelFirstName);
            Controls.Add(DelLastName);
            Controls.Add(DelProgram);
            Controls.Add(DelStudNo);
            Controls.Add(lblAddress);
            Controls.Add(lblContactNo);
            Controls.Add(lblAge);
            Controls.Add(lblMiddleName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblProgram);
            Controls.Add(lblStudentNo);
            Name = "FrmConfirm";
            Text = "FrmConfirm";
            Load += FrmConfirm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentNo;
        private Label lblProgram;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblMiddleName;
        private Label lblAge;
        private Label lblContactNo;
        private Label lblAddress;
        private Label DelAddress;
        private Label DelNumContactNo;
        private Label DelNumAge;
        private Label DelMiddleName;
        private Label DelFirstName;
        private Label DelLastName;
        private Label DelProgram;
        private Label DelStudNo;
        private Button btSubmit;
    }
}