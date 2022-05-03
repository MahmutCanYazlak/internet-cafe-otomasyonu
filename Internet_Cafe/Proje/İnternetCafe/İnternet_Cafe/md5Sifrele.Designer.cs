
namespace İnternet_Cafe
{
    partial class md5Sifrele
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NormalSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_Md5Sifre = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifre:";
            // 
            // textBox_NormalSifre
            // 
            this.textBox_NormalSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_NormalSifre.Location = new System.Drawing.Point(114, 42);
            this.textBox_NormalSifre.Name = "textBox_NormalSifre";
            this.textBox_NormalSifre.Size = new System.Drawing.Size(171, 23);
            this.textBox_NormalSifre.TabIndex = 1;
            this.textBox_NormalSifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "MD5:";
            // 
            // richTextBox_Md5Sifre
            // 
            this.richTextBox_Md5Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_Md5Sifre.Location = new System.Drawing.Point(114, 125);
            this.richTextBox_Md5Sifre.Name = "richTextBox_Md5Sifre";
            this.richTextBox_Md5Sifre.Size = new System.Drawing.Size(171, 109);
            this.richTextBox_Md5Sifre.TabIndex = 3;
            this.richTextBox_Md5Sifre.Text = "";
            // 
            // md5Sifrele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 319);
            this.Controls.Add(this.richTextBox_Md5Sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NormalSifre);
            this.Controls.Add(this.label1);
            this.Name = "md5Sifrele";
            this.Text = "MD5 Şifreleme Formu";
            this.Load += new System.EventHandler(this.md5Sifrele_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NormalSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_Md5Sifre;
    }
}