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
    public partial class Uye : Form
    {
        private string id, Ad, Soyad, TCno, cinsiyet, ePosta, Tel, adres;
        Dictionary<string, string> dict = new Dictionary<string, string>();
        private void button3_Click(object sender, EventArgs e)
        {
            uyeGuncelle ug = new uyeGuncelle(id, Ad, Soyad, TCno, cinsiyet, ePosta, Tel, adres);
            ug.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KitapArama ka = new KitapArama();
            ka.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string artan = "";
            if (checkBox1.Checked == false)
            {
                artan = "";
            }
            else
            {
                artan = " desc";
            }
            Dao.aldigikitaplar(dataGridView1, Convert.ToInt32(id), dict[durum.Text], dict[bicim.Text], artan);
        }

        private void Uye_Load(object sender, EventArgs e)
        {
            bilgi.Text = "Hoşgeldiniz " + Ad + " " + Soyad;
            dict.Add("", "");
            dict.Add("Şu an elinde olanlar", " and e.iade=0");
            dict.Add("Daha önce aldıkları", " and e.iade=1");
            dict.Add("Tümü", "");
            dict.Add("Kitabın Adına Göre", " order by ki.kitapAd ");
            dict.Add("Aldığı Kütüphaneye Göre", " order by ku.kutuphaneAd ");
            dict.Add("Emanet Tarihine Göre", " order by e.emanetTarih ");
        }

        public Uye(string uyeid, string uyeAd, string uyeSoyad, string uyeTCno, string uyecinsiyet, string uyeePosta, string uyeTel, string uyeadres)
        {
            InitializeComponent();
            id = uyeid;
            Ad = uyeAd;
            Soyad = uyeSoyad;
            TCno = uyeTCno;
            cinsiyet = uyecinsiyet;
            ePosta = uyeePosta;
            Tel = uyeTel;
            adres = uyeadres;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            this.Close();
            grs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dao.aldigikitaplar(dataGridView1, Convert.ToInt32(id), "", "", "");
        }
    }
}
