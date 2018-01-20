using System;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace DLimageTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DLurl(); //вызываем сработку однократно на старте               
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FormMinimized();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Делаем таймер доступным
            MainTimer.Enabled = true;
            //Запускаем таймер
            MainTimer.Start();
            StatusLbl.Text = "ПИШЕМ!!!";
            DLurl(); //вызываем сработку однократно на старте
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Останавливаем таймер
            MainTimer.Stop();
            //Снова делаем таймер недоступным
            MainTimer.Enabled = false;

            //"Сбрасываем" текст надписи в исходное состояние
            StatusLbl.Text = "ПАУЗА";
        }

       
        private void MainTimer_tick(object sender, EventArgs e)
        {
            DLurl(); //вызываем обработку события по таймеру
        }
        private void DLurl()
        {
            string url = "http://94.73.241.73:8080/cam866/preview.jpg";
            string dir = "School";
            string fname = dir + "\\" + dir + DateTime.Now.ToString("_yy.MM.dd-HH.mm.ss") + ".jpg";
            int interval = 60; //интервал сохранения, в минутах
            MainTimer.Interval = interval*60000;
            using (WebClient client = new WebClient())
            {

                Directory.CreateDirectory(dir);
                client.DownloadFile(url, fname);
            }
            
            TimeLbl.Text = string.Format("Последнее сохранение: {0}", DateTime.Now.ToString("HH:mm:ss"));
            FnameLbl.Text = string.Format("Имя последнего файла: {0}", fname);
            IntervalLbl.Text = string.Format("Интервал (минут): {0}", interval);
            notifyIcon1.Text = this.Text+"\n"+ TimeLbl.Text;
        }

        private void FormMinimized()
        {
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                //notifyIcon1.Visible = false;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                //notifyIcon1.Visible = false;
            }
        }        
    }
}
