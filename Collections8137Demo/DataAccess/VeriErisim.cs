using Collections8137Demo.Data;
using Collections8137Demo.Models;

namespace Collections8137Demo.DataAccess
{
    public class VeriErisim
    {
        // CRUD: Create, Read, Update, Delete
        public void Ekle(Ogrenci ogrenci)
        {
            Veri.Ogrenciler.Add(ogrenci);
        }// Create

        public List<Ogrenci> Oku()
        {
            return Veri.Ogrenciler;
        }// Read

        public void Guncelle(Ogrenci ogrenci)
        {
            Ogrenci listedekiOgrenci = null;
            foreach (Ogrenci veriOgrenci in Veri.Ogrenciler)
            {
                if (veriOgrenci.Id == ogrenci.Id)
                {
                    listedekiOgrenci = veriOgrenci;
                    break;
                }
            }
            if (listedekiOgrenci != null)
            {
                listedekiOgrenci.Adi = ogrenci.Adi;
                listedekiOgrenci.Soyadi = ogrenci.Soyadi;
                listedekiOgrenci.DogumTarihi = ogrenci.DogumTarihi;
                listedekiOgrenci.Cinsiyet = ogrenci.Cinsiyet;
                listedekiOgrenci.MezunMu = ogrenci.MezunMu;
                listedekiOgrenci.NotOrtalamasi = ogrenci.NotOrtalamasi;
            }
        }// Update

        public void Sil(Ogrenci ogrenci)
        {
            Veri.Ogrenciler.Remove(ogrenci);
        }// Delete
    }
}
