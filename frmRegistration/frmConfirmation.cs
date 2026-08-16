using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static frmRegistration.frmRegistration;

namespace frmRegistration
{
    public partial class frmConfirmation : Form
    {

        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public frmConfirmation()
        {
            InitializeComponent();

            DelProgram = frmRegistration.StudentinfoClass.getProgram;
            DelLastName = frmRegistration.StudentinfoClass.getLastName;
            DelFirstName = frmRegistration.StudentinfoClass.getFirstName;
            DelMiddleName = frmRegistration.StudentinfoClass.getMiddleName;
            DelAddress = frmRegistration.StudentinfoClass.getAddress;

            DelNumAge = frmRegistration.StudentinfoClass.getAge;
            DelNumContactNo = frmRegistration.StudentinfoClass.getContactNo;
            DelStudNo = frmRegistration.StudentinfoClass.getStudentNo;
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = DelStudNo().ToString();
            lblProgram.Text = DelProgram();
            lblLastName.Text = DelLastName();
            lblFirstName.Text = DelFirstName();
            lblMiddleName.Text = DelMiddleName();
            lblAge.Text = DelNumAge().ToString();
            lblContactNo.Text = DelNumContactNo().ToString();
            lblAddress.Text = DelAddress();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }
    }
}
