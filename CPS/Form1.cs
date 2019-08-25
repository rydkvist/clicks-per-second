using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPS
{
    public partial class Form1 : Form
    {
        int clicks = 0;
        int highscore = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicks++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (clicks).ToString() + " CPS (Clicks per second)";
            if (clicks > highscore) highscore = clicks;
            label1.Text = "Session Highscore: " + highscore;
            clicks = 0;
        }
    }
}
