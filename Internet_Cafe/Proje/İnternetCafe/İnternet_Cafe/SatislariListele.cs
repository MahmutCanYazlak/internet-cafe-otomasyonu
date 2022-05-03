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
    public partial class SatislariListele : Form
    {
        public SatislariListele()
        {
            InitializeComponent();
        }

        private void SatislariListele_Load(object sender, EventArgs e)
        {
            Veritabani.Goruntule(dataGridView1, "select * from tbl_satis");
        }

        //Yapılan işlemi geri alma

        private void button_GeriAl_Click(object sender, EventArgs e)
        {
            int masaID = int.Parse(dataGridView1.CurrentRow.Cells["MasaID"].Value.ToString());
            int  kullaniciID= int.Parse(dataGridView1.CurrentRow.Cells["KullaniciID"].Value.ToString());
            string masa = "MASA-" + masaID;
            string acilisTuru = dataGridView1.CurrentRow.Cells["AcilisTuru"].Value.ToString();
            DateTime baslangicSaati =DateTime.Parse( dataGridView1.CurrentRow.Cells["BaslangicSaati"].Value.ToString());
            DateTime tarih = DateTime.Parse(dataGridView1.CurrentRow.Cells["Tarih"].Value.ToString());


            string sql = "insert into tbl_gecici(MasaID,Masa,AcilisTuru,Baslangic,Tarih) values ('" + masaID + "', '" + masa + "','" + acilisTuru + "',@baslangicSaati,@tarih)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@baslangicSaati", baslangicSaati);
            cmd.Parameters.AddWithValue("@tarih", tarih);
            Veritabani.KomutYollaParamereli(cmd,sql);


            string sql2 = "delete from  tbl_satis where  SatisID='"+int.Parse(dataGridView1.CurrentRow.Cells["SatisID"].Value.ToString())+"'";
            SqlCommand cmd2 = new SqlCommand();
            Veritabani.KomutYollaParamereli(cmd2, sql2);


            this.Close();
            FormSatis a = (FormSatis)Application.OpenForms["FormSatis"];
            a.Doldur();

        }
    }
}
