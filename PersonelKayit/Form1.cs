using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.Data;

namespace PersembeDers
{
    public partial class Form1 : Form
    {
        int indis = -1, yas;
        string cinsiyet;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string il in sehirler)
                cbDogumYerleri.Items.Add(il);
            foreach (string birim in birimler)
                cbBirimler.Items.Add(birim);
        }
        #region Lists
        List<string> sehirler = new List<string>() { "ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AMASYA", "ANKARA", "ANTALYA", "ARTVİN", "AYDIN", "BALIKESİR", "BİLECİK", "BİNGÖL", "BİTLİS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE", "ÇANKIRI", "ÇORUM", "DENİZLİ", "DİYARBAKIR", "EDİRNE", "ELAZIĞ", "ERZİNCAN", "ERZURUM", "ESKİŞEHİR", "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE", "HAKKARİ", "HATAY", "ISPARTA", "MERSİN", "İSTANBUL", "İZMİR", "KARS", "KASTAMONU", "KAYSERİ", "KIRKLARELİ", "KIRŞEHİR", "KOCAELİ", "KONYA", "KÜTAHYA", "MALATYA", "MANİSA", "KAHRAMANMARAŞ", "MARDİN", "MUĞLA", "MUŞ", "NEVŞEHİR", "NİĞDE", "ORDU", "RİZE", "SAKARYA", "SAMSUN", "SİİRT", "SİNOP", "SİVAS", "TEKİRDAĞ", "TOKAT", "TRABZON", "TUNCELİ", "ŞANLIURFA", "UŞAK", "VAN", "YOZGAT", "ZONGULDAK", "AKSARAY", "BAYBURT", "KARAMAN", "KIRIKKALE", "BATMAN", "ŞIRNAK", "BARTIN", "ARDAHAN", "IĞDIR", "YALOVA", "KARABÜK", "KİLİS", "OSMANİYE", "DÜZCE ", "YURTDIŞI" };
        List<string> birimler = new List<string>() { "Bilgi İşlem", "İnsan Kaynakları", "AR-GE", "Dijital Pazarlama", "Müşteri Hizmetleri", "Pazarlama", "Kalite Kontrol", "Lojistik", "Satın Alma", "Muhasebe" };
        List<Personel> personelBilgileri = new List<Personel>();
        #endregion
        #region Methods
        private string Cinsiyet()
        {
            string cinsiyet;
            if (rbErkek.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet = "Kadın";
            }
            return cinsiyet;
        }
        private int YasHesapla(string tarih)
        {
            int yas;
            DateTime dogumtarihi;
            dogumtarihi = Convert.ToDateTime(dtpDogumTarihi.Text);
            yas = Convert.ToInt32(DateTime.Now.Year - dogumtarihi.Year);
            return yas;
        }
        private void ListBoxaAktar(int indisSayisi)
        {
            if (lbKayitlar.Items.Count != 0)
                lbKayitlar.Items.Clear();

            foreach (var bilgi in personelBilgileri[indisSayisi].GetType().GetProperties())
            {
                if (bilgi.Name == "DogumTarihi" || bilgi.Name == "IseGirisTarihi")
                    lbKayitlar.Items.Add(Convert.ToDateTime(bilgi.GetValue(personelBilgileri[indisSayisi])).ToString("D"));
                else
                    lbKayitlar.Items.Add(bilgi.GetValue(personelBilgileri[indisSayisi]));
            }
            lblSayim.Text = (indisSayisi + 1).ToString();
        }
        private void ButonKontrolleri()
        {
            if (indis > 0)
                btnGeri.Enabled = true;
            else
                btnGeri.Enabled = false;
            if (personelBilgileri.Count > indis + 1)
                btnİleri.Enabled = true;
            else
                btnİleri.Enabled = false;
            if (personelBilgileri.Count > 1)
                btnSil.Enabled = true;
            else
                btnSil.Enabled = false;
        }
        private bool TCKontrol()
        {
            foreach (Personel personel in personelBilgileri)
            {
                if (personel.TcKimlikNo == txtTC.Text)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
        #region Clicks
        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            tabPersonel.SelectedIndex = 0;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = cbBirimler.Text = cbDogumYerleri.Text = txtTC.Text = "";
            rbErkek.Checked = rbKadin.Checked = false;
            dtpDogumTarihi.Value = DateTime.Today;
        }
        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            tabPersonel.SelectedIndex = 1;
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (indis > 0)
            {
                indis--;
                ListBoxaAktar(indis);
            }
            ButonKontrolleri();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (personelBilgileri.Count == indis + 1)
            {
                personelBilgileri.RemoveAt(indis);
                indis--;
            }
            else
            {
                personelBilgileri.RemoveAt(indis);
            }
            ListBoxaAktar(indis);
            ButonKontrolleri();
        }
        private void btnİleri_Click(object sender, EventArgs e)
        {
            if (personelBilgileri.Count > indis)
            {
                indis++;
                ListBoxaAktar(indis);
            }
            ButonKontrolleri();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            yas = YasHesapla(dtpDogumTarihi.Text);
            cinsiyet = Cinsiyet();
            if (((txtAdSoyad.Text).Trim()).Contains(" ") == false)
            {
                MessageBox.Show("Ad Soyad bilgisini eksik girdiniz. Lütfen tam isminizi giriniz.");
            }
            else if (rbErkek.Checked != true && rbKadin.Checked != true)
            {
                MessageBox.Show("Cinsiyet seçilmeden devam edemezsiniz.");
            }
            else if (txtTC.Text.Length != 11)
            {
                MessageBox.Show("Türkiye Cumhuriyeti kimlik numaraları 11 hanelidir lütfen kontrol edip tekrar deneyiniz.");
            }
            else if (cbBirimler.Text == "")
            {
                MessageBox.Show("Birim bilgisi boş bırakılamaz");
            }
            else if (cbDogumYerleri.Text == "")
            {
                MessageBox.Show("Doğum yeri bilgisi boş bırakılamaz");
            }
            else if (dtpDogumTarihi.Value > DateTime.Now)
            {
                MessageBox.Show("Doğum tarihi günümüzden daha ileri bir tarih olarak seçildi. Lütfen tekrar kontrol ediniz.");
            }
            else if (yas <= 18)
            {
                MessageBox.Show("Çocuk işçi çalıştırmak suçtur. Lütfen girdiğiniz bilgileri kontrol edip tekrar deneyiniz.");
            }
            else if (yas >= 65)
            {
                MessageBox.Show("Şirket politikası gereği 65 yaş üstü personel çalıştırmıyoruz.");
            }
            else if (dtpKayitTarihi.Value > DateTime.Now)
            {
                MessageBox.Show("İleri tarih için tarih seçimi yapamazsınız.");
            }
            else if (dtpKayitTarihi.Value < dtpDogumTarihi.Value)
            {
                MessageBox.Show("Girmek istediğiniz tarihtre personel henüz doğmamış olarak gözükmektedir. Lütfen kontrol edip tekrar deneyiniz.");
            }
            else if ((dtpKayitTarihi.Value.Year) - (dtpDogumTarihi.Value.Year) < 18)
            {
                MessageBox.Show("Şirket prensibi gereği 18 yaş altında personel çalıştırılmamaktadır. Girmek istediğiniz işe giriş tarihi bu prensibe aykırıdır. Lütfen tekrar kontrol ediniz.");
            }
            else
            {
                if (TCKontrol() == false)
                {
                    MessageBox.Show("TC kimlik numarası kişiye özeldir. Lütfen kontrol ediniz.");
                }
                else
                {
                    indis++;
                    Personel yeniPersonel = new Personel()
                    {
                        AdSoyad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAdSoyad.Text.Trim()),
                        TcKimlikNo = txtTC.Text,
                        Cinsiyet = cinsiyet,
                        Birim = cbBirimler.Text,
                        DogumYeri = cbDogumYerleri.Text,
                        DogumTarihi = dtpDogumTarihi.Value,
                        IseGirisTarihi = dtpKayitTarihi.Value
                    };
                    personelBilgileri.Add(yeniPersonel);
                    ListBoxaAktar(indis);
                    ButonKontrolleri();
                    dgwListele.DataSource = personelBilgileri.ToList();
                    MessageBox.Show("Kayıt eklendi.");
                }
            }
        }
        #endregion
        #region KeyPress
        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        #endregion

    }
}
