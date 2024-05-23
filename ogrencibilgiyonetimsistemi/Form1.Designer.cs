namespace ogrencibilgiyonetimsistemi
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnogrenciid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnogrenciad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnogrencisoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnogrenciadres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnogrencitel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVeriGoster = new System.Windows.Forms.Button();
            this.btnveriKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVeriGuncelle = new System.Windows.Forms.Button();
            this.btnDersler = new System.Windows.Forms.Button();
            this.btnOgretmen = new System.Windows.Forms.Button();
            this.btnNotlar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnogrenciid,
            this.columnogrenciad,
            this.columnogrencisoyad,
            this.columnogrenciadres,
            this.columnogrencitel});
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(21, 334);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(798, 198);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnogrenciid
            // 
            this.columnogrenciid.Text = "ID";
            this.columnogrenciid.Width = 85;
            // 
            // columnogrenciad
            // 
            this.columnogrenciad.Text = "Ad";
            this.columnogrenciad.Width = 96;
            // 
            // columnogrencisoyad
            // 
            this.columnogrencisoyad.Text = "Soyad";
            this.columnogrencisoyad.Width = 111;
            // 
            // columnogrenciadres
            // 
            this.columnogrenciadres.Text = "Adres";
            this.columnogrenciadres.Width = 124;
            // 
            // columnogrencitel
            // 
            this.columnogrencitel.Text = "Telefon";
            this.columnogrencitel.Width = 133;
            // 
            // btnVeriGoster
            // 
            this.btnVeriGoster.BackColor = System.Drawing.SystemColors.Info;
            this.btnVeriGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriGoster.Location = new System.Drawing.Point(635, 276);
            this.btnVeriGoster.Name = "btnVeriGoster";
            this.btnVeriGoster.Size = new System.Drawing.Size(184, 35);
            this.btnVeriGoster.TabIndex = 1;
            this.btnVeriGoster.Text = "Verileri Göster";
            this.btnVeriGoster.UseVisualStyleBackColor = false;
            this.btnVeriGoster.Click += new System.EventHandler(this.btnVeriGoster_Click);
            // 
            // btnveriKaydet
            // 
            this.btnveriKaydet.BackColor = System.Drawing.SystemColors.Info;
            this.btnveriKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnveriKaydet.Location = new System.Drawing.Point(21, 276);
            this.btnveriKaydet.Name = "btnveriKaydet";
            this.btnveriKaydet.Size = new System.Drawing.Size(184, 35);
            this.btnveriKaydet.TabIndex = 2;
            this.btnveriKaydet.Text = "Verileri Kaydet";
            this.btnveriKaydet.UseVisualStyleBackColor = false;
            this.btnveriKaydet.Click += new System.EventHandler(this.btnveriKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SOYAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ADRES:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TELEFON:";
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(94, 117);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(100, 20);
            this.tbAd.TabIndex = 7;
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(94, 159);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbSoyad.TabIndex = 8;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(94, 195);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(100, 20);
            this.tbAdres.TabIndex = 9;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(94, 232);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbTelefon.TabIndex = 10;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Info;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(225, 276);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(184, 35);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Verileri Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVeriGuncelle
            // 
            this.btnVeriGuncelle.BackColor = System.Drawing.SystemColors.Info;
            this.btnVeriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriGuncelle.Location = new System.Drawing.Point(428, 276);
            this.btnVeriGuncelle.Name = "btnVeriGuncelle";
            this.btnVeriGuncelle.Size = new System.Drawing.Size(184, 35);
            this.btnVeriGuncelle.TabIndex = 12;
            this.btnVeriGuncelle.Text = "Verileri Güncelle";
            this.btnVeriGuncelle.UseVisualStyleBackColor = false;
            this.btnVeriGuncelle.Click += new System.EventHandler(this.btnVeriGuncelle_Click);
            // 
            // btnDersler
            // 
            this.btnDersler.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDersler.Location = new System.Drawing.Point(428, 30);
            this.btnDersler.Name = "btnDersler";
            this.btnDersler.Size = new System.Drawing.Size(184, 35);
            this.btnDersler.TabIndex = 15;
            this.btnDersler.Text = "Dersler";
            this.btnDersler.UseVisualStyleBackColor = false;
            this.btnDersler.Click += new System.EventHandler(this.btnDersler_Click);
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOgretmen.Location = new System.Drawing.Point(225, 30);
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.Size = new System.Drawing.Size(184, 35);
            this.btnOgretmen.TabIndex = 14;
            this.btnOgretmen.Text = "Öğretmenler";
            this.btnOgretmen.UseVisualStyleBackColor = false;
            this.btnOgretmen.Click += new System.EventHandler(this.btnOgretmen_Click);
            // 
            // btnNotlar
            // 
            this.btnNotlar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotlar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNotlar.Location = new System.Drawing.Point(635, 30);
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.Size = new System.Drawing.Size(184, 35);
            this.btnNotlar.TabIndex = 13;
            this.btnNotlar.Text = "Notlar";
            this.btnNotlar.UseVisualStyleBackColor = false;
            this.btnNotlar.Click += new System.EventHandler(this.btnNotlar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(21, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Öğrenciler";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDersler);
            this.Controls.Add(this.btnOgretmen);
            this.Controls.Add(this.btnNotlar);
            this.Controls.Add(this.btnVeriGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnveriKaydet);
            this.Controls.Add(this.btnVeriGoster);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnogrenciid;
        private System.Windows.Forms.ColumnHeader columnogrenciad;
        private System.Windows.Forms.ColumnHeader columnogrencisoyad;
        private System.Windows.Forms.ColumnHeader columnogrenciadres;
        private System.Windows.Forms.ColumnHeader columnogrencitel;
        private System.Windows.Forms.Button btnVeriGoster;
        private System.Windows.Forms.Button btnveriKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVeriGuncelle;
        private System.Windows.Forms.Button btnDersler;
        private System.Windows.Forms.Button btnOgretmen;
        private System.Windows.Forms.Button btnNotlar;
        private System.Windows.Forms.Button button1;
    }
}

