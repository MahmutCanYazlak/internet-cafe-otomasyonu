
namespace İnternet_Cafe
{
    partial class SatislariListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_GeriAl = new System.Windows.Forms.Button();
            this.SatisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcilisTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslangicSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SatisID,
            this.KullaniciID,
            this.MasaID,
            this.AcilisTuru,
            this.BaslangicSaati,
            this.BitisSaati,
            this.Sure,
            this.Tutar,
            this.Aciklama,
            this.Tarih});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_GeriAl
            // 
            this.button_GeriAl.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_GeriAl.Enabled = false;
            this.button_GeriAl.Location = new System.Drawing.Point(774, 345);
            this.button_GeriAl.Name = "button_GeriAl";
            this.button_GeriAl.Size = new System.Drawing.Size(131, 70);
            this.button_GeriAl.TabIndex = 1;
            this.button_GeriAl.Text = "İşlemi Geri Al";
            this.button_GeriAl.UseVisualStyleBackColor = true;
            this.button_GeriAl.Click += new System.EventHandler(this.button_GeriAl_Click);
            // 
            // SatisID
            // 
            this.SatisID.DataPropertyName = "SatisID";
            this.SatisID.HeaderText = "Satış ID";
            this.SatisID.Name = "SatisID";
            // 
            // KullaniciID
            // 
            this.KullaniciID.DataPropertyName = "KullaniciID";
            this.KullaniciID.HeaderText = "Kullanıcı ID";
            this.KullaniciID.Name = "KullaniciID";
            // 
            // MasaID
            // 
            this.MasaID.DataPropertyName = "MasaID";
            this.MasaID.HeaderText = "Masa ID";
            this.MasaID.Name = "MasaID";
            // 
            // AcilisTuru
            // 
            this.AcilisTuru.DataPropertyName = "AcilisTuru";
            this.AcilisTuru.HeaderText = "Açılış Türü";
            this.AcilisTuru.Name = "AcilisTuru";
            // 
            // BaslangicSaati
            // 
            this.BaslangicSaati.DataPropertyName = "BaslangicSaati";
            this.BaslangicSaati.HeaderText = "Başlama Saati";
            this.BaslangicSaati.Name = "BaslangicSaati";
            // 
            // BitisSaati
            // 
            this.BitisSaati.DataPropertyName = "BitisSaati";
            this.BitisSaati.HeaderText = "Bitiş Saati";
            this.BitisSaati.Name = "BitisSaati";
            // 
            // Sure
            // 
            this.Sure.DataPropertyName = "Sure";
            this.Sure.HeaderText = "Süre";
            this.Sure.Name = "Sure";
            // 
            // Tutar
            // 
            this.Tutar.DataPropertyName = "Tutar";
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.Name = "Tutar";
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            // 
            // SatislariListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 415);
            this.Controls.Add(this.button_GeriAl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SatislariListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışları Listele";
            this.Load += new System.EventHandler(this.SatislariListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button_GeriAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcilisTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslangicSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
    }
}