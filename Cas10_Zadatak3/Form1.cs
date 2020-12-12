using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cas10zadatak3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int brojac = 0;
        int promena = 0;

        private void btnNapred_Click(object sender, EventArgs e)
        {
            promena = 1;
            timer1.Start();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            promena = -1;
            timer1.Start();
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            brojac = 0;
            tbTimer.Text = brojac.ToString();
        }

        private void tbTimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            brojac += promena;
            tbTimer.Text = brojac.ToString();
        }
    }
}
