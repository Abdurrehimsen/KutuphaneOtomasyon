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
    public partial class aldigiKitaplar : Form
    {
        private int uyeid;
        private string uyead, uyesoyad;
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public aldigiKitaplar(int id, string ad,string soyad)
        {
            InitializeComponent();
            uyeid = id;
            uyead = ad;
            uyesoyad = soyad;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string artan = "";
            if(checkBox1.Checked == false)
            {
                artan = "";
            }
            else
            {
                artan = " desc";
            }            
            Dao.aldigikitaplar(dataGridView1, uyeid, dict[durum.Text], dict[bicim.Text], artan);            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox1.Text = "Azalan";
            }
            else
            {
                checkBox1.Text = "Artan";
            }
        }

        private void aldigiKitaplar_Load(object sender, EventArgs e)
        {
            dict.Add("", "");
            dict.Add("Şu an elinde olanlar"," and e.iade=0");
            dict.Add("Daha önce aldıkları", " and e.iade=1");
            dict.Add("Tümü", "");
            dict.Add("Kitabın Adına Göre", " order by ki.kitapAd ");
            dict.Add("Aldığı Kütüphaneye Göre", " order by ku.kutuphaneAd ");
            dict.Add("Emanet Tarihine Göre", " order by e.emanetTarih ");
            Dao.aldigikitaplar(dataGridView1, uyeid, "","","");
            label3.Text = uyead + " " + uyesoyad;
        }
    }
}
