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
    public partial class YeniMemur : Form
    {
        public YeniMemur()
        {
            InitializeComponent();
        }
        private bool s1 = false, s2 = false, s3 = false, s4 = false, s5 = false, s6 = false, s7 = false, s8 = false, s9 = false;

        private void adı_TextChanged(object sender, EventArgs e)
        {
            s1 = adı.Text.Trim() != "";
            if (s1 == false)
            {
                errorProvider1.SetError(adı, "Ad boş bırakılamaz!");
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

        private void nick_TextChanged(object sender, EventArgs e)
        {
            s7 = soyad.Text.Trim() != "" & Dao.memurVarmi(nick.Text);
            
            if (!Dao.uyeVarmi(nick.Text))
            {
                errorProvider1.SetError(nick, "Kullanıcı adı alındı. Lütfen başka bir kullanıcı adı girin!");
            }
            else if (soyad.Text.Trim() == "")
            {
                errorProvider1.SetError(nick, "Kullanıcı adı boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            s8 = pass.Text.Trim() != "";
            if (s8 == false)
            {
                errorProvider1.SetError(pass, "Şifre boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void kutuphane_SelectedIndexChanged(object sender, EventArgs e)
        {
            s9 = kutuphane.Text.Trim() != "";
            if (s2 == false)
            {
                errorProvider1.SetError(kutuphane, "Kütüphane adı boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool s = Dao.yeniMemur(adı.Text, soyad.Text, Telefon.Text, cins.Text, eposta.Text, nick.Text, pass.Text, tcno.Text, kutuphane.Text);
            if (s == true)
            {
                MessageBox.Show("Kaydınız Başarıyla oluşturulmuştur");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonactive()
        {
            button1.Enabled = s1 & s1 & s2 & s3 & s4 & s5 & s6 & s7 & s8 & s9;
        }

        private void YeniMemur_Load(object sender, EventArgs e)
        {
            Dao.kutuphanesec(kutuphane);
            button1.Enabled = false;           
        }

        private void tcno_TextChanged(object sender, EventArgs e)
        {
            s3 = tcno.Text.Trim().Length == 11;
            if (s3 == false)
            {
                errorProvider1.SetError(tcno, "Tc no 11 haneli olmalı!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void tcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void Telefon_TextChanged(object sender, EventArgs e)
        {
            s6 = Telefon.Text.Trim().Length == 11;
            if (s6 == false)
            {
                errorProvider1.SetError(Telefon, "Telefon no 11 haneli olmalı!");
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
    }
}
