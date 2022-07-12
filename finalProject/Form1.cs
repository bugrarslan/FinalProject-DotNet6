namespace finalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            waterReminder1.Hide();
            reminder1.Hide();
        }

        private void water_reminder_Click(object sender, EventArgs e)
        {
            reminder1.Hide();
            waterReminder1.Show();
        }

        private void basic_streching_reminder_Click(object sender, EventArgs e)
        {

        }

        private void appointment_reminder_Click(object sender, EventArgs e)
        {
            waterReminder1.Hide();
            reminder1.Show();
        }

        private void breath_exercise_Click(object sender, EventArgs e)
        {

        }

        private void waterReminder1_Load(object sender, EventArgs e)
        {

        }
    }
}