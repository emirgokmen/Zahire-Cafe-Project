using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Zahire_Pazar_Alanı_Projesi
{
    public partial class PERSONEL : Form
    {
        public PERSONEL()
        {
            InitializeComponent();
        }


        private void veriDoldur()
        {
            string sorgu = "SELECT * FROM personel";
            dataGridView1.DataSource = vtIslem.veriGetir(sorgu);
        }

        private void baslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Personel Adı";
            dataGridView1.Columns[0].Width = 45;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //***********************************************************************************
            dataGridView1.Columns[1].HeaderText = "Personel Soyadı";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //***********************************************************************************
            dataGridView1.Columns[2].HeaderText = "İşi";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //***********************************************************************************
            dataGridView1.Columns[3].HeaderText = "Maaş";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //***********************************************************************************
            dataGridView1.Columns[4].HeaderText = "İşe Giriş Tarihi";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string komut = "DELETE FROM personel WHERE personeladi VALUES('" + textBox3.Text + "')')";
            string komut = "DELETE FROM personel WHERE personeladi='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            vtIslem.KomutCalistir(komut);
            veriDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komut = "INSERT INTO personel (personeladi, personelsoyad, isi, maas, isegiristarihi) VALUES('" + textBox3.Text + "', '" + textBox4.Text + "' ,  '" + textBox2.Text + "' ,'" + textBox1.Text + "' ,   '" + DateTime.Now.ToString("MM.dd.yyyy") + "')";
            vtIslem.KomutCalistir(komut);
            veriDoldur();
        }

        private void PERSONEL_Load(object sender, EventArgs e)
        {
            veriDoldur();
            baslikGoster();
        }
    }

}


    

