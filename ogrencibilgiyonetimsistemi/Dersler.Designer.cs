namespace ogrencibilgiyonetimsistemi
{
    partial class Dersler
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
            this.btnOgrenciler = new System.Windows.Forms.Button();
            this.btnDersler = new System.Windows.Forms.Button();
            this.btnOgretmen = new System.Windows.Forms.Button();
            this.btnNotlar = new System.Windows.Forms.Button();
            this.btnVeriGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.tbOgretmenid = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnveriKaydet = new System.Windows.Forms.Button();
            this.btnVeriGoster = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnogrenciid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnogrenciad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnOgrenciler
            // 
            this.btnOgrenciler.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOgrenciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOgrenciler.Location = new System.Drawing.Point(25, 30);
            this.btnOgrenciler.Name = "btnOgrenciler";
            this.btnOgrenciler.Size = new System.Drawing.Size(184, 35);
            this.btnOgrenciler.TabIndex = 47;
            this.btnOgrenciler.Text = "Öğrenciler";
            this.btnOgrenciler.UseVisualStyleBackColor = false;
            this.btnOgrenciler.Click += new System.EventHandler(this.btnOgrenciler_Click);
            // 
            // btnDersler
            // 
            this.btnDersler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDersler.Location = new System.Drawing.Point(432, 30);
            this.btnDersler.Name = "btnDersler";
            this.btnDersler.Size = new System.Drawing.Size(184, 35);
            this.btnDersler.TabIndex = 46;
            this.btnDersler.Text = "Dersler";
            this.btnDersler.UseVisualStyleBackColor = false;
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOgretmen.Location = new System.Drawing.Point(229, 30);
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.Size = new System.Drawing.Size(184, 35);
            this.btnOgretmen.TabIndex = 45;
            this.btnOgretmen.Text = "Öğretmenler";
            this.btnOgretmen.UseVisualStyleBackColor = false;
            this.btnOgretmen.Click += new System.EventHandler(this.btnOgretmen_Click);
            // 
            // btnNotlar
            // 
            this.btnNotlar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotlar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNotlar.Location = new System.Drawing.Point(639, 30);
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.Size = new System.Drawing.Size(184, 35);
            this.btnNotlar.TabIndex = 44;
            this.btnNotlar.Text = "Notlar";
            this.btnNotlar.UseVisualStyleBackColor = false;
            this.btnNotlar.Click += new System.EventHandler(this.btnNotlar_Click);
            // 
            // btnVeriGuncelle
            // 
            this.btnVeriGuncelle.BackColor = System.Drawing.SystemColors.Info;
            this.btnVeriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriGuncelle.Location = new System.Drawing.Point(432, 276);
            this.btnVeriGuncelle.Name = "btnVeriGuncelle";
            this.btnVeriGuncelle.Size = new System.Drawing.Size(184, 35);
            this.btnVeriGuncelle.TabIndex = 43;
            this.btnVeriGuncelle.Text = "Verileri Güncelle";
            this.btnVeriGuncelle.UseVisualStyleBackColor = false;
            this.btnVeriGuncelle.Click += new System.EventHandler(this.btnVeriGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Info;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(229, 276);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(184, 35);
            this.btnSil.TabIndex = 42;
            this.btnSil.Text = "Verileri Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tbOgretmenid
            // 
            this.tbOgretmenid.Location = new System.Drawing.Point(109, 218);
            this.tbOgretmenid.Name = "tbOgretmenid";
            this.tbOgretmenid.Size = new System.Drawing.Size(100, 20);
            this.tbOgretmenid.TabIndex = 40;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(109, 176);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(100, 20);
            this.tbAd.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "OGRETMEN ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "DERS ADI:";
            // 
            // btnveriKaydet
            // 
            this.btnveriKaydet.BackColor = System.Drawing.SystemColors.Info;
            this.btnveriKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnveriKaydet.Location = new System.Drawing.Point(25, 276);
            this.btnveriKaydet.Name = "btnveriKaydet";
            this.btnveriKaydet.Size = new System.Drawing.Size(184, 35);
            this.btnveriKaydet.TabIndex = 35;
            this.btnveriKaydet.Text = "Verileri Kaydet";
            this.btnveriKaydet.UseVisualStyleBackColor = false;
            this.btnveriKaydet.Click += new System.EventHandler(this.btnveriKaydet_Click);
            // 
            // btnVeriGoster
            // 
            this.btnVeriGoster.BackColor = System.Drawing.SystemColors.Info;
            this.btnVeriGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriGoster.Location = new System.Drawing.Point(639, 276);
            this.btnVeriGoster.Name = "btnVeriGoster";
            this.btnVeriGoster.Size = new System.Drawing.Size(184, 35);
            this.btnVeriGoster.TabIndex = 34;
            this.btnVeriGoster.Text = "Verileri Göster";
            this.btnVeriGoster.UseVisualStyleBackColor = false;
            this.btnVeriGoster.Click += new System.EventHandler(this.btnVeriGoster_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnogrenciid,
            this.columnogrenciad,
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(25, 334);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(798, 198);
            this.listView1.TabIndex = 33;
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
            this.columnogrenciad.Text = "Ders Adı";
            this.columnogrenciad.Width = 139;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Öğretmen ID";
            this.columnHeader1.Width = 126;
            // 
            // Dersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 563);
            this.Controls.Add(this.btnOgrenciler);
            this.Controls.Add(this.btnDersler);
            this.Controls.Add(this.btnOgretmen);
            this.Controls.Add(this.btnNotlar);
            this.Controls.Add(this.btnVeriGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.tbOgretmenid);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnveriKaydet);
            this.Controls.Add(this.btnVeriGoster);
            this.Controls.Add(this.listView1);
            this.Name = "Dersler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dersler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dersler_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciler;
        private System.Windows.Forms.Button btnDersler;
        private System.Windows.Forms.Button btnOgretmen;
        private System.Windows.Forms.Button btnNotlar;
        private System.Windows.Forms.Button btnVeriGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox tbOgretmenid;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnveriKaydet;
        private System.Windows.Forms.Button btnVeriGoster;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnogrenciid;
        private System.Windows.Forms.ColumnHeader columnogrenciad;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}