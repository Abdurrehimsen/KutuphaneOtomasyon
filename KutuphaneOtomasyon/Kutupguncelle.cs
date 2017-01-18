using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class Kutupguncelle : Form
    {
        private string ID;
        public Kutupguncelle(string id, string adi, string place)
        {
            InitializeComponent();
            ad.Text = adi;
            adres.Text = place;
            ID = id;
        }
        bool s1 = true, s2 = true;
        private void button1_Click(object sender, EventArgs e)
        {
            string kutupad = ad.Text, adresi = adres.Text;
            Dao.kutuphaneguncelle(kutupad, adresi, ID);
            MessageBox.Show("Kütüphane Güncellendi");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kutupguncelle_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void ad_TextChanged(object sender, EventArgs e)
        {
            s1 = ad.Text.Trim() != "";
            if (s1 == false)
            {
                errorProvider1.SetError(ad, "Ad boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void adres_TextChanged(object sender, EventArgs e)
        {
            s2 = adres.Text.Trim() != "";
            if (s2 == false)
            {
                errorProvider1.SetError(adres, "Adres boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void buttonactive()
        {
            button1.Enabled = s1 & s2;
        }
    }
}
