
namespace AccessControlServer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Users = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.textBox_logging = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_COM_Port = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_COM_Port)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Users
            // 
            this.button_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Users.Location = new System.Drawing.Point(241, 28);
            this.button_Users.Name = "button_Users";
            this.button_Users.Size = new System.Drawing.Size(119, 23);
            this.button_Users.TabIndex = 0;
            this.button_Users.Text = "Пользователи";
            this.button_Users.UseVisualStyleBackColor = true;
            this.button_Users.Click += new System.EventHandler(this.button_Users_Click);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.Location = new System.Drawing.Point(424, 29);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(103, 23);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Запуск";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // textBox_logging
            // 
            this.textBox_logging.Location = new System.Drawing.Point(12, 76);
            this.textBox_logging.Multiline = true;
            this.textBox_logging.Name = "textBox_logging";
            this.textBox_logging.Size = new System.Drawing.Size(532, 362);
            this.textBox_logging.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "RS 485        COM";
            // 
            // numericUpDown_COM_Port
            // 
            this.numericUpDown_COM_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_COM_Port.Location = new System.Drawing.Point(147, 28);
            this.numericUpDown_COM_Port.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown_COM_Port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_COM_Port.Name = "numericUpDown_COM_Port";
            this.numericUpDown_COM_Port.Size = new System.Drawing.Size(54, 22);
            this.numericUpDown_COM_Port.TabIndex = 4;
            this.numericUpDown_COM_Port.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.numericUpDown_COM_Port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_logging);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Users);
            this.Name = "MainForm";
            this.Text = "Аccess control server";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_COM_Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Users;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.TextBox textBox_logging;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_COM_Port;
        private System.Windows.Forms.Timer timer1;
    }
}

