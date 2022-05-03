using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace İnternet_Cafe
{
    class Veritabani:Sql.sqlconnection
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static DataSet ds;

        public static DataTable GeciciListele(DataGridView gridim)
        {
            da = new SqlDataAdapter("select *from tbl_gecici", con);
            dt = new DataTable();
            da.Fill(dt);
            gridim.DataSource = dt;

            return dt;
        }

        public static DataTable Goruntule(DataGridView gridim, string sorgu)
        {
            da = new SqlDataAdapter(sorgu, con);
            dt = new DataTable();
            da.Fill(dt);
            gridim.DataSource = dt;

            return dt;
        }

        //formSatis kısmında yer alan comboBox_BosMasalar' ı doldurduk
        public static DataTable ComboBoxdaBosMasaGoster(ComboBox comboBox_BosMasalar)
        {
            con.Open();
            da = new SqlDataAdapter("select *from tbl_masalar where Durumu='BOŞ'", con);
            dt = new DataTable();
            da.Fill(dt);
            comboBox_BosMasalar.DataSource = dt;
            comboBox_BosMasalar.DisplayMember = "Masalar";
            comboBox_BosMasalar.ValueMember = "MasaID";
            con.Close();

            return dt;
        }


        //ekleme,silme,güncelleme işlemleri için tanımlanmış fonksiyon
        public static void KomutYollaParamereli (SqlCommand cmd1 , string Sorgu)
        {
                con.Open();
                cmd1.CommandText = Sorgu;
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();
                con.Close();
      
        }


        //ListView de isteklerin görüntülenmesi işlemi
        public static SqlDataReader ViewdeKayıtlarıGöster(ListView lv)
        {
            lv.Items.Clear();
            con.Open();
            cmd = new SqlCommand("select *from tbl_hareketler where Tarih>=@Tarih", con);
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToShortDateString()));
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                ekle.SubItems.Add(dr[2].ToString());
                ekle.SubItems.Add(dr[3].ToString());
                ekle.SubItems.Add(dr[4].ToString());
                ekle.SubItems.Add(dr[5].ToString());
                ekle.SubItems.Add(dr[6].ToString());
                lv.Items.Add(ekle);
            }
            con.Close();
            return dr;
        }



        //MD5 şifreleme işlemi
        public static string MD5Sifrele(string SifrelenecekMetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(SifrelenecekMetin);
            dizi = md5.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
            {
                sb.Append(item.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}
