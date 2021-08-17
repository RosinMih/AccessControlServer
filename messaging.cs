using System;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading;


namespace AccessControlServer
{
    class messaging
    {
        public void management(int COM)
        {
            Counter counter = new Counter();
            counter.x = COM;

            Thread Thr_Lissen = new Thread(new ParameterizedThreadStart(Lissen_RS485));
            Thr_Lissen.Start(counter); 
            Thr_Lissen.IsBackground = true;
        }

        public void Lissen_RS485 (object obj)
        {

            Counter c = (Counter)obj;
            string message_in_RS485;
            bool flag_open;

            string[] users_from_file = File.ReadAllLines(@"_users.txt", Encoding.GetEncoding(1251));

            FileStream FileStream_users_from_file = new FileStream("_log.txt", FileMode.Append, FileAccess.Write);
            StreamWriter StreamWriter_logfile = new StreamWriter(FileStream_users_from_file, Encoding.GetEncoding(1251));

            SerialPort RS485_serialPort;
            RS485_serialPort = new SerialPort();
            RS485_serialPort.PortName = "COM"+c.x.ToString();
            RS485_serialPort.BaudRate = 9600;
            RS485_serialPort.DataBits = 8;
            RS485_serialPort.Parity = Parity.None;
            RS485_serialPort.StopBits = StopBits.Two;
            RS485_serialPort.ReadTimeout = 500;
            RS485_serialPort.WriteTimeout = 500;

            try
            {
                RS485_serialPort.Open();
                MainForm.StringBuilder_To_loging = MainForm.StringBuilder_To_loging.Append("Сервер систем управления контроля доступом запущен. Работа через RS485 на  COM" + c.x.ToString());

            }
            catch (Exception ex)
            {
                MainForm.StringBuilder_To_loging.Clear();
                MainForm.StringBuilder_To_loging.Append(ex.ToString());
                return;
            }

            while (true)   
            {
                flag_open = false; 
                if (RS485_serialPort.BytesToRead > 0) 
                {
                    message_in_RS485 = RS485_serialPort.ReadLine(); 
                    Thread.Sleep(100); 
                    foreach  (string possible_user in users_from_file) 
                    {
                        if (possible_user.Contains(message_in_RS485.Substring(0, message_in_RS485.Length - 1))) 
                        {
                            flag_open = true;  
                            RS485_serialPort.WriteLine(message_in_RS485.Substring(0, 4) + "open");    
                            StreamWriter_logfile.WriteLine(DateTime.Now + "," + possible_user + ",open");  
                            MainForm.StringBuilder_To_loging = MainForm.StringBuilder_To_loging.Append(DateTime.Now + "," + possible_user + ",open   \n\r");
                        }
                    }
                    if (!flag_open)    
                    {
                        StreamWriter_logfile.WriteLine(DateTime.Now + "," + message_in_RS485.Substring(0, message_in_RS485.Length - 1));    //то пишем в лог-файл полученные по RS485 данные
                        MainForm.StringBuilder_To_loging = MainForm.StringBuilder_To_loging.Append(DateTime.Now + "   " + message_in_RS485.Substring(0, message_in_RS485.Length - 1) + "        Запрет доступа   \n\r");
                    }
                    flag_open=false;   
                    Thread.Sleep(100); 
                }
            }
        }
    }
    public class Counter
    {
        public int x;
    }

}
