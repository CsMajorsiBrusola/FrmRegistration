using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmRegistration
{
    public partial class FrmStudentRecord : Form
    {
        private string path;

        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\Users\CompLab209-PC1\Documents\StudentRecords";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowRecord.Items.Add(_getText);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("File has been sucessfully uploaded", "Upload Successful", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                lvShowRecord.Items.Clear();
            }
        }
    }
}
