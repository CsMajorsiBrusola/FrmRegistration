using System.Collections;
using System;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmRegistration
{
    public partial class frmRegistration : Form
    {
        public static string SetFileName;

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList course = new ArrayList();
            course.Add("Bachelor of Science in Information Technology");
            course.Add("Bachelor of Science in Computer Science");
            course.Add("Bachelor of Science in Computer Engineering");
            course.Add("Bachelor of Science in Accountancy");
            course.Add("Bachelor of Science in Management Accounting");
            course.Add("Bachelor of Science in Hospitality Management");
            course.Add("Bachelor of Science in Tourism Management");
            course.Add("Bachelor of Multimedia Arts");
            course.Add("Bachelor of Arts in Communication");
            course.Add("Bachelor of Arts in Psychology");
            course.Add("Bachelor of Science in Criminology");

            foreach (string prog in course)
            {
                cbProgram.Items.Add(prog);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SetFileName = txtStudentNo.Text;

            String[] StudentData = {
                "Student Number: " + txtStudentNo.Text,
                "Program: " + cbProgram.Text,
                "Full Name: " + txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text,
                "Age: " + txtAge.Text,
                "Gender: " + txtGender.Text,
                "Contact Number: " + txtContact.Text,
                "Birthday: " + txtDate.Value.ToString("yyyy-MM-dd")
            };

            string docPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "StudentRecords");

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, SetFileName + ".txt")))
            {
                foreach (String Data in StudentData)
                {
                    outputFile.WriteLine(Data);
                }
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.Show();
        }
    }
}
