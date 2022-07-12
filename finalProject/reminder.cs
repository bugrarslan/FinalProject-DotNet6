using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Tulpep.NotificationWindow;

namespace finalProject
{
    public partial class reminder : UserControl
    {
        int a = 0;
        public string message = "";
        public reminder()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            stop.Enabled = false;
            message = textBox1.Text;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            start.Enabled = true;
            if (dateTimePicker1.Value <= DateTime.Now)
            {
                timer1.Stop();
                SoundPlayer player = new SoundPlayer();
                string sarkiYol = Application.StartupPath + "//alarm.waw";
                player.Play();
                a = 1;
            }
            stop.Enabled = true;
            if (a == 1)
            {
                //popoup
                PopupNotifier notifier = new PopupNotifier();
                notifier.TitleText = "Reminder!!!";
                notifier.ContentText = message;
                notifier.Popup();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            start.Enabled = true;
            stop.Enabled = false;
            timer1.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void reminder_Load(object sender, EventArgs e)
        {

        }
    }
}
