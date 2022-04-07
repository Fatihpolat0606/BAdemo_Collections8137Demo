using Collections8137Demo.DataAccess;
using Collections8137Demo.Enums;
using Collections8137Demo.Models;

namespace Collections8137Demo
{
    public partial class Form1 : Form
    {
        VeriErisim _veriErisim;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _veriErisim = new VeriErisim();
            List<Ogrenci> ogrenciler = _veriErisim.Oku();
            dgvOgrenciler.DataSource = ogrenciler;
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            // validasyon iþlemleri
            if (string.IsNullOrWhiteSpace(tbAdi.Text))
            {
                MessageBox.Show("Adý boþ olamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbSoyadi.Text))
            {
                MessageBox.Show("Soyadý boþ olamaz!");
                return;
            }
            double notOrtalamasi;
            if (!double.TryParse(tbNotOrtalamasi.Text.Trim(), out notOrtalamasi))
            {
                MessageBox.Show("Not ortalamasý sayýsal olmalýdýr!");
                return;
            }

            // validasyondan geçti þimdi öðrenciyi listeye ekleyelim
            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = tbAdi.Text.Trim(),
                Soyadi = tbSoyadi.Text.Trim(),
                NotOrtalamasi = notOrtalamasi,
                DogumTarihi = dtpDogumTarihi.Value,
                MezunMu = cbMezun.Checked,
                // 3. yok en iyi:
                Cinsiyet = rbKadin.Checked ? Cinsiyet.Kadýn : Cinsiyet.Erkek // ternary
            };

            // 1. yol kötü:
            //if (rbKadin.Checked)
            //    ogrenci.Cinsiyet = Cinsiyet.Kadýn;
            //else
            //    ogrenci.Cinsiyet = Cinsiyet.Erkek;
            // 2. yok daha iyi:
            //ogrenci.Cinsiyet = Cinsiyet.Kadýn;
            //if (rbErkek.Checked)
            //    ogrenci.Cinsiyet = Cinsiyet.Erkek;

            _veriErisim.Ekle(ogrenci);

            dgvOgrenciler.DataSource = null;
            List<Ogrenci> ogrenciler = _veriErisim.Oku();
            dgvOgrenciler.DataSource = ogrenciler;

            MessageBox.Show("Öðrenci kaydedildi.");

            tbAdi.Text = "";
            tbSoyadi.Text = "";
            dtpDogumTarihi.Value = DateTime.Now;
            rbKadin.Checked = true;
            cbMezun.Checked = true;
            tbNotOrtalamasi.Clear();
        }

        private void lbSil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);
            _veriErisim.Sil(id);

            dgvOgrenciler.DataSource = null;
            List<Ogrenci> ogrenciler = _veriErisim.Oku();
            dgvOgrenciler.DataSource = ogrenciler;

            MessageBox.Show("Öðrenci silindi.");
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            // validasyon iþlemleri
            if (string.IsNullOrWhiteSpace(tbAdiGuncelle.Text))
            {
                MessageBox.Show("Adý boþ olamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbSoyadiGuncelle.Text))
            {
                MessageBox.Show("Soyadý boþ olamaz!");
                return;
            }
            double notOrtalamasi;
            if (!double.TryParse(tbNotOrtalamasiGuncelle.Text.Trim(), out notOrtalamasi))
            {
                MessageBox.Show("Not ortalamasý sayýsal olmalýdýr!");
                return;
            }

            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = tbAdiGuncelle.Text.Trim(),
                Soyadi = tbSoyadiGuncelle.Text.Trim(),
                DogumTarihi = dtpDogumTarihiGuncelle.Value,
                MezunMu = cbMezunGuncelle.Checked,
                NotOrtalamasi = notOrtalamasi,
                Cinsiyet = rbKadinGuncelle.Checked ? Cinsiyet.Kadýn : Cinsiyet.Erkek
            };
            int id = Convert.ToInt32(nudIdGuncelle.Value);
            _veriErisim.Guncelle(ogrenci, id);

            dgvOgrenciler.DataSource = null;
            List<Ogrenci> ogrenciler = _veriErisim.Oku();
            dgvOgrenciler.DataSource = ogrenciler;

            MessageBox.Show("Öðrenci güncellendi.");
        }

        private void lbGetir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);
            Ogrenci ogrenci = _veriErisim.Oku(id);
            MessageBox.Show($"Adý: {ogrenci.Adi}\r\n" +
                $"Soyadý: {ogrenci.Soyadi}\r\n" +
                $"Doðum Tarihi: {ogrenci.DogumTarihi.ToShortDateString()}\r\n" +
                $"Cinsiyet: {ogrenci.Cinsiyet}\r\n" +
                $"Mezun: {(ogrenci.MezunMu ? "Evet" : "Hayýr")}\r\n" +
                $"Not Ortalamasý: {ogrenci.NotOrtalamasi}");
        }                           
    }
}