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
    public partial class Yonetici : Form
    {
        public Giris frm1;
        UyeOl uyeol;      
        public Yonetici()
        {
            InitializeComponent();
            guncelbut.Hide();
            silbut.Hide();
            uyeol = new UyeOl();
            uyeol.yon = this;
        }
        DataTable dt;
        bool uyeguncelle = false;
        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void yeniKütühaneEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            entry.Text = "Kütüphane ID giriniz";
            YeniKutuphane yeni = new YeniKutuphane();
            yeni.ShowDialog();
            Dao.kutuphaneler(veriler);
        }

        private void kütühaneBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            silbut.Hide();
            guncelbut.Hide();
            entry.Text = "Kütüphane ID giriniz";
            Dao.kutuphaneler(veriler);    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yeniÜyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            silbut.Hide();
            guncelbut.Hide();
            uyeol.ShowDialog();
            Dao.uyeler(veriler);        
        }

        private void üyeBilgileriniGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Show();
            guncelbut.Show();
            silbut.Hide();
            entry.Text = "Üye ID giriniz";
            Dao.uyeler(veriler);
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            dt.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            Int32.TryParse(id.Text, out x);

            if (entry.Text == "Üye ID giriniz")
            {
                if (id.Text.Trim() == "")
                {
                    Dao.uyeler(veriler);
                }
                else
                {
                    Dao.uyeler(veriler, x);
                }
            }
            else if (entry.Text == "Kütüphane ID giriniz")
            {
                if (id.Text.Trim() == "")
                {
                    Dao.kutuphaneler(veriler);
                }
                else
                {
                    Dao.kutuphaneler(veriler, x);
                }
            }
            else if (entry.Text == "Memur ID giriniz")
            {
                if (id.Text.Trim() == "")
                {
                    Dao.memurlar(veriler);
                }
                else
                {

                    Dao.memurlar(veriler, x);
                }
            }
            else if (entry.Text == "Yazar ID giriniz")
            {
                if (id.Text.Trim() == "")
                {
                    Dao.yazarlar(veriler);
                }
                else
                {
                    Dao.yazarlar(veriler, x);
                }
            }
            else if (entry.Text == "Kitap ID giriniz")
            {
                if (id.Text.Trim() == "")
                {
                    Dao.kitaplar(veriler);
                }
                else
                {
                    Dao.kitaplar(veriler, x);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (entry.Text == "Üye ID giriniz")
            {
                uyeGuncelle uyegun = new uyeGuncelle(veriler.CurrentRow.Cells[0].Value.ToString(), veriler.CurrentRow.Cells[1].Value.ToString(), veriler.CurrentRow.Cells[2].Value.ToString(), veriler.CurrentRow.Cells[9].Value.ToString(), veriler.CurrentRow.Cells[4].Value.ToString(), veriler.CurrentRow.Cells[5].Value.ToString(), veriler.CurrentRow.Cells[3].Value.ToString(), veriler.CurrentRow.Cells[8].Value.ToString());
                uyegun.ShowDialog();
                Dao.uyeler(veriler);
                                
            }
            else if (entry.Text== "Kütüphane ID giriniz")
            {
                Kutupguncelle guncelle = new Kutupguncelle(veriler.CurrentRow.Cells[0].Value.ToString(), veriler.CurrentRow.Cells[1].Value.ToString(), veriler.CurrentRow.Cells[2].Value.ToString());
                guncelle.ShowDialog();
                Dao.kutuphaneler(veriler);
            }
            else if(entry.Text == "Memur ID giriniz")
            {
                string p1, p2, p3, p4, p5, p6, p7, p8;
                p1 = veriler.CurrentRow.Cells[0].Value.ToString();
                p2 = veriler.CurrentRow.Cells[1].Value.ToString();
                p3 = veriler.CurrentRow.Cells[2].Value.ToString();
                p4 = veriler.CurrentRow.Cells[3].Value.ToString();
                p5 = veriler.CurrentRow.Cells[4].Value.ToString();
                p6 = veriler.CurrentRow.Cells[5].Value.ToString();
                p7 = veriler.CurrentRow.Cells[6].Value.ToString();
                p8 = veriler.CurrentRow.Cells[7].Value.ToString();
                MemurGuncelle guncel = new MemurGuncelle(p1, p2, p3, p4, p5, p6, p7, p8);
                guncel.ShowDialog();
                Dao.memurlar(veriler);
            }
            else if (entry.Text == "Yazar ID giriniz")
            {
                string p1, p2, p3;
                p1 = veriler.CurrentRow.Cells[0].Value.ToString();
                p2 = veriler.CurrentRow.Cells[1].Value.ToString();
                p3 = veriler.CurrentRow.Cells[2].Value.ToString();                
                YazarDüzenle yazar = new YazarDüzenle(p1, p2, p3);
                yazar.ShowDialog();
                Dao.yazarlar(veriler);
            }
        }

        private void üyeBilgileriniGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Show();
            entry.Text = "Üye ID giriniz";          
            guncelbut.Hide();
            silbut.Hide();
            Dao.uyeler(veriler);
        }


        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Show();
            entry.Text = "Üye ID giriniz";
            guncelbut.Hide();
            silbut.Show();
            Dao.uyeler(veriler);    
        }

        private void silbut_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(veriler.CurrentRow.Cells[0].Value.ToString());
            string isim = veriler.CurrentRow.Cells[1].Value.ToString();
            if(entry.Text == "Kütüphane ID giriniz")
            {
                DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum)
                {
                    Dao.kutuphanesil(id);
                    MessageBox.Show("Kayıt Silindi...");
                    Dao.kutuphaneler(veriler);
                }

            }
            else if (entry.Text == "Üye ID giriniz"){
                DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == durum)
                {
                    Dao.uyeSil(id);
                    MessageBox.Show("Kayıt Silindi...");
                    Dao.uyeler(veriler);
                }
            }
            else if (entry.Text == "Memur ID giriniz")
            {
                DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == durum)
                {
                    Dao.memurSil(id);
                    MessageBox.Show("Kayıt Silindi...");
                    Dao.memurlar(veriler);
                }
            }
            else if(entry.Text == "Yazar ID giriniz")
            {
                Dao.yazarSil(id);
                MessageBox.Show("Kayıt Silindi...");
                Dao.yazarlar(veriler);
            }
            else if(entry.Text == "Kitap ID giriniz")
            {
                Dao.kitapSil(id);
                MessageBox.Show("Kayıt Silindi...");
                Dao.kitaplar(veriler);
            }

        }

        private void kütüphaneBilgileriniGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            silbut.Hide();
            guncelbut.Show();
            Dao.kutuphaneler(veriler);     
        }

        private void kütüphaneSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            silbut.Show();
            guncelbut.Hide();
            Dao.kutuphaneler(veriler);
        }

        private void memurBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            entry.Text = "Memur ID giriniz";
            silbut.Hide();
            guncelbut.Hide();
            Dao.memurlar(veriler);
        }

        private void memurBilgileriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ak.Hide();
            entry.Text = "Memur ID giriniz";
            silbut.Hide();
            guncelbut.Show();
            Dao.memurlar(veriler);
        }

        private void yeniMemurEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            silbut.Hide();
            guncelbut.Hide();
            ak.Hide();
            entry.Text = "Memur ID giriniz";
            YeniMemur yeni = new YeniMemur();
            yeni.ShowDialog();
            Dao.memurlar(veriler);
        }

        private void memuruGörevdenAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            entry.Text = "Memur ID giriniz";
            silbut.Show();
            guncelbut.Hide();
            Dao.memurlar(veriler);
        }
        
        private void yazarlarıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            entry.Text = "Yazar ID giriniz";
            guncelbut.Hide();
            silbut.Hide();
            Dao.yazarlar(veriler);
        }

        private void yazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            silbut.Hide();
            guncelbut.Hide();
            entry.Text = "Yazar ID giriniz";
            YeniYazar yazar = new YeniYazar();
            yazar.ShowDialog();
            Dao.yazarlar(veriler);
        }

        private void yazarGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            entry.Text = "Yazar ID giriniz";
            silbut.Hide();
            guncelbut.Show();
            Dao.yazarlar(veriler);
        }

        private void yazarSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            entry.Text = "Yazar ID giriniz";
            guncelbut.Hide();
            silbut.Show();
            Dao.yazarlar(veriler);
        }
        
        private void kitaplarıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            entry.Text = "Kitap ID giriniz";
            guncelbut.Hide();
            silbut.Hide();
            Dao.kitaplar(veriler);

        }

        private void kitapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            entry.Text = "Kitap ID giriniz";
            guncelbut.Hide();
            silbut.Show();
            Dao.kitaplar(veriler);
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            guncelbut.Hide();
            silbut.Hide();
            YeniKitap yeni = new YeniKitap();
            yeni.ShowDialog();
        }

        private void emanetİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void emanetVermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetVerme em = new EmanetVerme();
            em.ShowDialog();
        }

        private void emanetİadesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmanetIade ei = new EmanetIade();
            ei.ShowDialog();
        }

        private void gelişmişKitapAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapArama ka = new KitapArama();
            ka.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            this.Close();
            grs.Show();
        }

        private void Yonetici_Load(object sender, EventArgs e)
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

            ak.Hide();
            guncelbut.Hide();
            silbut.Hide();
        }

        private void kitapDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ak.Hide();
            guncelbut.Show();
            silbut.Hide();
        }

        private void ak_Click(object sender, EventArgs e)
        {
            aldigiKitaplar aki = new aldigiKitaplar(Convert.ToInt32(veriler.CurrentRow.Cells[0].Value), veriler.CurrentRow.Cells[1].Value.ToString(), veriler.CurrentRow.Cells[2].Value.ToString());
            aki.ShowDialog();
        }
    }
}
