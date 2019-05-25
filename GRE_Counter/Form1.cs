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
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
        DateTime a = new DateTime(2019, 7, 30, 8, 00, 00);
        DateTime b = DateTime.Now;
        TimeSpan duration = a - b;
        TextDD.Text = duration.Days.ToString();
        TextHH.Text = duration.Hours.ToString();
        TextMM.Text = duration.Minutes.ToString();
        TextSS.Text = duration.Seconds.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
