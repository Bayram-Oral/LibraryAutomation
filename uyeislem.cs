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
    public partial class uyeislem : Form
    {
        public uyeislem()
        {
            InitializeComponent();
        }
        librayautomationEntities db = new librayautomationEntities();
        private void uyeislem_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Üye eklerken id alanını boş bırakınız! --- Üye güncellerken id alanını da giriniz! --- Üye silerken sadece id girmeniz yeterlidir! ");

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            tblmembers TblMembers = new tblmembers();
            TblMembers.ad = txtad.Text;
            TblMembers.soyad = txtsoyad.Text;
            TblMembers.telno = txttel.Text;
            TblMembers.email = txtmail.Text;
            TblMembers.adres = txtadres.Text;
            TblMembers.kayittarihi = DateTime.Now;
            db.tblmembers.Add(TblMembers);
            db.SaveChanges();

            MessageBox.Show("Üye başarıyla kaydedilmiştir! Anasayfaya yönlkendiriliyorsunuz...");

            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var updatevalue = db.tblmembers.Find(id);
            updatevalue.ad = txtad.Text;
            updatevalue.soyad = txtsoyad.Text;
            updatevalue.telno = txttel.Text;
            updatevalue.email = txtmail.Text;
            updatevalue.adres = txtadres.Text;
            updatevalue.kayittarihi = DateTime.Now;
            db.SaveChanges();

            MessageBox.Show("Üye başarıyla kaydedilmiştir! Anasayfaya yönlendiriliyorsunuz...");

            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var deletevalue = db.tblmembers.Find(id);
            db.tblmembers.Remove(deletevalue);
            db.SaveChanges();

            MessageBox.Show("Başarıyla silinmiştir! Anasayfaya yönlendiriliyorsunuz...");

            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();

        }
    }
}
