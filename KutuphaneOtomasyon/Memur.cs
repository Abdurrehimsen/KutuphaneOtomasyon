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
    public partial class Memur : Form
    {
        public static int kutuphaneid;
        public Memur(int id)
        {
            InitializeComponent();
            kutuphaneid = id;
        }
        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncelle.Hide();
            ak.Hide();
            sil.Hide();
            Dao.kitaplar(dataGridView1);
        }

        private void kitapEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            YeniKitap yeni = new YeniKitap();
            yeni.ShowDialog();
            Dao.kitaplar(dataGridView1);
        }

        private void yazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniYazar yazar = new YeniYazar();
            yazar.ShowDialog();
            Dao.yazarlar(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeGuncelle uyegun = new uyeGuncelle(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString());
            uyegun.ShowDialog();
            Dao.uyeler(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            this.Close();
            grs.Show();
        }

        private void emanetVermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetVerme ev = new EmanetVerme(kutuphaneid);
            ev.ShowDialog();
        }

        private void emanetAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetIade ei = new EmanetIade(kutuphaneid);
            ei.ShowDialog();
        }

        private void Memur_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = Dao.kitapsayisi();
            int j = 3;
            for (int i = 0; i < dict.Count; i++)
            {
                Label yazi = new Label();
                yazi.Text = dict.Keys.ToList()[i] + ": " + dict[dict.Keys.ToList()[i]] + " faklı kitap vardır.";
                panel1.Controls.Add(yazi);
                yazi.Location = new Point(3, j);
                j += 25; ;
            }
            guncelle.Hide();
            ak.Hide();
            sil.Hide();
        }

        private void yazarEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            guncelle.Hide();
            ak.Hide();
            sil.Hide();
            YeniYazar yy = new YeniYazar();
            yy.Show();
        }

        private void üyeBilgileriniGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncelle.Show();
            ak.Show();
            sil.Show();
            Dao.uyeler(dataGridView1);
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

            if (DialogResult.Yes == durum)
            {
                Dao.uyeSil(id);
                MessageBox.Show("Kayıt Silindi...");
                Dao.uyeler(dataGridView1);
            }
        }

        private void ak_Click(object sender, EventArgs e)
        {
            aldigiKitaplar aki = new aldigiKitaplar(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString());
            aki.ShowDialog();
        }
    }
}
