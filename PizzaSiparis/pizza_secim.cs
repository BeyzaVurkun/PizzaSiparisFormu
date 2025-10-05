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
    public partial class pizza_secim : Form
    {
        private bool _kullanici_kayitli;
        public pizza_secim()
        {
            InitializeComponent();
            cmb_pizza.Items.AddRange(new string[] {"Küçük Boy", "Orta Boy", "Büyük Boy"});
            cmb_icecek.Items.AddRange(new string[] { "Cola", "Ayran", "Ice Tea" });
            cmb_pizza.SelectedIndex = -1;
            cmb_icecek.SelectedIndex = -1;
            nmr_icecek_adet.Value = 0;
            nmr_pizza_adet.Value = 0;
        }
        public pizza_secim(bool kayitlimi)
        {
            InitializeComponent();
            _kullanici_kayitli = kayitlimi;
            cmb_pizza.Items.AddRange(new string[] { "Küçük Boy", "Orta Boy", "Büyük Boy" });
            cmb_icecek.Items.AddRange(new string[] { "Cola", "Ayran", "Ice Tea" });
            cmb_pizza.SelectedIndex = -1;
            cmb_icecek.SelectedIndex = -1;
            nmr_pizza_adet.Value = 0;
            nmr_icecek_adet.Value = 0;
        }
       
        private void pizza_secim_Load(object sender, EventArgs e)
        {}
        private void btn_siparis_Click(object sender, EventArgs e)
        {
            decimal ücret = 0;
            decimal indirim = 0;
            string ekstralar = "";
            if(checkBox1.Checked)
            {
                ekstralar +=" "+"Sucuk";
            }
            if(checkBox2.Checked)
            {
                ekstralar += " " + "Sosis";
            }
            if(checkBox3.Checked)
            {
                ekstralar += " " + "Zeytin";
            }
            if(checkBox4.Checked)
            {
                ekstralar += " " + "Mantar";
            }
            if(checkBox5.Checked)
            {
                ekstralar += " " + "Peynir";
            }
            if(checkBox6.Checked)
            {
                ekstralar += " " + "Et";
            }

            
            int pizza_adet=(int)nmr_pizza_adet.Value;
            string pizza_bilgi = $"{cmb_pizza.Text}---{pizza_adet} adet";
            if(cmb_pizza.Text=="Küçük Boy")
            {
                ücret += pizza_adet * 15;
            }
            if(cmb_pizza.Text=="Orta Boy")
            {
                ücret += pizza_adet * 25;
            }
            if( cmb_pizza.Text=="Büyük Boy")
            {
                ücret += pizza_adet * 35;
            }

            int icecek_adet=(int)nmr_icecek_adet.Value;
            string icecek_bilgi = $"{cmb_icecek.Text}---{icecek_adet} adet";
            if(cmb_icecek.Text=="Cola")
            {
                ücret += icecek_adet * 10;
            }
            if(cmb_icecek.Text=="Ayran")
            {
                ücret += icecek_adet * 15;
            }
            if(cmb_icecek.Text=="Ice Tea")
            {
                ücret += icecek_adet * 25;
            }
            if (_kullanici_kayitli)
            {
                indirim = ücret * 0.3m;
                ücret -= indirim;
            }
            string ad_soy = txt_ad_soyad.Text;
            string tel = txt_tel.Text;
            string adres = txt_adres.Text;

            ödeme ödeme=new ödeme(pizza_bilgi,icecek_bilgi,ekstralar,ücret
                ,indirim,ad_soy,tel,adres);
            ödeme.Show();
            this.Hide();

        }


        private void btn_temiz_Click(object sender, EventArgs e)
        {
            cmb_pizza.SelectedIndex = -1;
            cmb_icecek.SelectedIndex = -1;

            nmr_pizza_adet.Value = 1;
            nmr_icecek_adet.Value = 1;

            txt_ad_soyad.Clear();
            txt_tel.Text = null;
            txt_adres.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

        }
    }
}
