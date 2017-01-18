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
    public partial class Giris : Form
    {
        public UyeOl uyeol;
        public Yonetici yon;
        public Giris()
        {
            InitializeComponent();
            uyeol = new UyeOl();
            yon = new Yonetici();
            yon.frm1 = this;
            uyeol.frm1 = this;
        }   
        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] bilgiler = Dao.login(nick.Text, password.Text);
            if(bilgiler[2] == "0")
            {
                
                this.Hide();  
                yon.mad.Text = "Hoşgeldiniz " + bilgiler[0] + " " + bilgiler[1];
                yon.Show();
            }
            else if(bilgiler[2] == "1")
            {
                Memur mem = new Memur(Convert.ToInt32(bilgiler[2]));
                mem.kad.Text = Dao.kutuphanead(Convert.ToInt32(bilgiler[3]));
                mem.mad.Text = "Hoşgeldiniz " + bilgiler[0] + " " + bilgiler[1];
                mem.Show();
                this.Hide();
            }
            else if(bilgiler[8] == "uye")
            {
                Uye uye = new KutuphaneOtomasyon.Uye(bilgiler[0], bilgiler[1], bilgiler[2], bilgiler[3], bilgiler[4], bilgiler[5], bilgiler[6], bilgiler[7]);
                uye.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                temizle();
            }
        }
        public void temizle()
        {
            nick.Text = "";
            password.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeol.ShowDialog();
        }
    }
}
