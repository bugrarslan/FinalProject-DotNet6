namespace finalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.breath_exercise = new System.Windows.Forms.Button();
            this.appointment_reminder = new System.Windows.Forms.Button();
            this.basic_streching_reminder = new System.Windows.Forms.Button();
            this.water_reminder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.waterReminder1 = new finalProject.WaterReminder();
            this.reminder1 = new finalProject.reminder();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.breath_exercise);
            this.panel1.Controls.Add(this.appointment_reminder);
            this.panel1.Controls.Add(this.basic_streching_reminder);
            this.panel1.Controls.Add(this.water_reminder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 584);
            this.panel1.TabIndex = 0;
            // 
            // breath_exercise
            // 
            this.breath_exercise.Location = new System.Drawing.Point(52, 438);
            this.breath_exercise.Name = "breath_exercise";
            this.breath_exercise.Size = new System.Drawing.Size(75, 47);
            this.breath_exercise.TabIndex = 7;
            this.breath_exercise.Text = "breath exercise";
            this.breath_exercise.UseVisualStyleBackColor = true;
            this.breath_exercise.Click += new System.EventHandler(this.breath_exercise_Click);
            // 
            // appointment_reminder
            // 
            this.appointment_reminder.Location = new System.Drawing.Point(52, 318);
            this.appointment_reminder.Name = "appointment_reminder";
            this.appointment_reminder.Size = new System.Drawing.Size(93, 69);
            this.appointment_reminder.TabIndex = 6;
            this.appointment_reminder.Text = "appointment reminder";
            this.appointment_reminder.UseVisualStyleBackColor = true;
            this.appointment_reminder.Click += new System.EventHandler(this.appointment_reminder_Click);
            // 
            // basic_streching_reminder
            // 
            this.basic_streching_reminder.Location = new System.Drawing.Point(53, 206);
            this.basic_streching_reminder.Name = "basic_streching_reminder";
            this.basic_streching_reminder.Size = new System.Drawing.Size(75, 67);
            this.basic_streching_reminder.TabIndex = 5;
            this.basic_streching_reminder.Text = "basic streching reminder";
            this.basic_streching_reminder.UseVisualStyleBackColor = true;
            this.basic_streching_reminder.Click += new System.EventHandler(this.basic_streching_reminder_Click);
            // 
            // water_reminder
            // 
            this.water_reminder.Location = new System.Drawing.Point(36, 122);
            this.water_reminder.Name = "water_reminder";
            this.water_reminder.Size = new System.Drawing.Size(109, 23);
            this.water_reminder.TabIndex = 4;
            this.water_reminder.Text = "water reminder";
            this.water_reminder.UseVisualStyleBackColor = true;
            this.water_reminder.Click += new System.EventHandler(this.water_reminder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose your action";
            // 
            // waterReminder1
            // 
            this.waterReminder1.Location = new System.Drawing.Point(206, 0);
            this.waterReminder1.Name = "waterReminder1";
            this.waterReminder1.Size = new System.Drawing.Size(907, 584);
            this.waterReminder1.TabIndex = 1;
            this.waterReminder1.Load += new System.EventHandler(this.waterReminder1_Load);
            // 
            // reminder1
            // 
            this.reminder1.Location = new System.Drawing.Point(206, 0);
            this.reminder1.Name = "reminder1";
            this.reminder1.Size = new System.Drawing.Size(907, 584);
            this.reminder1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 584);
            this.Controls.Add(this.reminder1);
            this.Controls.Add(this.waterReminder1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Kagan Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button breath_exercise;
        private Button appointment_reminder;
        private Button basic_streching_reminder;
        private Button water_reminder;
        private WaterReminder waterReminder1;
        private reminder reminder1;
    }
}