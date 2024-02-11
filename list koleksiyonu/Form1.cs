using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_koleksiyonu
{
    public partial class Form1 : Form
    {
        List<int> numaralarList = new List<int>();
        List<string> adsoyadList = new List<string>();
        List<Ogrenciler> ogrencilerList = new List<Ogrenciler>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkleSayi_Click(object sender, EventArgs e)
        {
            numaralarList.Add(int.Parse(txtNumara.Text));
            lbSayi.Items.Clear();
            foreach (var item in numaralarList)
            {
                lbSayi.Items.Add(item);         
            }
        }

        private void btnEkleMetin_Click(object sender, EventArgs e)
        {
            adsoyadList.Add(string.Format(txtAdSoyad.Text));
            lbMetin.Items.Clear();
            foreach (var item in adsoyadList)
            {
                lbMetin.Items.Add(item);
            }
        }

        private void btnEkleNesne_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();  
            ogrenci.Numara = int.Parse(txtNumaraN.Text);
            ogrenci.AdSoyad = txtAdSoyadN.Text;
            ogrencilerList.Add(ogrenci);
            lbNesne.Items.Clear();
            foreach (var item in ogrencilerList)
            {
                lbNesne.Items.Add(item.Numara + " " + item.AdSoyad);
            }
        }
    }
}
