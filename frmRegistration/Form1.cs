using System.Collections;
using System;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frmRegistration
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
            String SetFileName = txtStudentNo.Text;

            String[] StudentData = {
                "Student Number: " + txtStudentNo.Text,
                "Program: " + cbProgram.Text,
                "Full Name: " + txtFirstName.Text + " " + txtMiddleName.Text + ". " + txtLastName.Text,
                "Age: " + txtAge.Text,
                "Gender: " + txtGender.Text,
                "Contact Number: " + txtContact.Text,
                "Birthday: " + txtDate.Value.ToString("yyyy-MM-dd")
            };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, SetFileName + ".txt")))
            {
                foreach (String Data in StudentData)
                {
                    outputFile.WriteLine(Data);
                }
            }
        }
    }
}
