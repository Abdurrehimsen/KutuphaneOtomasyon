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
    public partial class EmanetVerme : Form
    {
        private int kutuphaneid;
        public EmanetVerme(int kutupid = -1)
        {
            InitializeComponent();
            kutuphaneid = kutupid;
        }
        
        bool s1 = false, s2 = false;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (name.Text.Trim() == "")
            {
                uyead.Text = "";
            }
            else
            {
                s1 = Dao.uyealabilir(Convert.ToInt32(name.Text.Trim()));
                uyead.Text = Dao.uyelerem(Convert.ToInt32(name.Text.Trim()));
                if (s1 == false)
                {
                    errorProvider1.SetError(name,"Bu üye max sayıda kitap aldı!");
                }
                else
                {
                    errorProvider1.Clear();
                }
                buton();
            }

        }

        private void book_TextChanged(object sender, EventArgs e)
        {
            if (book.Text.Trim() == "")
            {
                kitapad.Text = "";
            }
            else
            {
                if (kutuphaneid == -1)
                {
                    kutuphaneid = Dao.kutuphaneid(kutuphane.Text);

                }
                bool[] array = new bool[2];
                array = Dao.kitapkaldimi(Convert.ToInt32(book.Text.Trim()), kutuphaneid);
                if (array[0] == true && array[1])
                {
                    kitapad.Text = Dao.kitaplarem(Convert.ToInt32(book.Text.Trim()));
                    s2 = true;
                }
                if(array[0] == false)
                {
                    errorProvider1.SetError(book, "Bu kitap Kütüphanede bulunmamaktadır!");
                }
                else if(array[1] == false)
                {
                    errorProvider1.SetError(book, "Bu kitap emanete verilmiştir");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            buton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kutuphaneid == -1)
            {
                kutuphaneid = Dao.kutuphaneid(kutuphane.Text);

            }
            bool s = Dao.yeniEmanet(Convert.ToInt32(name.Text), Convert.ToInt32(book.Text), kutuphaneid);
            if (s == true)
            {
                MessageBox.Show("İşlem başarılı!");
            }
            else
            {
                MessageBox.Show("Hata!");
            }
        }

        public void buton()
        {
            button2.Enabled = s1 & s2;
        }

        private void kutuphane_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kutuphane_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            kutuphaneid = Dao.kutuphaneid(kutuphane.Text);
            if(kutuphaneid > -1)
            {
                book.Enabled = true;
            }
        }

        private void EmanetVerme_Load(object sender, EventArgs e)
        {
            Dao.kutuphanesec(kutuphane);
            button2.Enabled = s1 & s2;
            if (kutuphaneid == -1)
            {
                book.Enabled = false;
            }
            else
            {
                book.Enabled = true;
                kutuphane.Visible = false;
            }
        }
    }
}
