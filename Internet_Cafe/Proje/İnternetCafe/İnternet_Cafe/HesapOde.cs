using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace İnternet_Cafe
{
    public partial class HesapOde : Form
    {
        public HesapOde()
        {
            InitializeComponent();
        }

        //masa kapatma işlemi
        private void button_MasaKapat_Click(object sender, EventArgs e)
        {
            string Sorgu = "insert into tbl_satis(KullaniciID,MasaID,AcilisTuru,BaslangicSaati,BitisSaati,Sure,Tutar,Aciklama,Tarih) values('" + Kullanici.KullaniciID + "','" + int.Parse(textBox_MasaID.Text) + "','" + textBox_AcilisTuru.Text + "',@Baslangic,@Bitis,@Sure,@Tutar,'Açıklama Yapılmadı',@Tarih)";

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Baslangic", DateTime.Parse(textBox_BaslamaSaati.Text));
            cmd.Parameters.AddWithValue("@Bitis", DateTime.Parse(textBox_BitisSaati.Text));
            cmd.Parameters.AddWithValue("@Sure", decimal.Parse(textBox_Sure.Text));
            cmd.Parameters.AddWithValue("@Tutar", decimal.Parse(textBox_Tutar.Text));
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Parse(textBox_Tarih.Text));


            Veritabani.KomutYollaParamereli(cmd, Sorgu);
            //string sqlSorgu = "update tbl_masalar set Durumu = 'BOŞ' where MasaID = '"+textBox_MasaID.Text+"'";
            //string sqlSorgu2 = "delete tbl_gecici where GeciciID='" + textBox_ID.Text + "'";
            //SqlCommand cmd1 = new SqlCommand();
            //SqlCommand cmd = new SqlCommand();
            //Veritabani.KomutYollaParamereli(cmd,sqlSorgu);
            //Veritabani.KomutYollaParamereli(cmd1, sqlSorgu2);
            this.Close();
            FormSatis Form = (FormSatis)Application.OpenForms["FormSatis"];
            Form.Doldur();
            
        }

        private void button_Iptal_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
