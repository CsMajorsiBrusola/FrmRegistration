using System.Collections;
using static FrmRegistration.Form1;

namespace FrmRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList course = new ArrayList();
            course.Add("Bachelor of Science in Computer Science");
            course.Add("Bachelor of Science in Computer Engineering");
            course.Add("Bachelor of Science in Information Technology");
            course.Add("Bachelor of Science in Information Systems");

            foreach (string prog in course)
            {
                comboBox1.Items.Add(prog);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String studentNumber = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String LastName = textBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            String FirstName = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            String MiddleName = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            String Age = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            String ContactNumber = textBox7.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            String Address = richTextBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentinfoClass.StudentNo = ParseLong(txtStudentNo.Text);
            StudentinfoClass.Program = cbProgram.Text;
            StudentinfoClass.LastName = txtLastName.Text;
            StudentinfoClass.FirstName = txtFirstName.Text;
            StudentinfoClass.MiddleName = txtMiddleName.Text;
            StudentinfoClass.Age = ParseLong(txtAge.Text);
            StudentinfoClass.ContactNo = ParseLong(txtContactNo.Text);
            StudentinfoClass.Address = txtAddress.Text;

            using (FrmConfirm frmConfirm = new FrmConfirm())
            {
                DialogResult result = frmConfirm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ResetControls();
                }
            }
        }

        private void ResetControls()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            richTextBox1.Clear();
            comboBox1.SelectedIndex = -1;
        }

        public delegate long DelegateNumber(long number);


        public delegate string DelegateText(string txt);

        public class StudentinfoClass
        {
            static string FirstName = string.Empty;
            static string LastName = string.Empty;
            static string MiddleName = string.Empty;
            static string Address = string.Empty;
            static string Program = string.Empty;
            static long Age = 0;
            static long ContactNo = 0;
            static long StudentNo = 0;

            public static string getFirstName() => FirstName;
            public static string getLastName() => LastName;
            public static string getMiddleName() => MiddleName;
            public static string getAddress() => Address;
            public  string getProgram() => Program;
            public static long getAge() => Age;
            public static long getContactNo() => ContactNo;
            public static long getStudentNo() => StudentNo;

        }

    }
}

