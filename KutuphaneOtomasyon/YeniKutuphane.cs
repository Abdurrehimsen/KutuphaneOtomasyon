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
    public partial class YeniKutuphane : Form
    {
        public YeniKutuphane()
        {
            InitializeComponent();           
        }
        bool s1 = false, s2 = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Dao.yeniKutuphane(ad.Text, adres.Text);
            MessageBox.Show("Yeni kütüphane oluşturuldu");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buttonactive()
        {
            button1.Enabled = s1 & s2;
        }
        private void ad_TextChanged(object sender, EventArgs e)
        {
            s1 = ad.Text.Trim() != "";
            if (s1 == false)
            {
                errorProvider1.SetError(ad, "Kütüphane adı boş bırakılamaz!");
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

        private void YeniKutuphane_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}
