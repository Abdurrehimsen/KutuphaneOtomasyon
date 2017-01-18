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
    public partial class uyeGuncelle : Form
    {
        public Yonetici yone;
        private int uye_id;
        public uyeGuncelle(String uyeid, String name, String surname, String tcnumber, String sex, String email, String telno, String place)
        {
            InitializeComponent();
            uye_id = Int32.Parse(uyeid);
            adı.Text = name;
            soyad.Text = surname;
            tcno.Text = tcnumber;
            cins.Text = sex;
            eposta.Text = email;
            Telefon.Text = telno;
            adress.Text = place;
        }
        bool s1 = true, s2 = true, s3 = true, s4 = true, s5 = true, s6 = true, s7 = true;

        private void buttonactive()
        {
            button1.Enabled = s1 & s2 & s3 & s4 & s5 & s6 & s7;
        }
        private void tcno_TextChanged(object sender, EventArgs e)
        {
            s3 = tcno.Text.Length == 11;
            if(s3 == false)
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
                errorProvider1.SetError(cins, "Cinsiyet boş bırakılamaz");
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
                errorProvider1.SetError(eposta, "Eposta boş bırakılamaz");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void Telefon_TextChanged(object sender, EventArgs e)
        {
            s6 = tcno.Text.Length == 11;
            if (s6 == false)
            {
                errorProvider1.SetError(Telefon, "Telefon numarası 11 haneli olmalı!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void adress_TextChanged(object sender, EventArgs e)
        {
            s7 = adress.Text.Trim() != "";
            if (s7 == false)
            {
                errorProvider1.SetError(adress, "Adres boş bırakılamaz");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void uyeGuncelle_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void tcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void soyad_TextChanged(object sender, EventArgs e)
        {
            s2 = soyad.Text.Trim() != "";
            if (s2 == false)
            {
                errorProvider1.SetError(soyad, "Soyisim boş bırakılamaz");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dao.uyeGuncelle(uye_id, adı.Text, soyad.Text, tcno.Text, cins.Text, eposta.Text, Telefon.Text, adress.Text);
            MessageBox.Show("Üye Bilgileri Güncellendi.");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adı_TextChanged(object sender, EventArgs e)
        {
            s1 = adı.Text.Trim() != "";
            if(s1 == false)
            {
                errorProvider1.SetError(adı, "İsim boş bırakılamaz");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }
    }
}
