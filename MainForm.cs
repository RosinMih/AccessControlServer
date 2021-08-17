using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;




namespace AccessControlServer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (File.Exists(@"_COM_Port.txt"))
            {
                string[] Port_from_file = File.ReadAllLines(@"_COM_Port.txt");
                numericUpDown_COM_Port.Value = Convert.ToInt32(Port_from_file[0]);
            }
            else
            {
                numericUpDown_COM_Port.Value = 1;
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"_users.txt"))
            {
                if (button_Start.BackColor != Color.Red)
                {
                    messaging Messaging = new messaging();
                    Messaging.management((int)numericUpDown_COM_Port.Value);
                    button_Start.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Нет зарегистрированных пользователей");
            }
        }

        private void button_Users_Click(object sender, EventArgs e)
        {
            Form_Users form_Users = new Form_Users();
            form_Users.Owner = this;
            form_Users.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (StringBuilder_To_loging.Length > 0)
            {
                textBox_logging.Text = textBox_logging.Text + StringBuilder_To_loging.ToString() + "\n\r";
                StringBuilder_To_loging.Clear();
            }
        }

        static public StringBuilder StringBuilder_To_loging = new StringBuilder(200);

    }
}
