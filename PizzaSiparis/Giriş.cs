using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzasitesi
{
    public partial class Giriş : Form
    {
        string kayitedilen_adsoyad="";
        string kayitedilen_sifre="";
      
        public Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciad_soyad = txt_kulad_kulsoyad.Text;
            string kullanici_sifre = txt_kulsifre.Text;
            
            if (string.IsNullOrWhiteSpace(kullaniciad_soyad))
            {
                MessageBox.Show("İsim Boş Bırakılamaz");
                return;
            }
            if (string.IsNullOrWhiteSpace(kullanici_sifre))
            {
                MessageBox.Show("Şifre Boş Bırakılamaz");
                return;
            }
            bool kayitlimi =
             ((kullaniciad_soyad == "beyza vurkun" && kullanici_sifre == "123")
                || (kullaniciad_soyad == kayitedilen_adsoyad && kullanici_sifre == kayitedilen_sifre));
           if(kayitlimi)
                {
                MessageBox.Show("Hoş geldiniz");              
                pizza_secim pizza = new pizza_secim(true);
                pizza.Show();
                this.Hide();
            }
           else
            {
                MessageBox.Show("Misafir olarak geldiniz");
                pizza_secim pizza = new pizza_secim();
                pizza.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kayit_ad_soyad = txt_kayit_ad_soyad.Text;
            string kayit_sifre = txt_kayit_sifre.Text;
            if(!string.IsNullOrWhiteSpace(kayit_ad_soyad)&&!string.IsNullOrWhiteSpace(kayit_sifre))
            {
                 kayitedilen_adsoyad= kayit_ad_soyad;
                 kayitedilen_sifre= kayit_sifre;
                MessageBox.Show("Kayıt Tamamlandı");
            }
           else if(string.IsNullOrWhiteSpace(kayit_ad_soyad))
            {
                MessageBox.Show("İsim Boş Bırakılamaz");
            }
           else if (string.IsNullOrWhiteSpace(kayit_sifre))
            {
                MessageBox.Show("Şifre Boş Bırakılamaz");
            }
            else
            {
                MessageBox.Show("Kayıt Tamamlandı");
            }
        }

        private void Giriş_Load(object sender, EventArgs e)
        {
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
        }
    }
}
