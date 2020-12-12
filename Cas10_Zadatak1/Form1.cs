using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cas10zadatak1_opet_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PR = Convert.ToInt32(tbR1.Text);
            PG = Convert.ToInt32(tbG1.Text);
            PB = Convert.ToInt32(tbB1.Text);
            KR = Convert.ToInt32(tbR2.Text);
            KG = Convert.ToInt32(tbG2.Text);
            KB = Convert.ToInt32(tbB2.Text);
            vreme = Convert.ToDouble(tbVreme.Text);
            int brojkoraka = (int)vreme * 10;
            DR = KR - PR;
            DG = KG - PG;
            DB = KB - PB;
            DR /= brojkoraka;
            DG /= brojkoraka;
            DB /= brojkoraka;
            timer1.Start();
        }

        double PR, PG, PB;
        int KR, KG, KB;
        double DR, DG, DB;
        double vreme;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Math.Abs(PR - KR) < 0.1 && Math.Abs(PG - KG) <0.1 && Math.Abs(PB - KB) < 0.1) { timer1.Stop(); }
            this.BackColor = Color.FromArgb((int)PR, (int)PG, (int)PB);
            PR += DR;
            PG += DG;
            PB += DB;
        }

        private void tbVreme_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FromArgb prima 3 broja u opsegu 0-255
            //0,0,0 Crna
            //255,255,255 Bela
            //128,128,128 Siva
            //255,0,0 Crvena
            //0,255,0 Zelena
            //0,0,255 Plava
            //255,255,0 Zuta
            //255,0,255 Ljubicasta
            //0,255,255 Plavo Zelena
            //this.BackColor = Color.FromArgb(0,255,255);
        }

        private void tbR1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbG1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbR2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbG2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbB2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
