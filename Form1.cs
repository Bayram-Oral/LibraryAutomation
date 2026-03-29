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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        librayautomationEntities db = new librayautomationEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = kadtext.Text;
            string sifre = parolatext.Text;

            var sorgu = db.tbladminup.Where(x =>x.kullaniciadi == ad && x.sifre == sifre).FirstOrDefault();

            if(sorgu != null)
            {
                MessageBox.Show("Giriş başarılı! Anasayfaya yönlendiriliyorsunuz");
                anasayfa ana = new anasayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şire hatalı tekrar deneyiniz!");
            }

        }


        private void btnkayıt_Click(object sender, EventArgs e)
        {
            tbladminup TblAdminup = new tbladminup();
            TblAdminup.kullaniciadi = kadtext.Text;
            TblAdminup.sifre = parolatext.Text;
            db.tbladminup.Add(TblAdminup);
            db.SaveChanges();

            MessageBox.Show("Kayıt başarılı!. bilgilerinizi girerek giriş yapabilirsiniz");
            login lg = new login();
            lg.Show();
            this.Hide();

        }



    }
}
