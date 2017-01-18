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
    public partial class YazarDüzenle : Form
    {
        int ID;
        public YazarDüzenle(string id, string ad, string tip)
        {
            InitializeComponent();
            ID = Int32.Parse(id);
            yadı.Text = ad;
            ytipi.Text = tip;
        }
        bool s1 = true, s2 = true;
        private void button1_Click(object sender, EventArgs e)
        {
            Dao.YazarDuzenle(ID, yadı.Text, ytipi.Text);
  
            MessageBox.Show("Yazar Güncellendi");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buttonactive()
        {
            button1.Enabled = s1 & s2;
        }

        private void YazarDüzenle_Load(object sender, EventArgs e)
        {
            string[] kategoriler = Dao.kategoriler();
            for (int i = 0; i < kategoriler.Length; i++)
            {
                ytipi.Items.Add(kategoriler[i]);
            }
            button1.Enabled = true;
        }

        private void ytipi_TextChanged(object sender, EventArgs e)
        {
            s2 = ytipi.Text.Trim() != "";
            if (s2 == false)
            {
                errorProvider1.SetError(ytipi, "Yazar Tipi adı boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void yadı_TextChanged(object sender, EventArgs e)
        {
            s1 = yadı.Text.Trim() != "";
            if(s1 == false)
            {
                errorProvider1.SetError(yadı, "Yazar adı boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }
    }
}
