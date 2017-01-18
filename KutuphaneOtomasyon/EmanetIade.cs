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
    public partial class EmanetIade : Form
    {
        private int kutuphaneid;
        public EmanetIade(int kutupid = -1)
        {
            InitializeComponent();
            kutuphaneid = kutupid;
        }
        Dictionary<int, int> emanetler = new Dictionary<int, int>();

        bool s1 = false, s2 = false;
        private void EmanetIade_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            bkitaplar.Enabled = false;
            kitaplar.Enabled = false;
        }

        private void buttonactive()
        {
            button1.Enabled = s1 & s2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Dao.aldigikitaplar(Convert.ToInt32(uyeid.Text), emanetler, kutuphaneid);
            }
            catch
            {
                MessageBox.Show("Üye id boş bırakılamaz!");
            }
            if (emanetler.Count() > 0)
            {
                bkitaplar.Enabled = true;
                kitaplar.Enabled = true;
                int j = 0;
                foreach (var i in emanetler)
                {
                    kitaplar.Items.Add(i.Key.ToString());
                    kitaplar.AutoCompleteCustomSource.Insert(j, i.Key.ToString());
                    j += 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dao.iade(emanetler[Convert.ToInt32(kitaplar.Text)]);
            MessageBox.Show("İade işlemi başarılı!");
            this.Close();
        }

        private void uyeid_TextChanged(object sender, EventArgs e)
        {
            s1 = uyeid.Text.Trim() != "";
            if (s1 == true)
            {
                if (Dao.uyelerem(Convert.ToInt32(uyeid.Text)) == "")
                {
                    errorProvider1.SetError(uyeid, "Böyle bir üye yoktur!");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.SetError(uyeid, "Üye id boş bırakılamaz!");
            }
            buttonactive();
        }

        private void kitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            s2 = kitaplar.Text.Trim() != "";
            if (s2 == false)
            {
                errorProvider1.SetError(kitaplar, "Bu alan boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void uyeid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
