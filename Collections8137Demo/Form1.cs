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
            // validasyon i�lemleri
            if (string.IsNullOrWhiteSpace(tbAdi.Text))
            {
                MessageBox.Show("Ad� bo� olamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbSoyadi.Text))
            {
                MessageBox.Show("Soyad� bo� olamaz!");
                return;
            }
            double notOrtalamasi;
            if (!double.TryParse(tbNotOrtalamasi.Text.Trim(), out notOrtalamasi))
            {
                MessageBox.Show("Not ortalamas� say�sal olmal�d�r!");
                return;
            }

            // validasyondan ge�ti �imdi ��renciyi listeye ekleyelim
            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = tbAdi.Text.Trim(),
                Soyadi = tbSoyadi.Text.Trim(),
                NotOrtalamasi = notOrtalamasi,
                DogumTarihi = dtpDogumTarihi.Value,
                MezunMu = cbMezun.Checked,
                // 3. yok en iyi:
                Cinsiyet = rbKadin.Checked ? Cinsiyet.Kad�n : Cinsiyet.Erkek // ternary
            };

            // 1. yol k�t�:
            //if (rbKadin.Checked)
            //    ogrenci.Cinsiyet = Cinsiyet.Kad�n;
            //else
            //    ogrenci.Cinsiyet = Cinsiyet.Erkek;
            // 2. yok daha iyi:
            //ogrenci.Cinsiyet = Cinsiyet.Kad�n;
            //if (rbErkek.Checked)
            //    ogrenci.Cinsiyet = Cinsiyet.Erkek;

            _veriErisim.Ekle(ogrenci);

            dgvOgrenciler.DataSource = null;
            List<Ogrenci> ogrenciler = _veriErisim.Oku();
            dgvOgrenciler.DataSource = ogrenciler;

            MessageBox.Show("��renci kaydedildi.");

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

            MessageBox.Show("��renci silindi.");
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {
            // validasyon i�lemleri
            if (string.IsNullOrWhiteSpace(tbAdiGuncelle.Text))
            {
                MessageBox.Show("Ad� bo� olamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbSoyadiGuncelle.Text))
            {
                MessageBox.Show("Soyad� bo� olamaz!");
                return;
            }
            double notOrtalamasi;
            if (!double.TryParse(tbNotOrtalamasiGuncelle.Text.Trim(), out notOrtalamasi))
            {
                MessageBox.Show("Not ortalamas� say�sal olmal�d�r!");
                return;
            }

            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = tbAdiGuncelle.Text.Trim(),
                Soyadi = tbSoyadiGuncelle.Text.Trim(),
                DogumTarihi = dtpDogumTarihiGuncelle.Value,
                MezunMu = cbMezunGuncelle.Checked,
                NotOrtalamasi = notOrtalamasi,
                Cinsiyet = rbKadinGuncelle.Checked ? Cinsiyet.Kad�n : Cinsiyet.Erkek
            };
            int id = Convert.ToInt32(nudIdGuncelle.Value);
            _veriErisim.Guncelle(ogrenci, id);

            dgvOgrenciler.DataSource = null;
            List<Ogrenci> ogrenciler = _veriErisim.Oku();
            dgvOgrenciler.DataSource = ogrenciler;

            MessageBox.Show("��renci g�ncellendi.");
        }

        private void lbGetir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = Convert.ToInt32(nudId.Value);
            Ogrenci ogrenci = _veriErisim.Oku(id);
            MessageBox.Show($"Ad�: {ogrenci.Adi}\r\n" +
                $"Soyad�: {ogrenci.Soyadi}\r\n" +
                $"Do�um Tarihi: {ogrenci.DogumTarihi.ToShortDateString()}\r\n" +
                $"Cinsiyet: {ogrenci.Cinsiyet}\r\n" +
                $"Mezun: {(ogrenci.MezunMu ? "Evet" : "Hay�r")}\r\n" +
                $"Not Ortalamas�: {ogrenci.NotOrtalamasi}");
        }                           
    }
}