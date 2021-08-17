
namespace AccessControlServer
{
    partial class Form_Users
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
            this.button_AddNewUser = new System.Windows.Forms.Button();
            this.textBoxNewUser = new System.Windows.Forms.TextBox();
            this.testBoxRegistered_users = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cansel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_AddNewUser
            // 
            this.button_AddNewUser.Location = new System.Drawing.Point(494, 74);
            this.button_AddNewUser.Name = "button_AddNewUser";
            this.button_AddNewUser.Size = new System.Drawing.Size(75, 23);
            this.button_AddNewUser.TabIndex = 0;
            this.button_AddNewUser.Text = "Добавить";
            this.button_AddNewUser.UseVisualStyleBackColor = true;
            this.button_AddNewUser.Click += new System.EventHandler(this.button_AddNewUser_Click);
            // 
            // textBoxNewUser
            // 
            this.textBoxNewUser.Location = new System.Drawing.Point(43, 76);
            this.textBoxNewUser.Name = "textBoxNewUser";
            this.textBoxNewUser.Size = new System.Drawing.Size(421, 20);
            this.textBoxNewUser.TabIndex = 1;
            // 
            // testBoxRegistered_users
            // 
            this.testBoxRegistered_users.Location = new System.Drawing.Point(43, 127);
            this.testBoxRegistered_users.Multiline = true;
            this.testBoxRegistered_users.Name = "testBoxRegistered_users";
            this.testBoxRegistered_users.Size = new System.Drawing.Size(421, 179);
            this.testBoxRegistered_users.TabIndex = 3;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(494, 127);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cansel
            // 
            this.button_Cansel.Location = new System.Drawing.Point(494, 184);
            this.button_Cansel.Name = "button_Cansel";
            this.button_Cansel.Size = new System.Drawing.Size(75, 24);
            this.button_Cansel.TabIndex = 5;
            this.button_Cansel.Text = "Отмена";
            this.button_Cansel.UseVisualStyleBackColor = true;
            this.button_Cansel.Click += new System.EventHandler(this.button_Cansel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Устройство,    Код,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Зарегистрированые пользователи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Для регистрации нового пользователя запустить сервер, приложить идентификатор к с" +
    "читывателю,";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ввести № устройства, код идентификатора (из лога) ФИО, нажать добавить";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Формат ввода данных NNN,KKKKKKKKKKKKKKKKKKKKKKKKK,Фамилия И.О.";
            // 
            // Form_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 335);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cansel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.testBoxRegistered_users);
            this.Controls.Add(this.textBoxNewUser);
            this.Controls.Add(this.button_AddNewUser);
            this.Name = "Form_Users";
            this.Text = "Пользователи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Users_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddNewUser;
        private System.Windows.Forms.TextBox textBoxNewUser;
        private System.Windows.Forms.TextBox testBoxRegistered_users;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cansel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}