using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cas10zadatak2
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

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double rezultat = a + b;
            tbR.Text = rezultat.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double rezultat = a - b;
            tbR.Text = rezultat.ToString();
        }

        private void btnPuta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double rezultat = a * b;
            tbR.Text = rezultat.ToString();
        }

        private void btnPodeljeno_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double rezultat = a / b;
            tbR.Text = rezultat.ToString();
        }

        private void tbA_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbB_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
