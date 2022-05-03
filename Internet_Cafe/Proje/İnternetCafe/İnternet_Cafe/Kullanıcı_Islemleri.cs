using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnternet_Cafe
{
    public partial class Kullanici_Islemleri : Form
    {
        public Kullanici_Islemleri()
        {
            InitializeComponent();
        }

        public int denemeSayisi = 0;

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Kullanıcı Sınıfını çağırarak giriş yapmayı sağlıyoruz
        private void button_Giris_Click(object sender, EventArgs e)
        {
            Kullanici.login(textBox_KullaniciAdi, textBox_Sifre);
            if (Kullanici.kontrol==true)
            {
                //kullanıcı adı ve şifre doğru ise
                FormSatis a = new FormSatis();
                a.Show();
                this.Hide();

            }
            else if (Kullanici.kontrol==false)
            {
                //kullanıcı adı ve şifre yanlış ise

                denemeSayisi++;
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı..!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_KullaniciAdi.Clear();
                textBox_Sifre.Clear();
                textBox_KullaniciAdi.Focus();

                if(denemeSayisi==3)
                {
                    MessageBox.Show("3 defa hatalı giriş yaptınız");
                    Application.Exit();
                    
                }
            }
        }


        //ŞİFRE UNUTTUM İŞLEMİ
        private void link_SifemiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SifremiUnuttum a = new SifremiUnuttum();
            a.Show();
        }
    }
}
