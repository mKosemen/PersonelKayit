namespace PersembeDers
{
    partial class Form1
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
            this.cbBirimler = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDogumYerleri = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.tabPersonel = new System.Windows.Forms.TabControl();
            this.tabKayitEkleme = new System.Windows.Forms.TabPage();
            this.tabKayitliPersoneller = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbKayitlar = new System.Windows.Forms.ListBox();
            this.btnGeriDön = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnİleri = new System.Windows.Forms.Button();
            this.tabBirim = new System.Windows.Forms.TabPage();
            this.lbBirimdekiler = new System.Windows.Forms.ListBox();
            this.cbBirimSecimi = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabPersonel.SuspendLayout();
            this.tabKayitEkleme.SuspendLayout();
            this.tabKayitliPersoneller.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabBirim.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBirimler
            // 
            this.cbBirimler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBirimler.FormattingEnabled = true;
            this.cbBirimler.Location = new System.Drawing.Point(118, 48);
            this.cbBirimler.Name = "cbBirimler";
            this.cbBirimler.Size = new System.Drawing.Size(215, 24);
            this.cbBirimler.TabIndex = 1;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(115, 159);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(218, 22);
            this.dtpDogumTarihi.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBirimler);
            this.groupBox1.Controls.Add(this.cbDogumYerleri);
            this.groupBox1.Controls.Add(this.dtpDogumTarihi);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnGoruntule);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Controls.Add(this.rbKadin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 245);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONEL BİLGİLERİ";
            // 
            // cbDogumYerleri
            // 
            this.cbDogumYerleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDogumYerleri.FormattingEnabled = true;
            this.cbDogumYerleri.Location = new System.Drawing.Point(118, 104);
            this.cbDogumYerleri.Name = "cbDogumYerleri";
            this.cbDogumYerleri.Size = new System.Drawing.Size(215, 24);
            this.cbDogumYerleri.TabIndex = 3;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(7, 187);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 47);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(117, 187);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 47);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoruntule.Location = new System.Drawing.Point(226, 187);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(100, 47);
            this.btnGoruntule.TabIndex = 12;
            this.btnGoruntule.Text = "KAYITLARI GÖRÜNTÜLE";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "T.C No";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(118, 77);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.ShortcutsEnabled = false;
            this.txtTC.Size = new System.Drawing.Size(215, 22);
            this.txtTC.TabIndex = 2;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Doğum Yeri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cinsiyet";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(118, 21);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.ShortcutsEnabled = false;
            this.txtAdSoyad.Size = new System.Drawing.Size(215, 22);
            this.txtAdSoyad.TabIndex = 0;
            this.txtAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doğum Tarihi";
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(118, 133);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(65, 20);
            this.rbErkek.TabIndex = 4;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(190, 133);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(64, 20);
            this.rbKadin.TabIndex = 5;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // tabPersonel
            // 
            this.tabPersonel.Controls.Add(this.tabKayitEkleme);
            this.tabPersonel.Controls.Add(this.tabKayitliPersoneller);
            this.tabPersonel.Controls.Add(this.tabBirim);
            this.tabPersonel.Location = new System.Drawing.Point(12, 12);
            this.tabPersonel.Name = "tabPersonel";
            this.tabPersonel.SelectedIndex = 0;
            this.tabPersonel.Size = new System.Drawing.Size(378, 286);
            this.tabPersonel.TabIndex = 19;
            // 
            // tabKayitEkleme
            // 
            this.tabKayitEkleme.Controls.Add(this.groupBox1);
            this.tabKayitEkleme.Location = new System.Drawing.Point(4, 22);
            this.tabKayitEkleme.Name = "tabKayitEkleme";
            this.tabKayitEkleme.Padding = new System.Windows.Forms.Padding(3);
            this.tabKayitEkleme.Size = new System.Drawing.Size(370, 260);
            this.tabKayitEkleme.TabIndex = 0;
            this.tabKayitEkleme.Text = "PERSONEL KAYIT";
            this.tabKayitEkleme.UseVisualStyleBackColor = true;
            // 
            // tabKayitliPersoneller
            // 
            this.tabKayitliPersoneller.Controls.Add(this.groupBox2);
            this.tabKayitliPersoneller.Location = new System.Drawing.Point(4, 22);
            this.tabKayitliPersoneller.Name = "tabKayitliPersoneller";
            this.tabKayitliPersoneller.Padding = new System.Windows.Forms.Padding(3);
            this.tabKayitliPersoneller.Size = new System.Drawing.Size(370, 260);
            this.tabKayitliPersoneller.TabIndex = 1;
            this.tabKayitliPersoneller.Text = "PERSONEL BİLGİLERİ";
            this.tabKayitliPersoneller.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbKayitlar);
            this.groupBox2.Controls.Add(this.btnGeriDön);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnGeri);
            this.groupBox2.Controls.Add(this.btnİleri);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KAYITLAR";
            // 
            // lbKayitlar
            // 
            this.lbKayitlar.FormattingEnabled = true;
            this.lbKayitlar.ItemHeight = 15;
            this.lbKayitlar.Location = new System.Drawing.Point(12, 19);
            this.lbKayitlar.Name = "lbKayitlar";
            this.lbKayitlar.Size = new System.Drawing.Size(340, 154);
            this.lbKayitlar.TabIndex = 5;
            // 
            // btnGeriDön
            // 
            this.btnGeriDön.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDön.Location = new System.Drawing.Point(56, 211);
            this.btnGeriDön.Name = "btnGeriDön";
            this.btnGeriDön.Size = new System.Drawing.Size(237, 23);
            this.btnGeriDön.TabIndex = 4;
            this.btnGeriDön.Text = "KAYIT EKRANINA GERİ DÖN";
            this.btnGeriDön.UseVisualStyleBackColor = true;
            this.btnGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(137, 182);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "KAYDI SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Enabled = false;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(56, 182);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnİleri
            // 
            this.btnİleri.Enabled = false;
            this.btnİleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİleri.Location = new System.Drawing.Point(218, 182);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(75, 23);
            this.btnİleri.TabIndex = 2;
            this.btnİleri.Text = "İLERİ";
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // tabBirim
            // 
            this.tabBirim.Controls.Add(this.btnListele);
            this.tabBirim.Controls.Add(this.cbBirimSecimi);
            this.tabBirim.Controls.Add(this.lbBirimdekiler);
            this.tabBirim.Location = new System.Drawing.Point(4, 22);
            this.tabBirim.Name = "tabBirim";
            this.tabBirim.Size = new System.Drawing.Size(370, 260);
            this.tabBirim.TabIndex = 2;
            this.tabBirim.Text = "BİRİM BİLGİLERİ";
            this.tabBirim.UseVisualStyleBackColor = true;
            // 
            // lbBirimdekiler
            // 
            this.lbBirimdekiler.FormattingEnabled = true;
            this.lbBirimdekiler.Location = new System.Drawing.Point(15, 14);
            this.lbBirimdekiler.Name = "lbBirimdekiler";
            this.lbBirimdekiler.Size = new System.Drawing.Size(202, 238);
            this.lbBirimdekiler.TabIndex = 0;
            // 
            // cbBirimSecimi
            // 
            this.cbBirimSecimi.FormattingEnabled = true;
            this.cbBirimSecimi.Location = new System.Drawing.Point(223, 49);
            this.cbBirimSecimi.Name = "cbBirimSecimi";
            this.cbBirimSecimi.Size = new System.Drawing.Size(121, 21);
            this.cbBirimSecimi.TabIndex = 1;
            this.cbBirimSecimi.Text = "Birim Seç...";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(243, 76);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 306);
            this.Controls.Add(this.tabPersonel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPersonel.ResumeLayout(false);
            this.tabKayitEkleme.ResumeLayout(false);
            this.tabKayitliPersoneller.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabBirim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBirimler;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDogumYerleri;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.TabControl tabPersonel;
        private System.Windows.Forms.TabPage tabKayitEkleme;
        private System.Windows.Forms.TabPage tabKayitliPersoneller;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbKayitlar;
        private System.Windows.Forms.Button btnGeriDön;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.TabPage tabBirim;
        private System.Windows.Forms.ListBox lbBirimdekiler;
        private System.Windows.Forms.ComboBox cbBirimSecimi;
        private System.Windows.Forms.Button btnListele;

    }
}

