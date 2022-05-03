using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace İnternet_Cafe
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3ODUATA\SQLEXPRESS;Initial Catalog=InternetCafe;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            lblHata.Visible = false;
        }


        //Veritabanına kayıtlı olan şifreyi mail ile kullanıcıya iletir
        private void btnGonder_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * from tbl_kullanici where KullaniciAdi='" + textBox1.Text.ToString() +
                "' and Email='" + textBox2.Text.ToString() + "'", baglanti());

            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                try
                {
                    if (baglanti().State == ConnectionState.Closed)
                    {
                        baglanti().Open();
                    }
                  
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    string tarih = DateTime.Now.ToLongDateString();
                    string mailadresin = ("internetcafeotomasyonu@gmail.com");
                    string sifre = ("denemeInternetCafe");
                    string smptsrvr = "smtp.gmail.com";
                    string kime = (oku["Email"].ToString());
                    string konu = ("Şifre Hatırlatma Maili");
                    string yaz = ("Sayın, " + oku["KullaniciAdi"].ToString() + "\n" + "Bizden " + tarih + " Tarihinde Şifre Hatırlatma Talebinde" +
                        " Bulundunuz" + "\n" + "Parolaniz: " + oku["Sifre"].ToString() + "\nİyi Günler");
                    smtpserver.Credentials = new NetworkCredential(mailadresin, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smptsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;                   
                    mail.Body = yaz;
                    smtpserver.Send(mail);



                    progressBar1.Visible = true;
                    progressBar1.Maximum = 900000;
                    progressBar1.Minimum = 90;

                    for (int j = 90; j < 900000; j++)
                    {
                        progressBar1.Value = j;
                    }


                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Girmiş olduğunuz bilgiler uyuşuyor. Şifreniz Mail adresinize gönderilmiştir.");
                    lblHata.BackColor = Color.Green;
                    lblHata.Visible = true;
                    lblHata.Text = "Girmiş olduğunuz bilgiler uyuşuyor. Şifreniz Mail adresinize gönderilmiştir.";
                    this.Hide();

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.Red;
                    lblHata.Text = "Mail Gönderme Hatası";

                }
            }
            else
            {
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Red;
                lblHata.Text = "Girmiş Olduğunuz Bilgiler Uyuşmuyor";
            }
        }
    }
}
