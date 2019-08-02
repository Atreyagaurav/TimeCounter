using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace GRE_Counter
{
    public partial class Form1 : Form
    {
        public DateTime count;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            timer1.Start();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
        DateTime b = DateTime.Now;
        TimeSpan duration = count - b;
        TextDD.Text = duration.Days.ToString();
        TextHH.Text = duration.Hours.ToString();
        TextMM.Text = duration.Minutes.ToString();
        TextSS.Text = duration.Seconds.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            count = Settings1.Default.DT;
        }
        private void Form1_DoubleClick(object sender,EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            count = dateTimePicker1.Value;
            Settings1.Default.Save();
        }
    }
}
