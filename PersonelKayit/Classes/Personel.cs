using System;

namespace PersembeDers
{
    public class Personel
    {
        //public int Id { get; set; } 
        public string AdSoyad { get; set; }
        public string TcKimlikNo { get; set; }
        public string Cinsiyet { get; set; }
        public string Birim { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Yas { get => DateTime.Now.Year - this.DogumTarihi.Year; }
    }
}
