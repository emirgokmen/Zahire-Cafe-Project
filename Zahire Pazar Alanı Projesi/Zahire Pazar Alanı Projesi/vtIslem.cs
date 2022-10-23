using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahire_Pazar_Alanı_Projesi
{
    internal class vtIslem
    {
        #region Değişkenler ve Tanımlamalar
        public static SqlConnection musConn = new SqlConnection(vtBaglanti.vtConn);
        public static SqlDataAdapter musAdp;
        public static SqlCommand cmd = new SqlCommand();
        #endregion

        #region Kullanıcı Tanımlı Olaylar

        public static DataTable veriGetir(string sorgu)
        {
            DataTable zahireeee = new DataTable();
           
            musAdp = new SqlDataAdapter(sorgu, musConn);
            musAdp.Fill(zahireeee);
            return zahireeee;
        }

        public static void KomutCalistir(string komut)
        {
            try
            {
                if (musConn.State == ConnectionState.Closed)
                    musConn.Open();
                cmd.CommandText = komut;
                cmd.Connection = musConn;
                parametre.islemDurumu = cmd.ExecuteNonQuery();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (musConn.State == ConnectionState.Open)
                    musConn.Close();
            }
        }
        #endregion
    }
}
