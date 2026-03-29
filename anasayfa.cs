using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace girisform
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        librayautomationEntities db = new librayautomationEntities();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            #region toplam kitap sayısı
            lblktpcount.Text = db.tblbooks.Count().ToString();
            #endregion

            #region üye sayısı
            label4.Text = db.tblmembers.Count().ToString();
            #endregion

            #region emanet sayısı
            label6.Text = db.tblborrowedbooks.Count().ToString();
            #endregion
        }

        private void btnkitap_Click(object sender, EventArgs e)
        {
            var ktp = db.tblbooks.Select(x=> new
            {
                id=x.kitapid,
                kitapadi=x.kitapismi,
                yazar=x.yazar,
                yayinevi=x.yayinevi,
                sayfasayisi=x.sayfasayisi,
                kategori=x.kategori,
                stok=x.stok
            }).ToList();
            dataGridView1.DataSource = ktp;
        }

        private void btnuyeler_Click(object sender, EventArgs e)
        {
            var uye = db.tblmembers.Select(x => new
            {
                id = x.uyeid,
                adi=x.ad,
                soyad=x.soyad,
                telno=x.telno,
                email=x.email,
                adres=x.adres,
                kayittarihi=x.kayittarihi
            }).ToList();
            dataGridView1.DataSource = uye;
        }

        private void btnemanet_Click(object sender, EventArgs e)
        {
            var emanet = db.tblborrowedbooks.Select(x => new
            {
                id=x.emanetid,
                kitapid=x.kitapid,
                uyeid=x.uyeid,
                alistarihi=x.alistarihi,
                iadetarihi=x.iadetarihi,
                iadedurumu=x.iadedurumu
            }).ToList();
            dataGridView1.DataSource = emanet;
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            var ktg = db.tblcategories.Select(x => new
            {
                id=x.kategoriid,
                kategoriadi=x.kategoriadi
            }).ToList();
            dataGridView1.DataSource = ktg;
        }

        private void btnaddktp_Click(object sender, EventArgs e)
        {
            kitap kti = new kitap();
            kti.Show();
            this.Hide();
        }

        private void btnadduye_Click(object sender, EventArgs e)
        {
            uyeislem uye = new uyeislem();
            uye.Show();
            this.Hide();
        }

        private void btnaddkategori_Click(object sender, EventArgs e)
        {
            kategori kt = new kategori();
            kt.Show();
            this.Close();
        }

        private void btnaddemanet_Click(object sender, EventArgs e)
        {
            emanetislem emanet = new emanetislem();
            emanet.Show();
            this.Hide();
        }
    }
}
