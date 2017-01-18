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
    public partial class KitapArama : Form
    {
        public KitapArama()
        {
            InitializeComponent();
        }


        private void KitapArama_Load(object sender, EventArgs e)
        {
            string[] kategoriler = Dao.kategoriler();
            for(int i = 0; i < kategoriler.Length; i++)
            {
                kategori.Items.Add(kategoriler[i]);
            }
            Dao.kutuphanesec(kutuphane);
            Dao.yazarlarilistele(yazarad);
            skitap.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string orderby = "";
            if (skitap.Checked == true)
            {
                orderby = "k.kitapAd";
            }
            else if (syazarad.Checked == true)
            {
                orderby = "y.yazarAd";
            }
            else if (skategori.Checked == true)
            {
                orderby = "k.kategori";
            }
            else if (skutuphane.Checked == true)
            {
                orderby = "ku.kutuphaneAd";
            }

            Dao.gelismisKitapArama(kitapad.Text, yazarad.Text, kategori.Text, kutuphane.Text, orderby, veriler);
        }

    }
}
