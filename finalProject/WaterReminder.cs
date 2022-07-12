
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace finalProject
{
    public partial class WaterReminder : UserControl
    {
        DateTime finishTime; 
        public WaterReminder()
        {
            InitializeComponent();
        }

        private void WaterReminder_Load(object sender, EventArgs e)
        {
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            start.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Show();
            checkBox3.Show();
            checkBox4.Show();
            checkBox5.Show();
            start.Show();
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            finishTime = DateTime.Now.AddMinutes(15); //15
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            finishTime = DateTime.Now.AddMinutes(30); //30
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            finishTime = DateTime.Now.AddMinutes(45); // 45
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            finishTime = DateTime.Now.AddHours(1);
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == finishTime.Hour && DateTime.Now.Minute == finishTime.Minute && DateTime.Now.Second == finishTime.Second)
            {  
                timer1.Stop();
                PopupNotifier notifier = new PopupNotifier();
                notifier.TitleText = "Su iç";
                notifier.ContentText = "Su iç!!!";
                notifier.Popup();

                if (checkBox2.Checked)
                {
                    finishTime = DateTime.Now.AddMinutes(15); //15
                }
                else if (checkBox3.Checked)
                {
                    finishTime = DateTime.Now.AddMinutes(30); //30
                }
                else if (checkBox4.Checked)
                {
                    finishTime = DateTime.Now.AddMinutes(45); // 45
                }
                else if (checkBox5.Checked)
                {
                    finishTime = DateTime.Now.AddHours(1);
                }

                timer1.Start();
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}


