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
    public partial class YeniYazar : Form
    {
        public YeniYazar()
        {
            InitializeComponent();
        }
        private bool s1 = false, s2 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            bool s = Dao.YeniYazar(yadı.Text, ytipi.Text);

            if (s == true)
            {
                MessageBox.Show("Kaydınız Başarıyla oluşturulmuştur");
                this.Close();
            }

        }

        private void buttonactive()
        {
            button1.Enabled = s1 & s2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yadı_TextChanged(object sender, EventArgs e)
        {
            s1 = yadı.Text.Trim() != "";
            if (s1 == false)
            {
                errorProvider1.SetError(yadı, "Yazar ad boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void ytipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            s2 = ytipi.Text.Trim() != "";
            if (s2 == false)
            {
                errorProvider1.SetError(ytipi, "Yazar tipi boş bırakılamaz!");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonactive();
        }

        private void YeniYazar_Load(object sender, EventArgs e)
        {
            string[] kategoriler = Dao.kategoriler();
            for (int i = 0; i < kategoriler.Length; i++)
            {
                ytipi.Items.Add(kategoriler[i]);
            }
            button1.Enabled = false;
        }
    }
}
