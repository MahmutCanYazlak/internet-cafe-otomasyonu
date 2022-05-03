using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace İnternet_Cafe
{
    public partial class md5Sifrele : Form
    {
        public md5Sifrele()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox_NormalSifre.Text != " ")
            {
                richTextBox_Md5Sifre.Text = MD5Sifrele(textBox_NormalSifre.Text);
            }
            
        }

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

        private void md5Sifrele_Load(object sender, EventArgs e)
        {

        }
    }
}
