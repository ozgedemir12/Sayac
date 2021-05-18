using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        int sayac = 25;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = sayac.ToString();
            sayac--;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayac = 25;
            label2.Text = sayac.ToString();
        }
    }
}
