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
            this.tabBirim = new System.Windows.Forms.TabPage();
            this.dgwListele = new System.Windows.Forms.DataGridView();
            this.tabKayitliPersoneller = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSayim = new System.Windows.Forms.Label();
            this.lblGoruntulenenKayit = new System.Windows.Forms.Label();
            this.lbKayitlar = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeriDön = new System.Windows.Forms.Button();
            this.btnİleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.tabKayitEkleme = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblIseGiris = new System.Windows.Forms.Label();
            this.cbBirimler = new System.Windows.Forms.ComboBox();
            this.cbDogumYerleri = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.tabPersonel = new System.Windows.Forms.TabControl();
            this.tabBirim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListele)).BeginInit();
            this.tabKayitliPersoneller.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabKayitEkleme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBirim
            // 
            this.tabBirim.BackColor = System.Drawing.Color.PeachPuff;
            this.tabBirim.Controls.Add(this.dgwListele);
            this.tabBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabBirim.Location = new System.Drawing.Point(4, 22);
            this.tabBirim.Name = "tabBirim";
            this.tabBirim.Size = new System.Drawing.Size(607, 260);
            this.tabBirim.TabIndex = 2;
            this.tabBirim.Text = "ŞİRKET PERSONELLERİ";
            // 
            // dgwListele
            // 
            this.dgwListele.AllowUserToDeleteRows = false;
            this.dgwListele.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgwListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListele.GridColor = System.Drawing.Color.LightBlue;
            this.dgwListele.Location = new System.Drawing.Point(3, 0);
            this.dgwListele.Name = "dgwListele";
            this.dgwListele.ReadOnly = true;
            this.dgwListele.Size = new System.Drawing.Size(601, 251);
            this.dgwListele.TabIndex = 3;
            // 
            // tabKayitliPersoneller
            // 
            this.tabKayitliPersoneller.BackColor = System.Drawing.Color.CadetBlue;
            this.tabKayitliPersoneller.Controls.Add(this.groupBox2);
            this.tabKayitliPersoneller.Controls.Add(this.btnSil);
            this.tabKayitliPersoneller.Controls.Add(this.btnGeriDön);
            this.tabKayitliPersoneller.Controls.Add(this.btnİleri);
            this.tabKayitliPersoneller.Controls.Add(this.btnGeri);
            this.tabKayitliPersoneller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabKayitliPersoneller.Location = new System.Drawing.Point(4, 22);
            this.tabKayitliPersoneller.Name = "tabKayitliPersoneller";
            this.tabKayitliPersoneller.Padding = new System.Windows.Forms.Padding(3);
            this.tabKayitliPersoneller.Size = new System.Drawing.Size(607, 260);
            this.tabKayitliPersoneller.TabIndex = 1;
            this.tabKayitliPersoneller.Text = "PERSONEL BİLGİLERİ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSayim);
            this.groupBox2.Controls.Add(this.lblGoruntulenenKayit);
            this.groupBox2.Controls.Add(this.lbKayitlar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(101, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KAYITLAR";
            // 
            // lblSayim
            // 
            this.lblSayim.AutoSize = true;
            this.lblSayim.Location = new System.Drawing.Point(168, 217);
            this.lblSayim.Name = "lblSayim";
            this.lblSayim.Size = new System.Drawing.Size(0, 15);
            this.lblSayim.TabIndex = 7;
            // 
            // lblGoruntulenenKayit
            // 
            this.lblGoruntulenenKayit.AutoSize = true;
            this.lblGoruntulenenKayit.Location = new System.Drawing.Point(6, 216);
            this.lblGoruntulenenKayit.Name = "lblGoruntulenenKayit";
            this.lblGoruntulenenKayit.Size = new System.Drawing.Size(141, 15);
            this.lblGoruntulenenKayit.TabIndex = 6;
            this.lblGoruntulenenKayit.Text = "Görüntülenen Kayıt : ";
            // 
            // lbKayitlar
            // 
            this.lbKayitlar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbKayitlar.FormattingEnabled = true;
            this.lbKayitlar.ItemHeight = 15;
            this.lbKayitlar.Location = new System.Drawing.Point(9, 20);
            this.lbKayitlar.Name = "lbKayitlar";
            this.lbKayitlar.Size = new System.Drawing.Size(485, 184);
            this.lbKayitlar.TabIndex = 5;
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::PersonelKayit.Properties.Resources.delete;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(3, 180);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(72, 47);
            this.btnSil.TabIndex = 3;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeriDön
            // 
            this.btnGeriDön.BackgroundImage = global::PersonelKayit.Properties.Resources.BackPage;
            this.btnGeriDön.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDön.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDön.Location = new System.Drawing.Point(3, 21);
            this.btnGeriDön.Name = "btnGeriDön";
            this.btnGeriDön.Size = new System.Drawing.Size(72, 47);
            this.btnGeriDön.TabIndex = 4;
            this.btnGeriDön.UseVisualStyleBackColor = true;
            this.btnGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // btnİleri
            // 
            this.btnİleri.BackgroundImage = global::PersonelKayit.Properties.Resources.İleri;
            this.btnİleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnİleri.Enabled = false;
            this.btnİleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİleri.Location = new System.Drawing.Point(3, 127);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(72, 47);
            this.btnİleri.TabIndex = 2;
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = global::PersonelKayit.Properties.Resources.Geri;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Enabled = false;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(3, 74);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(72, 47);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // tabKayitEkleme
            // 
            this.tabKayitEkleme.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabKayitEkleme.Controls.Add(this.groupBox1);
            this.tabKayitEkleme.Controls.Add(this.btnTemizle);
            this.tabKayitEkleme.Controls.Add(this.btnKaydet);
            this.tabKayitEkleme.Controls.Add(this.btnGoruntule);
            this.tabKayitEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabKayitEkleme.Location = new System.Drawing.Point(4, 22);
            this.tabKayitEkleme.Name = "tabKayitEkleme";
            this.tabKayitEkleme.Padding = new System.Windows.Forms.Padding(3);
            this.tabKayitEkleme.Size = new System.Drawing.Size(607, 260);
            this.tabKayitEkleme.TabIndex = 0;
            this.tabKayitEkleme.Text = "PERSONEL KAYIT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpKayitTarihi);
            this.groupBox1.Controls.Add(this.lblIseGiris);
            this.groupBox1.Controls.Add(this.cbBirimler);
            this.groupBox1.Controls.Add(this.cbDogumYerleri);
            this.groupBox1.Controls.Add(this.dtpDogumTarihi);
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
            this.groupBox1.Size = new System.Drawing.Size(393, 245);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONEL BİLGİLERİ";
            // 
            // dtpKayitTarihi
            // 
            this.dtpKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKayitTarihi.Location = new System.Drawing.Point(134, 196);
            this.dtpKayitTarihi.Name = "dtpKayitTarihi";
            this.dtpKayitTarihi.Size = new System.Drawing.Size(218, 22);
            this.dtpKayitTarihi.TabIndex = 8;
            // 
            // lblIseGiris
            // 
            this.lblIseGiris.AutoSize = true;
            this.lblIseGiris.Location = new System.Drawing.Point(6, 199);
            this.lblIseGiris.Name = "lblIseGiris";
            this.lblIseGiris.Size = new System.Drawing.Size(108, 16);
            this.lblIseGiris.TabIndex = 7;
            this.lblIseGiris.Text = "İşe Giriş Tarihi";
            // 
            // cbBirimler
            // 
            this.cbBirimler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBirimler.FormattingEnabled = true;
            this.cbBirimler.Location = new System.Drawing.Point(137, 48);
            this.cbBirimler.Name = "cbBirimler";
            this.cbBirimler.Size = new System.Drawing.Size(215, 24);
            this.cbBirimler.TabIndex = 1;
            // 
            // cbDogumYerleri
            // 
            this.cbDogumYerleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDogumYerleri.FormattingEnabled = true;
            this.cbDogumYerleri.Location = new System.Drawing.Point(137, 104);
            this.cbDogumYerleri.Name = "cbDogumYerleri";
            this.cbDogumYerleri.Size = new System.Drawing.Size(215, 24);
            this.cbDogumYerleri.TabIndex = 3;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(134, 159);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(218, 22);
            this.dtpDogumTarihi.TabIndex = 6;
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
            this.txtTC.Location = new System.Drawing.Point(137, 77);
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
            this.txtAdSoyad.Location = new System.Drawing.Point(137, 21);
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
            this.rbErkek.Location = new System.Drawing.Point(137, 133);
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
            this.rbKadin.Location = new System.Drawing.Point(209, 133);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(64, 20);
            this.rbKadin.TabIndex = 5;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::PersonelKayit.Properties.Resources.Clean;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(405, 27);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 60);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::PersonelKayit.Properties.Resources.Save;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(405, 99);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 60);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackgroundImage = global::PersonelKayit.Properties.Resources.Listele;
            this.btnGoruntule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoruntule.Location = new System.Drawing.Point(405, 176);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(75, 60);
            this.btnGoruntule.TabIndex = 12;
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // tabPersonel
            // 
            this.tabPersonel.Controls.Add(this.tabKayitEkleme);
            this.tabPersonel.Controls.Add(this.tabKayitliPersoneller);
            this.tabPersonel.Controls.Add(this.tabBirim);
            this.tabPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPersonel.Location = new System.Drawing.Point(12, 12);
            this.tabPersonel.Name = "tabPersonel";
            this.tabPersonel.SelectedIndex = 0;
            this.tabPersonel.Size = new System.Drawing.Size(615, 286);
            this.tabPersonel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(654, 306);
            this.Controls.Add(this.tabPersonel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabBirim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListele)).EndInit();
            this.tabKayitliPersoneller.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabKayitEkleme.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPersonel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabBirim;
        private System.Windows.Forms.TabPage tabKayitliPersoneller;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSayim;
        private System.Windows.Forms.Label lblGoruntulenenKayit;
        private System.Windows.Forms.ListBox lbKayitlar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeriDön;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TabPage tabKayitEkleme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpKayitTarihi;
        private System.Windows.Forms.Label lblIseGiris;
        private System.Windows.Forms.ComboBox cbBirimler;
        private System.Windows.Forms.ComboBox cbDogumYerleri;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
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
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.TabControl tabPersonel;
        private System.Windows.Forms.DataGridView dgwListele;
    }
}

