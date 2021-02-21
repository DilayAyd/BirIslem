using System;

namespace Bir_islem_uygulama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.giris = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.Button();
            this.Elile = new System.Windows.Forms.Button();
            this.sayı1 = new System.Windows.Forms.Label();
            this.sayi2 = new System.Windows.Forms.Label();
            this.sayi3 = new System.Windows.Forms.Label();
            this.sayi4 = new System.Windows.Forms.Label();
            this.sayi5 = new System.Windows.Forms.Label();
            this.sayi6 = new System.Windows.Forms.Label();
            this.elde = new System.Windows.Forms.Label();
            this.eldesayi = new System.Windows.Forms.TextBox();
            this.sayi1txb = new System.Windows.Forms.TextBox();
            this.sayi2txb = new System.Windows.Forms.TextBox();
            this.sayi3txb = new System.Windows.Forms.TextBox();
            this.sayi4txb = new System.Windows.Forms.TextBox();
            this.sayi5txb = new System.Windows.Forms.TextBox();
            this.sayi6txb = new System.Windows.Forms.TextBox();
            this.hesapla = new System.Windows.Forms.Button();
            this.Sonuc = new System.Windows.Forms.Label();
            this.sonuctxb = new System.Windows.Forms.TextBox();
            this.islemler = new System.Windows.Forms.Label();
            this.islemlerLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.puan = new System.Windows.Forms.Label();
            this.puantxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.AutoSize = true;
            this.giris.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris.Location = new System.Drawing.Point(56, 75);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(338, 27);
            this.giris.TabIndex = 0;
            this.giris.Text = "Sayıları nasıl girmek istersiniz?";
            this.giris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Random
            // 
            this.Random.BackColor = System.Drawing.Color.AliceBlue;
            this.Random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Random.ForeColor = System.Drawing.Color.Maroon;
            this.Random.Location = new System.Drawing.Point(467, 22);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(211, 57);
            this.Random.TabIndex = 1;
            this.Random.Text = "RASTGELE";
            this.Random.UseVisualStyleBackColor = false;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // Elile
            // 
            this.Elile.BackColor = System.Drawing.Color.AliceBlue;
            this.Elile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Elile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Elile.ForeColor = System.Drawing.Color.Maroon;
            this.Elile.Location = new System.Drawing.Point(467, 108);
            this.Elile.Name = "Elile";
            this.Elile.Size = new System.Drawing.Size(211, 57);
            this.Elile.TabIndex = 2;
            this.Elile.Text = "EL İLE";
            this.Elile.UseVisualStyleBackColor = false;
            this.Elile.Click += new System.EventHandler(this.Elile_Click);
            // 
            // sayı1
            // 
            this.sayı1.AutoSize = true;
            this.sayı1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı1.Location = new System.Drawing.Point(58, 204);
            this.sayı1.Name = "sayı1";
            this.sayı1.Size = new System.Drawing.Size(63, 20);
            this.sayı1.TabIndex = 3;
            this.sayı1.Text = "1. Sayı";
            // 
            // sayi2
            // 
            this.sayi2.AutoSize = true;
            this.sayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi2.Location = new System.Drawing.Point(58, 249);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(63, 20);
            this.sayi2.TabIndex = 4;
            this.sayi2.Text = "2. Sayı";
            // 
            // sayi3
            // 
            this.sayi3.AutoSize = true;
            this.sayi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi3.Location = new System.Drawing.Point(58, 291);
            this.sayi3.Name = "sayi3";
            this.sayi3.Size = new System.Drawing.Size(63, 20);
            this.sayi3.TabIndex = 5;
            this.sayi3.Text = "3. Sayı";
            // 
            // sayi4
            // 
            this.sayi4.AutoSize = true;
            this.sayi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi4.Location = new System.Drawing.Point(58, 331);
            this.sayi4.Name = "sayi4";
            this.sayi4.Size = new System.Drawing.Size(63, 20);
            this.sayi4.TabIndex = 6;
            this.sayi4.Text = "4. Sayı";
            // 
            // sayi5
            // 
            this.sayi5.AutoSize = true;
            this.sayi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi5.Location = new System.Drawing.Point(58, 376);
            this.sayi5.Name = "sayi5";
            this.sayi5.Size = new System.Drawing.Size(63, 20);
            this.sayi5.TabIndex = 7;
            this.sayi5.Text = "5. Sayı";
            // 
            // sayi6
            // 
            this.sayi6.AutoSize = true;
            this.sayi6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi6.Location = new System.Drawing.Point(58, 420);
            this.sayi6.Name = "sayi6";
            this.sayi6.Size = new System.Drawing.Size(63, 20);
            this.sayi6.TabIndex = 8;
            this.sayi6.Text = "6. Sayı";
            // 
            // elde
            // 
            this.elde.AutoSize = true;
            this.elde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elde.Location = new System.Drawing.Point(107, 511);
            this.elde.Name = "elde";
            this.elde.Size = new System.Drawing.Size(191, 24);
            this.elde.TabIndex = 9;
            this.elde.Text = "Elde Edilecek Sayı:";
            // 
            // eldesayi
            // 
            this.eldesayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eldesayi.Location = new System.Drawing.Point(311, 515);
            this.eldesayi.Name = "eldesayi";
            this.eldesayi.Size = new System.Drawing.Size(100, 29);
            this.eldesayi.TabIndex = 10;
            this.eldesayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sayi1txb
            // 
            this.sayi1txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi1txb.Location = new System.Drawing.Point(156, 206);
            this.sayi1txb.Name = "sayi1txb";
            this.sayi1txb.Size = new System.Drawing.Size(100, 26);
            this.sayi1txb.TabIndex = 11;
            this.sayi1txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sayi2txb
            // 
            this.sayi2txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi2txb.Location = new System.Drawing.Point(156, 251);
            this.sayi2txb.Name = "sayi2txb";
            this.sayi2txb.Size = new System.Drawing.Size(100, 26);
            this.sayi2txb.TabIndex = 12;
            this.sayi2txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sayi3txb
            // 
            this.sayi3txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi3txb.Location = new System.Drawing.Point(156, 293);
            this.sayi3txb.Name = "sayi3txb";
            this.sayi3txb.Size = new System.Drawing.Size(100, 26);
            this.sayi3txb.TabIndex = 13;
            this.sayi3txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sayi4txb
            // 
            this.sayi4txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi4txb.Location = new System.Drawing.Point(156, 333);
            this.sayi4txb.Name = "sayi4txb";
            this.sayi4txb.Size = new System.Drawing.Size(100, 26);
            this.sayi4txb.TabIndex = 14;
            this.sayi4txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sayi5txb
            // 
            this.sayi5txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi5txb.Location = new System.Drawing.Point(156, 376);
            this.sayi5txb.Name = "sayi5txb";
            this.sayi5txb.Size = new System.Drawing.Size(100, 26);
            this.sayi5txb.TabIndex = 15;
            this.sayi5txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sayi6txb
            // 
            this.sayi6txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi6txb.Location = new System.Drawing.Point(156, 422);
            this.sayi6txb.Name = "sayi6txb";
            this.sayi6txb.Size = new System.Drawing.Size(100, 26);
            this.sayi6txb.TabIndex = 16;
            this.sayi6txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hesapla
            // 
            this.hesapla.BackColor = System.Drawing.Color.AliceBlue;
            this.hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapla.ForeColor = System.Drawing.Color.Maroon;
            this.hesapla.Location = new System.Drawing.Point(251, 561);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(205, 56);
            this.hesapla.TabIndex = 17;
            this.hesapla.Text = "HESAPLA";
            this.hesapla.UseVisualStyleBackColor = false;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // Sonuc
            // 
            this.Sonuc.AutoSize = true;
            this.Sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sonuc.Location = new System.Drawing.Point(560, 212);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(118, 31);
            this.Sonuc.TabIndex = 18;
            this.Sonuc.Text = "SONUÇ";
            // 
            // sonuctxb
            // 
            this.sonuctxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuctxb.Location = new System.Drawing.Point(566, 266);
            this.sonuctxb.Name = "sonuctxb";
            this.sonuctxb.Size = new System.Drawing.Size(100, 29);
            this.sonuctxb.TabIndex = 19;
            this.sonuctxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // islemler
            // 
            this.islemler.AutoSize = true;
            this.islemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemler.Location = new System.Drawing.Point(561, 336);
            this.islemler.Name = "islemler";
            this.islemler.Size = new System.Drawing.Size(124, 25);
            this.islemler.TabIndex = 20;
            this.islemler.Text = "İŞLEMLER";
            // 
            // islemlerLbl
            // 
            this.islemlerLbl.AutoSize = true;
            this.islemlerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemlerLbl.Location = new System.Drawing.Point(581, 379);
            this.islemlerLbl.Name = "islemlerLbl";
            this.islemlerLbl.Size = new System.Drawing.Size(14, 20);
            this.islemlerLbl.TabIndex = 21;
            this.islemlerLbl.Text = " ";
            this.islemlerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(273, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "1-9 arası rakamlar girilmelidir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(273, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "1-9 arası rakamlar girilmelidir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(273, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "1-9 arası rakamlar girilmelidir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(273, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "1-9 arası rakamlar girilmelidir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(273, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "1-9 arası rakamlar girilmelidir";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(273, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "10-99 arası sayılar girilmelidir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(106, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "100-999 arası bir sayı elde edilecektir";
            // 
            // puan
            // 
            this.puan.AutoSize = true;
            this.puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan.Location = new System.Drawing.Point(561, 515);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(181, 29);
            this.puan.TabIndex = 29;
            this.puan.Text = "ALINAN PUAN";
            // 
            // puantxb
            // 
            this.puantxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puantxb.Location = new System.Drawing.Point(605, 561);
            this.puantxb.Name = "puantxb";
            this.puantxb.Size = new System.Drawing.Size(100, 35);
            this.puantxb.TabIndex = 30;
            this.puantxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.puantxb);
            this.Controls.Add(this.puan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.islemlerLbl);
            this.Controls.Add(this.islemler);
            this.Controls.Add(this.sonuctxb);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.sayi6txb);
            this.Controls.Add(this.sayi5txb);
            this.Controls.Add(this.sayi4txb);
            this.Controls.Add(this.sayi3txb);
            this.Controls.Add(this.sayi2txb);
            this.Controls.Add(this.sayi1txb);
            this.Controls.Add(this.eldesayi);
            this.Controls.Add(this.elde);
            this.Controls.Add(this.sayi6);
            this.Controls.Add(this.sayi5);
            this.Controls.Add(this.sayi4);
            this.Controls.Add(this.sayi3);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayı1);
            this.Controls.Add(this.Elile);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.giris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label giris;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button Elile;
        private System.Windows.Forms.Label sayı1;
        private System.Windows.Forms.Label sayi2;
        private System.Windows.Forms.Label sayi3;
        private System.Windows.Forms.Label sayi4;
        private System.Windows.Forms.Label sayi5;
        private System.Windows.Forms.Label sayi6;
        private System.Windows.Forms.Label elde;
        private System.Windows.Forms.TextBox eldesayi;
        private System.Windows.Forms.TextBox sayi1txb;
        private System.Windows.Forms.TextBox sayi2txb;
        private System.Windows.Forms.TextBox sayi3txb;
        private System.Windows.Forms.TextBox sayi4txb;
        private System.Windows.Forms.TextBox sayi5txb;
        private System.Windows.Forms.TextBox sayi6txb;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.TextBox sonuctxb;
        private System.Windows.Forms.Label islemler;
        private System.Windows.Forms.Label islemlerLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label puan;
        private System.Windows.Forms.TextBox puantxb;
    }
}

