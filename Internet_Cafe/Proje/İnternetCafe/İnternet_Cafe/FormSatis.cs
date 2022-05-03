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

namespace İnternet_Cafe
{
    public partial class FormSatis : Form
    {

        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        DataTable dt;


        public FormSatis()
        {
            InitializeComponent();
            dataGridBoyutAyarla();
        }



        private void FormSatis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'internetCafeDataSet.tbl_saatUcreti' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_saatUcretiTableAdapter.Fill(this.internetCafeDataSet.tbl_saatUcreti);
            //// TODO: Bu kod satırı 'internetCafeDataSet.tbl_saatUcreti' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_saatUcretiTableAdapter.Fill(this.internetCafeDataSet.tbl_saatUcreti);
            // TODO: Bu kod satırı 'internetCafeDataSet1.tbl_gecici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_geciciTableAdapter.Fill(this.internetCafeDataSet1.tbl_gecici);
            // TODO: Bu kod satırı 'internetCafeDataSet1.tbl_hareketler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_hareketlerTableAdapter.Fill(this.internetCafeDataSet1.tbl_hareketler);
            // TODO: Bu kod satırı 'internetCafeDataSet1.tbl_kullanici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_kullaniciTableAdapter.Fill(this.internetCafeDataSet1.tbl_kullanici);
            // TODO: Bu kod satırı 'internetCafeDataSet1.tbl_masalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_masalarTableAdapter.Fill(this.internetCafeDataSet1.tbl_masalar);
            // TODO: Bu kod satırı 'internetCafeDataSet1.tbl_saatUcreti' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_saatUcretiTableAdapter1.Fill(this.internetCafeDataSet1.tbl_saatUcreti);
            // TODO: Bu kod satırı 'internetCafeDataSet1.tbl_satis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_satisTableAdapter2.Fill(this.internetCafeDataSet1.tbl_satis);
            // TODO: Bu kod satırı 'internetCafeDataSet.tbl_satis' tablosuna veri yükler.Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_satisTableAdapter1.Fill(this.internetCafeDataSet.tbl_satis);
            // TODO: Bu kod satırı 'internetCafeDataSet_tblSatis.tbl_satis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_satisTableAdapter.Fill(this.internetCafeDataSet_tblSatis.tbl_satis);
            // TODO: Bu kod satırı 'internetCafeDataSet.tbl_satis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_satisTableAdapter1.Fill(this.internetCafeDataSet.tbl_satis);
            // TODO: Bu kod satırı 'internetCafeDataSet_tblSatis.tbl_satis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_satisTableAdapter.Fill(this.internetCafeDataSet_tblSatis.tbl_satis);
            // TODO: Bu kod satırı 'internetCafeDataSet.tbl_saatUcreti' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_saatUcretiTableAdapter.Fill(this.internetCafeDataSet.tbl_saatUcreti);

            radioButton_Suresiz.Checked = true;
            comboBox_BosMasalar.Text = " ";
            Doldur();
            timer1.Start();
            
        }

        public void dataGridBoyutAyarla()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].Width = 105;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[6].Width = 75;
            dataGridView1.Columns[7].Width = 75;
            dataGridView1.Columns[5].Width = 120;

        }




        Button btn;

        private void SecilenMasa(object sender, MouseEventArgs e)
        {
            btn = sender as Button;

            //dolu olan masalarda masa açma isteğini gizledik
            if (btn.BackColor == Color.OrangeRed)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
                masaDeğiştirmeİsteğiGönderToolStripMenuItem.Visible = true;
            }

            //boş olan masalarda masa değiştirme isteğini gizledik
            if (btn.BackColor == Color.YellowGreen)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
                masaDeğiştirmeİsteğiGönderToolStripMenuItem.Visible = false;
            }

        }



        RadioButton rb;
        private void RadioButton_SeciliSure(object sender, EventArgs e)
        {
            rb = sender as RadioButton;
        }



        public void Doldur()
        {
            Veritabani.ComboBoxdaBosMasaGoster(comboBox_BosMasalar);
            Veritabani.GeciciListele(dataGridView1);
            Veritabani.ViewdeKayıtlarıGöster(listView1);

            //masaların boş dolu ayrımı yapılması
            foreach (Control item in Controls)
            {

                if (item is Button)
                {
                    if (item.Name != button_Masa_Ac.Name)
                    {
                        Veritabani.con.Open();
                        // SqlCommand cmd = new SqlCommand("select * from tbl_masalar", con); //ister yukarda tanımla ister fonksiyon içerisinde
                        cmd = new SqlCommand("select * from tbl_masalar", Veritabani.con);
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {

                            if (dr["Durumu"].ToString() == "BOŞ" && dr["Masalar"].ToString() == item.Text)
                            {
                                //BOŞ ise;
                                item.BackColor = Color.YellowGreen;
                            }
                            if (dr["Durumu"].ToString() == "DOLU" && dr["Masalar"].ToString() == item.Text)
                            {
                                //DOLU ise;
                                item.BackColor = Color.OrangeRed;
                            }
                        }

                        Veritabani.con.Close();
                    }
                }
            }

        }




        //Masa açma
        private void button_Masa_Ac_Click(object sender, EventArgs e)
        {
            if (Kullanici.KullaniciID==1)
            {
                //Yönetici ise
                string sqlSorgu = "insert into tbl_gecici(MasaID,Masa,AcilisTuru,Baslangic,Tarih) values('" + comboBox_BosMasalar.Text.Substring(5) + "','" + comboBox_BosMasalar.Text + "','" + rb.Text + "',@Baslangic,@Tarih) ";
                SqlCommand cmd1 = new SqlCommand(sqlSorgu, Veritabani.con);
                cmd1.Parameters.AddWithValue("@Baslangic", DateTime.Parse(DateTime.Now.ToString()));
                cmd1.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToString()));
                Veritabani.KomutYollaParamereli(cmd1, sqlSorgu);
                MessageBox.Show(comboBox_BosMasalar.Text.Substring(5) + " nolu masa açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Doldur();
                radioButton_Suresiz.Checked = true;             
            }
            else
            {
                //Yönetici değil ise
                MessageBox.Show("Yetkiniz Bulunmamaktadır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }



        //form kapatma işlemi
        private void FormSatis_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); //formu X basınca direkt kapatıyor
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {    
            //hesaplama işlemi
            if (e.ColumnIndex==dataGridView1.Columns["Hesapla"].Index)
            {
                if (comboBox_SaatUcreti.Text !="")
                {
                    DateTime BitisSaati = DateTime.Now;
                    DateTime BaslangicSaati = DateTime.Parse(dataGridView1.CurrentRow.Cells["Baslama_Saati"].Value.ToString());
                    TimeSpan AradakiSaatFarki = BitisSaati - BaslangicSaati;
                    double OndalikliSaatFarki = AradakiSaatFarki.TotalHours;
                    dataGridView1.CurrentRow.Cells["Sure"].Value = OndalikliSaatFarki.ToString("0.00");
                    double Odenecektutar = OndalikliSaatFarki * double.Parse(comboBox_SaatUcreti.Text);
                    dataGridView1.CurrentRow.Cells["Tutar"].Value = Odenecektutar.ToString("0.00");
                    dataGridView1.CurrentRow.Cells["Bitis_Saati"].Value = BitisSaati;

                }
                if (comboBox_SaatUcreti.Text=="")
                {
                    MessageBox.Show("Lütfen Saat Ücretini Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



            //masa kapatma işlemi
            if (e.ColumnIndex == dataGridView1.Columns["Masa_Kapat"].Index)
            {
                if (dataGridView1.CurrentRow.Cells["Bitis_Saati"].Value !=null)
                {
                    HesapOde a = new HesapOde();

                    a.textBox_ID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    a.textBox_MasaID.Text = dataGridView1.CurrentRow.Cells["Masa_ID"].Value.ToString();
                    a.textBox_Masa.Text = dataGridView1.CurrentRow.Cells["_Masa_"].Value.ToString();
                    a.textBox_AcilisTuru.Text = dataGridView1.CurrentRow.Cells["AcılısTuru"].Value.ToString();
                    a.textBox_BaslamaSaati.Text = dataGridView1.CurrentRow.Cells["Baslama_Saati"].Value.ToString();
                    a.textBox_BitisSaati.Text = dataGridView1.CurrentRow.Cells["Bitis_Saati"].Value.ToString();
                    a.textBox_SaatUcreti.Text = comboBox_SaatUcreti.Text;
                    a.textBox_Sure.Text = dataGridView1.CurrentRow.Cells["Sure"].Value.ToString();
                    a.textBox_Tutar.Text = dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
                    a.textBox_Tarih.Text = dataGridView1.CurrentRow.Cells["_Tarih_"].Value.ToString();

                    a.ShowDialog(); 
                }
                else if (dataGridView1.CurrentRow.Cells["Bitis_Saati"].Value ==null)
                {
                    MessageBox.Show("Önce Hesaplama İşlemi Yapılmalıdır.!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }




        //CONTEXTMENÜSTRİP AYARLARI YAPILDI

        string istek = "";
        
        private void yöneticiÇağırToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            istek = "Yöneticiyi çağırma isteği gönderildi.";
            Istekler();
        }
        private void Istekler()
        {
            string sqlSorgu = "insert into tbl_hareketler(KullaniciID,MasaID,Masa,IstekTuru,Aciklama,Tarih) values(" +
                 "'" +Kullanici.KullaniciID + "','" + btn.Text.Substring(5) + "','" + btn.Text + "','" + istek + "','Açıklama Yapılmadı.',@tarih)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToString()));
            Veritabani.KomutYollaParamereli(cmd, sqlSorgu);
            Veritabani.ViewdeKayıtlarıGöster(listView1);
        }

        private void süresizMasaAçmaİsteğiGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istek = "Süresiz masa açma isteği gönderildi.";
            Istekler();
        }

        private void masaDeğiştirmeİsteğiGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istek = "Masa değiştirme isteği gönderildi.";
            Istekler();
        }

        ToolStripMenuItem Item;
        private void SureliMasaAcmaIstegiSecilirse(object sender, EventArgs e)
        {
            Item = sender as ToolStripMenuItem;
            istek = Item.Text + " Süre ile masa açma isteği gönderildi.";
            Istekler();
        }





        //HESAPLAMA İŞLEMİNİ OTOMATİK HALE GETİRDİK

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac>5)
            {
                if (comboBox_SaatUcreti.Text != "")
                {
                    for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                    {
                        DateTime BitisSaati = DateTime.Now;
                        DateTime BaslangicSaati = DateTime.Parse(dataGridView1.Rows[i].Cells["Baslama_Saati"].Value.ToString());
                        TimeSpan AradakiSaatFarki = BitisSaati - BaslangicSaati;
                        double OndalikliSaatFarki = AradakiSaatFarki.TotalHours;
                        dataGridView1.Rows[i].Cells["Sure"].Value = OndalikliSaatFarki.ToString("0.00");
                        double Odenecektutar = OndalikliSaatFarki * double.Parse(comboBox_SaatUcreti.Text);
                        dataGridView1.Rows[i].Cells["Tutar"].Value = Odenecektutar.ToString("0.00");
                        dataGridView1.Rows[i].Cells["Bitis_Saati"].Value = BitisSaati; 
                    }
                    
                }
                if (comboBox_SaatUcreti.Text == "")
                {
                    MessageBox.Show("Lütfen Saat Ücretini Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
               
        }
 



        //MASA DEĞİŞTİRME İŞLEMİ YAPILDI
        private void button_Masa_Degistir_Click(object sender, EventArgs e)
        {
            //geçici tablomuz güncellendi
            int MasaID= int.Parse(dataGridView1.CurrentRow.Cells["Masa_ID"].Value.ToString());
            int GeciciID = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());

            string sql = "update tbl_gecici set MasaID='" + int.Parse(comboBox_BosMasalar.Text.Substring(5)) + "',Masa='" + comboBox_BosMasalar.Text + "' where GeciciID='" + GeciciID + "'";
            SqlCommand cmd = new SqlCommand();
            Veritabani.KomutYollaParamereli(cmd,sql);


            string sql2 = "update tbl_masalar set Durumu='BOŞ' where MasaID='" + MasaID + "'";
            SqlCommand cmd2 = new SqlCommand();
            Veritabani.KomutYollaParamereli(cmd2, sql2);



            string sql3 = "update tbl_masalar set Durumu='DOLU' where MasaID='" + int.Parse(comboBox_BosMasalar.Text.Substring(5)) + "'";
            SqlCommand cmd3 = new SqlCommand();
            Veritabani.KomutYollaParamereli(cmd3, sql3);


            Doldur();
            MessageBox.Show("Masa Değiştirme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        //SÜRELİ MASALARDA UYARI
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            for (int i = 0; i <dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["Sure"].Value !=null)
                {
                    if (dataGridView1.Rows[i].Cells["AcılısTuru"].Value.ToString() != "Süresiz") 
                    {
                        double sure = double.Parse(dataGridView1.Rows[i].Cells["Sure"].Value.ToString()) * 60;
                        double AcılısTuru = double.Parse(dataGridView1.Rows[i].Cells["AcılısTuru"].Value.ToString());
                        if (AcılısTuru - sure <= 5.0)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                        }
                    }
                   
                }
            } 
           
        }

        //SatislariListele formunu çağırdık
        private void button_GeriAl_Click(object sender, EventArgs e)
        {
            SatislariListele a = new SatislariListele();
            a.button_GeriAl.Enabled = true;
            a.ShowDialog();
        }


        //satışları raporlama formunu çağırdık(Report Wizart)
        private void button_SatisRaporu_Click(object sender, EventArgs e)
        {
            SatisRaporu a = new SatisRaporu();
            a.ShowDialog();
        }


        //hareketler raporu formunu çağırdık
        private void button_HareketlerRaporu_Click(object sender, EventArgs e)
        {
            HareketRaporu a = new HareketRaporu();
            a.ShowDialog();
        }





        //Rapor Yazdırma Sayfasını Açar(Crystal Reports)
        private void button21_Click(object sender, EventArgs e)
        {
            RaporYazdır frm = new RaporYazdır();
            frm.ShowDialog();
        }
    }
}
