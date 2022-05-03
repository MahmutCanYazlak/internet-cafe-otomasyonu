using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace İnternet_Cafe
{
    class Kullanici
    {
        static SqlCommand cmd;
        static SqlDataReader dr;
   
        public static int KullaniciID = 0;
        public static bool kontrol = true;


        //Login ekranı ve giriş yapan kullanıcınnı KullaniciID sini Session yapısı ile çekiyoruz
        public static SqlDataReader login(TextBox KullaniciAdi , TextBox Sifre)
        {
            Veritabani.con.Open();
            cmd = new SqlCommand("select * from tbl_kullanici where kullaniciAdi=@user and Sifre=@pass ", Veritabani.con);
            cmd.Parameters.AddWithValue("@user", KullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@pass", Veritabani.MD5Sifrele(Sifre.Text));
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kontrol = true;
                KullaniciID = int.Parse(dr["KullaniciID"].ToString());
            }
            else
            {
                kontrol = false;
            }
            Veritabani.con.Close();
            
            return dr;
        }
    }
}
