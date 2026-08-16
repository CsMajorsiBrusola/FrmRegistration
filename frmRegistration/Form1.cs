using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frmRegistration
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
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
                cbProgram.Items.Add(prog);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentinfoClass.StudentNo = ParseLong(txtStudentNo.Text);
            StudentinfoClass.Program = cbProgram.Text;
            StudentinfoClass.LastName = txtLastName.Text;
            StudentinfoClass.FirstName = txtFirstName.Text;
            StudentinfoClass.MiddleName = txtMiddleName.Text;
            StudentinfoClass.Age = ParseLong(txtAge.Text);
            StudentinfoClass.ContactNo = txtContactNo.Text;
            StudentinfoClass.Address = txtAddress.Text;

            using (frmConfirmation frmConfirm = new frmConfirmation())
            {
                DialogResult result = frmConfirm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ResetControls();
                }
            }
        }

        private long ParseLong(string text)
        {
            return long.TryParse(text, out long value) ? value : 0;
        }

        private void ResetControls()
        {
            txtStudentNo.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtContactNo.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            cbProgram.SelectedIndex = -1;
        }

        public delegate long DelegateNumber();
        public delegate string DelegateText();

        public class StudentinfoClass
        {
            public static string FirstName { get; set; } = string.Empty;
            public static string LastName { get; set; } = string.Empty;
            public static string MiddleName { get; set; } = string.Empty;
            public static string Address { get; set; } = string.Empty;
            public static string Program { get; set; } = string.Empty;
            public static long Age { get; set; } = 0;
            public static string ContactNo { get; set; } = string.Empty;
            public static long StudentNo { get; set; } = 0;

            public static string getFirstName() => FirstName;
            public static string getLastName() => LastName;
            public static string getMiddleName() => MiddleName;
            public static string getAddress() => Address;
            public static string getProgram() => Program;
            public static long getAge() => Age;
            public static string getContactNo() => ContactNo;
            public static long getStudentNo() => StudentNo;
        }

        private void LastName_Click(object sender, EventArgs e)
        {

        }
    }
}
