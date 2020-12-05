using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primer
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

        private void btnKonvertuj_Click(object sender, EventArgs e)
        {
            string input1 = tbInput.Text;
            string input2 = tbOutput.Text;
            tbInput.Text = input2;
            tbOutput.Text = input1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int broj = Convert.ToInt32(tbCounter.Text);
            broj = broj * 2;
            tbCounter.Text = Convert.ToString(broj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(timer.Enabled == true)
            {
                timer.Enabled = false;
            }
            else
            {
                timer.Enabled = true;
            }
        }
    }
}
