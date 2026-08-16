namespace frmRegistration
{
    partial class frmConfirmation
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

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblAddress = new Label();
            lblContactNo = new Label();
            lblAge = new Label();
            lblMiddleName = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblProgram = new Label();
            lblStudentNo = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 40);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Student No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 70);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 99);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 128);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 156);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 184);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 213);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 6;
            label7.Text = "Contact No:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 246);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 7;
            label8.Text = "Address:";
            label8.Click += this.label8_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(179, 246);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(16, 15);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "H";
            lblAddress.Click += this.lblAddress_Click;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(179, 213);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(15, 15);
            lblContactNo.TabIndex = 14;
            lblContactNo.Text = "G";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(179, 184);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(13, 15);
            lblAge.TabIndex = 13;
            lblAge.Text = "F";
            lblAge.Click += lblAge_Click;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(179, 156);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(13, 15);
            lblMiddleName.TabIndex = 12;
            lblMiddleName.Text = "E";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(179, 128);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(15, 15);
            lblFirstName.TabIndex = 11;
            lblFirstName.Text = "D";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(179, 99);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(15, 15);
            lblLastName.TabIndex = 10;
            lblLastName.Text = "C";
            lblLastName.Click += this.lblLastName_Click;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(179, 70);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(14, 15);
            lblProgram.TabIndex = 9;
            lblProgram.Text = "B";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(179, 40);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(15, 15);
            lblStudentNo.TabIndex = 8;
            lblStudentNo.Text = "A";
            // 
            // button1
            // 
            button1.Location = new Point(157, 311);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 16;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 368);
            Controls.Add(button1);
            Controls.Add(lblAddress);
            Controls.Add(lblContactNo);
            Controls.Add(lblAge);
            Controls.Add(lblMiddleName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblProgram);
            Controls.Add(lblStudentNo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmConfirmation";
            Text = "frmConfirmation";
            Load += frmConfirmation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblAddress;
        private Label lblContactNo;
        private Label lblAge;
        private Label lblMiddleName;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblProgram;
        private Label lblStudentNo;
        private Button button1;
    }
}