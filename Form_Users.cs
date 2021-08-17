using System;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace AccessControlServer
{
    public partial class Form_Users : Form
    {
        public Form_Users()
        {
            InitializeComponent();
            string[] list_of_users = File.ReadAllLines(@"_users.txt", Encoding.GetEncoding(1251)); 
            foreach (string string_list_of_users in list_of_users)
            {
                testBoxRegistered_users.Text= testBoxRegistered_users.Text + string_list_of_users + "\r\n"; 
            }
        }


        private void Form_Users_FormClosed(object sender, FormClosedEventArgs e) 
        {
            Form form_main = Application.OpenForms[0];
            form_main.Show();
        }

        private void button_Cansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_AddNewUser_Click(object sender, EventArgs e)
        {
            FileStream FileStreamUsers = new FileStream("_users.txt", FileMode.Append, FileAccess.Write);
            StreamWriter StreamWriterfileUsers = new StreamWriter(FileStreamUsers, Encoding.GetEncoding(1251));
            testBoxRegistered_users.Text = testBoxRegistered_users.Text + textBoxNewUser.Text;
            StreamWriterfileUsers.WriteLine(textBoxNewUser.Text);
            StreamWriterfileUsers.Close();
        }
    }
}
