using Collections8137Demo.Enums;
using Collections8137Demo.Models.Bases;

namespace Collections8137Demo.Models
{
    public class Ogrenci : KayitBase
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public bool MezunMu { get; set; } = true;
        public double NotOrtalamasi { get; set; }

        public Ogrenci() : base()
        {
            //Id = -1; // bu yapılan doğrudur ancak kalıtımda constructor kullanımı örneği için devre dışı bırakılmıştır

            Adi = "";
            Soyadi = "";
            Cinsiyet = Cinsiyet.Erkek;
        }

        public Ogrenci(int id, string adi, string soyadi, DateTime dogumTarihi, Cinsiyet cinsiyet, bool mezunMu, double notOrtalamasi) : base(id)
        {
            //Id = id; // bu yapılan doğrudur ancak kalıtımda constructor kullanımı örneği için devre dışı bırakılmıştır

            Adi = adi;
            Soyadi = soyadi;
            DogumTarihi = dogumTarihi;
            Cinsiyet = cinsiyet;
            MezunMu = mezunMu;
            NotOrtalamasi = notOrtalamasi;
        }
    }
}
