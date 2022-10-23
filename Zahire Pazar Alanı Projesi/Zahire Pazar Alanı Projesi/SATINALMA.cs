using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahire_Pazar_Alanı_Projesi
{
    public partial class SATINALMA : Form
    {
        public SATINALMA()
        {
            InitializeComponent();
        }

        private void veriDoldur()
        {
            string sorgu = "SELECT * FROM satinalma";
            dataGridView1.DataSource = vtIslem.veriGetir(sorgu);
        }

        private void baslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Satın Alınan Ürün";
            dataGridView1.Columns[0].Width = 45;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //***********************************************************************************
            dataGridView1.Columns[1].HeaderText = "Satın Alınan Adet";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //***********************************************************************************
            dataGridView1.Columns[2].HeaderText = "Toptancının Adı";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //***********************************************************************************
            dataGridView1.Columns[3].HeaderText = "Satın Alınan Fiyat";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //***********************************************************************************
            dataGridView1.Columns[4].HeaderText = "Satın Alma Tarihi";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        private void SATINALMA_Load(object sender, EventArgs e)
        {
            veriDoldur();
            baslikGoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komut = "INSERT INTO satinalma (satinalinanurun, satinalinanadet, toptancininadi, satinalinanfiyat, satinalmatarihi) VALUES('" + textBox3.Text + "', '" + textBox4.Text + "' ,  '" + textBox2.Text + "' ,'" + textBox1.Text + "' ,   '" + DateTime.Now.ToString("MM.dd.yyyy") + "')";
            vtIslem.KomutCalistir(komut);
            veriDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string komut = "UPDATE satinalma SET satinalinanurun='"+textBox3.Text+"', satinalinanadet='"+textBox4.Text+"', toptancininadi='"+textBox2.Text+"', satinalinanfiyat='"+textBox1.Text+ "' WHERE satinalinanurun='" + dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'";
            vtIslem.KomutCalistir(komut);
            veriDoldur();
        }

        

        private void üRÜNGÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

      

     
    }
}
