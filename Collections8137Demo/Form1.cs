using Collections8137Demo.DataAccess;
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
    }
}