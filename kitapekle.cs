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
    public partial class kitap : Form
    {
        public kitap()
        {
            InitializeComponent();
        }

        librayautomationEntities db = new librayautomationEntities();
        private void btnadd_Click(object sender, EventArgs e)
        {
            tblbooks TblBooks = new tblbooks();
            TblBooks.kitapismi = ktisimtxt.Text;
            TblBooks.yazar = yazartxt.Text;
            TblBooks.yayinevi = yayintxt.Text;
            TblBooks.sayfasayisi = sstxt.Text;
            TblBooks.kategori = kategoritxt.Text;
            TblBooks.stok = int.Parse(stoktxt.Text);
            db.tblbooks.Add(TblBooks);

            tblcategories TblCategories = new tblcategories();
            TblCategories.kategoriadi = kategoritxt.Text;
            db.tblcategories.Add(TblCategories);

            db.SaveChanges();

            MessageBox.Show("Kitap başarıyla eklenmiştir! Anasayfa yönlendiriliyorsunuz...");
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();

            

        }

        private void kitap_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap eklerken id alanını boş bırakınız! --- Kitap güncellerken id alanını da giriniz! --- Kitap silerken sadece id girmeniz yeterlidir! ");

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtxt.Text);
            var updatevalue = db.tblbooks.Find(id);
            updatevalue.kitapismi = ktisimtxt.Text;
            updatevalue.yazar = yazartxt.Text;
            updatevalue.yayinevi = yayintxt.Text;
            updatevalue.sayfasayisi = sstxt.Text;
            updatevalue.kategori = kategoritxt.Text;
            updatevalue.stok = int.Parse(stoktxt.Text);
            db.SaveChanges();

            MessageBox.Show("Kitap başarıyla güncellendi! Anasayfaya yönlendiriliyorsunuz...");
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtxt.Text);
            var removevalue = db.tblbooks.Find(id);
            db.tblbooks.Remove(removevalue);
            db.SaveChanges();

            MessageBox.Show("Başarıyla silinmiştir! Anasayfaya yönlendiriliyorsunuz...");

            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();
        }

    }
}
