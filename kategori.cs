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
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }

        librayautomationEntities db = new librayautomationEntities();

        private void btnekle_Click(object sender, EventArgs e)
        {
            tblcategories TblCategories = new tblcategories();
            TblCategories.kategoriadi = txtad.Text;
            db.tblcategories.Add(TblCategories);
            db.SaveChanges();

            MessageBox.Show("Başarıyla Eklenmiştir! Anasayfaya yönlendiriliyorsunuz...");

            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var updatevalue = db.tblcategories.Find(id);
            updatevalue.kategoriadi = txtad.Text.ToString();

            db.SaveChanges();

            MessageBox.Show("Başarıyla Güncellenmiştir! Anasayfaya yönlendiriliyorsunuz...");

            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deletevalue = db.tblcategories.Find(id);
            db.tblcategories.Remove(deletevalue);
            db.SaveChanges();

            MessageBox.Show("Başarıyla Silinmiştir! Anasayfaya yönlendiriliyorsunuz...");

            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();
        }
    }
}
