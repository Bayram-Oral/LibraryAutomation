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
    public partial class emanetislem : Form
    {
        public emanetislem()
        {
            InitializeComponent();
        }

        librayautomationEntities db = new librayautomationEntities();

        private void btnekle_Click(object sender, EventArgs e)
        {
            tblborrowedbooks TblBorrowedbooks = new tblborrowedbooks();

            TblBorrowedbooks.kitapid =Convert.ToInt32(kid.SelectedValue);
            TblBorrowedbooks.uyeid = Convert.ToInt32(uyeidd.SelectedValue);
            TblBorrowedbooks.alistarihi = DateTime.Now;
            TblBorrowedbooks.iadetarihi = DateTime.Now.AddDays(15);
            TblBorrowedbooks.iadedurumu = textBox1.Text;
            db.tblborrowedbooks.Add(TblBorrowedbooks);
            db.SaveChanges();

            MessageBox.Show("Başarıyla eklenmiştir! Anasayfaya yönlendiriliyorsunuz...");
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();
           
        }

        private void emanetislem_Load(object sender, EventArgs e)
        {
            var bookid = db.tblbooks.Select(x => new
            {
                x.kitapid
            }).ToList();
            kid.DataSource = bookid;
            kid.DisplayMember = "kitapismi";
            kid.ValueMember = "kitapid";

            var memberid = db.tblmembers.Select(x => new
            {
                x.uyeid
            }).ToList();
            uyeidd.DataSource = memberid;
            uyeidd.DataSource = memberid;
            uyeidd.DisplayMember = "ad";   
            uyeidd.ValueMember = "uyeid";
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            int id = int.Parse(textBox2.Text);
            var updatevalue = db.tblborrowedbooks.Find(id);
            updatevalue.uyeid = Convert.ToInt32(uyeidd.SelectedValue);
            updatevalue.alistarihi = DateTime.Now;
            updatevalue.iadetarihi = DateTime.Now.AddDays(15);
            updatevalue.iadedurumu = textBox1.Text;
            db.SaveChanges();

            MessageBox.Show("Başaryla güncellendi! Anasayfaya yönlendiriliyorsunuz");

            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox2.Text);
            var deletevalue = db.tblborrowedbooks.Find(id);
            db.tblborrowedbooks.Remove(deletevalue);
            db.SaveChanges();

            MessageBox.Show("Başarıyla silinmiştir! Anasayfaya yönlendiriliyorsunuz...");

            anasayfa ana = new anasayfa();
            ana.Show();
            this.Close();
        }
    }
}
