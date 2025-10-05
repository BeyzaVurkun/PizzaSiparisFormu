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
    public partial class ödeme : Form
    {
        public ödeme(string pizza_bilgi,string icecek_bilgi,string ekstralar,decimal ücret,
            decimal indirim,string ad_soy,string tel,string adres)
        {
            InitializeComponent();
            list_pizza_adedi.Items.Add(pizza_bilgi);
            list_icecek_adedi.Items.Add(icecek_bilgi);       
            list_ücret.Items.Add(ücret);
            list_indirim.Items.Add(indirim);
            list_ad_soyad.Items.Add(ad_soy);
            list_telefon.Items.Add(tel);
            //list_adres.Items.Add(adres);
            list_ekstralar.Items.Add(ekstralar);
            //if(!string.IsNullOrWhiteSpace(ekstralar))
            //{
            //    var parcalar=ekstralar.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            //    foreach(var parca in parcalar)
            //    list_ekstralar.Items.Add(parca);
            //}


            if (!string.IsNullOrWhiteSpace(adres))
            {
                string[] parcalar = adres.Split(' ');
                foreach (var parca in parcalar)
                {
                    if (!string.IsNullOrWhiteSpace(parca))
                        list_adres.Items.Add(parca);
                }
            }


        }

        private void ödeme_Load(object sender, EventArgs e)
        {

        }
    }
}
