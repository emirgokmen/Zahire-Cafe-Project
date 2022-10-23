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
    public partial class SATIŞFORMU : Form
    {
        public SATIŞFORMU()
        {
            InitializeComponent();
        }
    

       
        private void veriDoldur()
        {
            string sorgu = "SELECT * FROM satis";
            dataGridView1.DataSource = vtIslem.veriGetir(sorgu);
        }

        private void cmbDoldur()
        {
            DataTable tablo = new DataTable();
            string sorgu = "SELECT urunadi FROM uruntablosu";
            tablo = vtIslem.veriGetir(sorgu);
            int k = 0;
            while (k < tablo.Rows.Count)
            {
                comboBox2.Items.Add(tablo.Rows[k].ItemArray[0].ToString());
                k++;
            }
        }

        private void temizle()
        {
            comboBox1.Text="";
            comboBox2.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void baslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Kategori Adı";
            dataGridView1.Columns[0].Width = 45;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //***********************************************************************************
            dataGridView1.Columns[1].HeaderText = "Ürün Adı";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //***********************************************************************************
            dataGridView1.Columns[2].HeaderText = "Adet";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //***********************************************************************************
            dataGridView1.Columns[3].HeaderText = "Personel Ad";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //***********************************************************************************
            dataGridView1.Columns[4].HeaderText = "Tarih";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //***********************************************************************************
            dataGridView1.Columns[5].HeaderText = "Fiyat";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void SATIŞFORMU_Load(object sender, EventArgs e)
        {
            cmbDoldur();
            veriDoldur();
            baslikGoster();
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komut = "INSERT INTO satis (kategoriadi, urunadi , adet, personelad, fiyat, tarih) VALUES('" + comboBox1.SelectedItem+ "', '" + comboBox2.SelectedItem + "' ,  '" + textBox2.Text + "' ,'" + textBox1.Text + "' , '" + textBox3.Text + "' ,  '" + DateTime.Now.ToString("MM.dd.yyyy") + "')"; ;
            vtIslem.KomutCalistir(komut);
       

            veriDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

