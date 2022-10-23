using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahire_Pazar_Alanı_Projesi
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SATIŞFORMU stsfrm = new SATIŞFORMU();
            stsfrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SATINALMA stnfrm = new SATINALMA();
            stnfrm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PERSONEL prsnlfrm = new PERSONEL();
            prsnlfrm.Show();
        }
    }
}
