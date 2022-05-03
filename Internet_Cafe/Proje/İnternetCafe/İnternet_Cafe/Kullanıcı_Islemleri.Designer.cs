
namespace İnternet_Cafe
{
    partial class Kullanici_Islemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici_Islemleri));
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_Giris = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.link_SifemiUnuttum = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_KullaniciAdi
            // 
            this.textBox_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_KullaniciAdi.Location = new System.Drawing.Point(142, 172);
            this.textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            this.textBox_KullaniciAdi.Size = new System.Drawing.Size(227, 24);
            this.textBox_KullaniciAdi.TabIndex = 0;
            this.textBox_KullaniciAdi.Text = "admin";
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Sifre.Location = new System.Drawing.Point(142, 214);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.PasswordChar = '*';
            this.textBox_Sifre.Size = new System.Drawing.Size(227, 24);
            this.textBox_Sifre.TabIndex = 1;
            this.textBox_Sifre.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(48, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(96, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::İnternet_Cafe.Properties.Resources.person;
            this.pictureBox1.Location = new System.Drawing.Point(197, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(398, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkBox1.Location = new System.Drawing.Point(142, 253);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Beni Hatırla";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // button_Giris
            // 
            this.button_Giris.BackColor = System.Drawing.Color.SkyBlue;
            this.button_Giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Giris.FlatAppearance.BorderSize = 0;
            this.button_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Giris.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Giris.ImageIndex = 0;
            this.button_Giris.ImageList = this.ımageList1;
            this.button_Giris.Location = new System.Drawing.Point(176, 289);
            this.button_Giris.Name = "button_Giris";
            this.button_Giris.Size = new System.Drawing.Size(121, 37);
            this.button_Giris.TabIndex = 2;
            this.button_Giris.Text = "Giriş";
            this.button_Giris.UseVisualStyleBackColor = false;
            this.button_Giris.Click += new System.EventHandler(this.button_Giris_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "giris.png");
            // 
            // link_SifemiUnuttum
            // 
            this.link_SifemiUnuttum.AutoSize = true;
            this.link_SifemiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.link_SifemiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_SifemiUnuttum.LinkColor = System.Drawing.Color.SkyBlue;
            this.link_SifemiUnuttum.Location = new System.Drawing.Point(273, 254);
            this.link_SifemiUnuttum.Name = "link_SifemiUnuttum";
            this.link_SifemiUnuttum.Size = new System.Drawing.Size(96, 15);
            this.link_SifemiUnuttum.TabIndex = 6;
            this.link_SifemiUnuttum.TabStop = true;
            this.link_SifemiUnuttum.Text = "Sifremi Unuttum";
            this.link_SifemiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_SifemiUnuttum_LinkClicked);
            // 
            // Kullanici_Islemleri
            // 
            this.AcceptButton = this.button_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::İnternet_Cafe.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.link_SifemiUnuttum);
            this.Controls.Add(this.button_Giris);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_KullaniciAdi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kullanici_Islemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            this.TransparencyKey = System.Drawing.Color.BurlyWood;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_Giris;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.LinkLabel link_SifemiUnuttum;
    }
}