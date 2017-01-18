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

    public partial class YeniKitap : Form
    {
        public YeniKitap()
        {
            InitializeComponent();
        }
        TextBox[] a = new TextBox[20];
        string[] klist;
        private void YeniKitap_Load(object sender, EventArgs e)
        {
            string[] kategoriler = Dao.kategoriler();
            for(int k = 0;k < kategoriler.Length; k++)
            {
                kategori.Items.Add(kategoriler[k]);
            }

            yazarad.Items.Clear();
            yazarad.AutoCompleteCustomSource.Clear();
            Dao.yazarlarilistele(yazarad);

            panel1.Controls.Clear();
            klist = Dao.kutuphanelistesi();
            int i = 39;
            int j = 0;
            while (klist[j] != null)
            {
                Label yazi = new Label();
                yazi.Text = klist[j];
                panel1.Controls.Add(yazi);
                yazi.Location = new Point(16, i);
                yazi.Size = new Size(64, 25);

                a[j] = new TextBox();
                panel1.Controls.Add(a[j]);
                a[j].Location = new Point(275, i);
                a[j].Size = new Size(100, 30);
                a[j].MaxLength = 3;
                i += 39;
                j += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kitapid = Dao.yeniKitap(kitapad.Text, dateTimePicker1.Value.Date,dateTimePicker2.Value.Date, kategori.Text, yayinevi.Text);
            int yazarid = Dao.yazarid(yazarad.Text);

            Dao.kitap_yazar(kitapid, yazarid);

            int i = 0;
            while(a[i] != null)
            {
                if (a[i].Text.Trim() != "" && Convert.ToInt32(a[i].Text.Trim()) != 0) 
                {
                    int kutupid = Dao.kutuphaneid(klist[i]);
                    Dao.kutuphane_kitap(kitapid, kutupid, Convert.ToInt32(a[i].Text.Trim()));
                }
                i += 1;
            }
            MessageBox.Show("İşlem Tamamlandı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
