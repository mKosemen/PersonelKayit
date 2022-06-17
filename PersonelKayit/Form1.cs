using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
namespace PersembeDers
{
    public partial class Form1 : Form
    {
        int indis = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string il in sehirler)
            {
                cbDogumYerleri.Items.Add(il);
            }
            foreach (string birim in birimler)
            {
                cbBirimler.Items.Add(birim);
            }
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

            foreach (var item in personelBilgileri[indisSayisi].GetType().GetProperties())
            {
                if (item.Name == "DogumTarihi")
                    lbKayitlar.Items.Add(Convert.ToDateTime(item.GetValue(personelBilgileri[indisSayisi])).ToString("D"));
                else
                    lbKayitlar.Items.Add(item.GetValue(personelBilgileri[indisSayisi]));
            }
        }
        private void ButonKontrolleri()
        {
            if (indis - 1 > 0)
                btnGeri.Enabled = true;
            else
                btnGeri.Enabled = false;

            if (personelBilgileri.Count > indis)
                btnİleri.Enabled = true;
            else
                btnİleri.Enabled = false;
        }
        private void TCKontrol()
        {
            foreach (Personel personel in personelBilgileri)
            {
                if (personel.TcKimlikNo == txtTC.Text)
                {
                    MessageBox.Show("TC kimlik numarası kişiye özeldir. Lütfen kontrol ediniz.");
                    return;
                }
            }
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
            if (personelBilgileri.Count == indis)
            {
                personelBilgileri.RemoveAt(indis);
                indis--;
            }
            else
            {
                personelBilgileri.RemoveAt(indis);
            }
            ListBoxaAktar(indis);
            if (personelBilgileri.Count == 1)
                btnSil.Enabled = false;
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
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int yas;
            string cinsiyet;
            yas = YasHesapla(dtpDogumTarihi.Text);
            cinsiyet = Cinsiyet();
            if (rbErkek.Checked != true && rbKadin.Checked != true)
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
            else if (yas <= 18)
            {
                MessageBox.Show("Çocuk işçi çalıştırmak suçtur. Lütfen girdiğiniz bilgileri kontrol edip tekrar deneyiniz.");
            }
            else
            {
                TCKontrol();
                Personel yeniPersonel = new Personel()
                {
                    AdSoyad = txtAdSoyad.Text,
                    TcKimlikNo = txtTC.Text,
                    Cinsiyet = cinsiyet,
                    Birim = cbBirimler.Text,
                    DogumYeri = cbDogumYerleri.Text,
                    DogumTarihi = dtpDogumTarihi.Value
                };
                personelBilgileri.Add(yeniPersonel);
                ListBoxaAktar(indis);
                ButonKontrolleri();
                MessageBox.Show("Kayıt eklendi.");
                indis++;
            }
        }


    }
}
