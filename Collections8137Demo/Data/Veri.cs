using Collections8137Demo.Enums;
using Collections8137Demo.Models;

namespace Collections8137Demo.Data
{
    public static class Veri
    {
        public static List<Ogrenci> Ogrenciler { get; set; } //= new List<Ogrenci>() { // ... Ogrenci tipinde objeler }; // Ogrenciler constructor'da da new'lenebilir

        static Veri()
        {
            Ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci()
                {
                    Adi = "Çağıl",
                    Soyadi = "Alsaç",
                    Cinsiyet = Cinsiyet.Erkek,
                    DogumTarihi = new DateTime(1980, 1, 1),
                    Id = 1,
                    NotOrtalamasi = 3.5
                },
                new Ogrenci(2, "Leo", "Alsaç", DateTime.Parse("01.05.2014"), Cinsiyet.Erkek, false, 1.5)
            };
        }
    }
}
