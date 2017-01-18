using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KutuphaneOtomasyon
{
    public partial class MemurGuncelle : Form
    {
        int ID;
        public MemurGuncelle(string id, string memurAd, string memurSoyad, string TCno, string memurTel, string cinsiyet, string ePosta, string kutuphaneAd)
        {
            InitializeComponent();
            ID = Int32.Parse(id);
            adı.Text = memurAd;
            soyad.Text = memurSoyad;
            Telefon.Text = memurTel;
            cins.Text = cinsiyet;
            eposta.Text = ePosta;
            tcno.Text = TCno;
            kutuphane.Text = kutuphaneAd;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=HP-PC;Initial Catalog=Kütüphane;Integrated Security=True");
        bool s1 = true, s2 = true, s3 = true, s4 = true, s5 = true, s6 = true, s7 = true;

        private void tcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void tcno_TextChanged(object sender, EventArgs e)
        {
            s3 = tcno.Text.Trim().Length == 11;
            if (s3 == false)
            {
                errorProvider1.SetError(tcno, "TC numarası 11 haneli olmalı!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void cins_SelectedIndexChanged(object sender, EventArgs e)
        {
            s4 = cins.Text.Trim() != "";
            if (s4 == false)
            {
                errorProvider1.SetError(cins, "Cinsiyet boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void eposta_TextChanged(object sender, EventArgs e)
        {
            s5 = eposta.Text.Trim() != "";
            if (s5 == false)
            {
                errorProvider1.SetError(eposta, "Eposta boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void Telefon_TextChanged(object sender, EventArgs e)
        {
            s6 = Telefon.Text.Trim().Length == 11;
            if (s6 == false)
            {
                errorProvider1.SetError(Telefon, "Telefon numarası 11 hanelı olmalı!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void kutuphane_SelectedIndexChanged(object sender, EventArgs e)
        {
            s7 = kutuphane.Text.Trim() != "";
            if (s7 == false)
            {
                errorProvider1.SetError(kutuphane, "Kütüphane boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void soyad_TextChanged(object sender, EventArgs e)
        {
            s2 = soyad.Text.Trim() != "";
            if (s2 == false)
            {
                errorProvider1.SetError(soyad, "Soyad boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void buttonactive()
        {
            button1.Enabled = s1 & s2 & s3 & s4 & s5 & s6 & s7;
        }
        private void adı_TextChanged(object sender, EventArgs e)
        {
            s1 = adı.Text.Trim() != "";
            if(s1 == false)
            {
                errorProvider1.SetError(adı, "Ad boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dao.memurGuncelle(ID, adı.Text, soyad.Text, tcno.Text, Telefon.Text, cins.Text, eposta.Text, kutuphane.Text);
            MessageBox.Show("Üye Bilgileri Güncellendi.");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MemurGuncelle_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Dao.kutuphanesec(kutuphane);
        }
    }
}
