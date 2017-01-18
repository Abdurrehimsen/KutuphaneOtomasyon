using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace KutuphaneOtomasyon
{
    class Dao
    {
        static SqlConnection baglanti = new SqlConnection(@"Data Source=HP-PC;Initial Catalog=Kütüphane;Integrated Security=True");
        static SqlCommand komut;
        static SqlDataAdapter da;
        static DataTable dt;

        public static string[] kategoriler()
        {
            string[] kategoriler = new string[] { "Aile", "Akademil", "Sağlık", "Eğlence", "Ekonomi", "Sanat", "Felsefe", "Şiir", "Tarih", "Bilim-Teknoloji", "Hobi", "Çocuk Kitapları", "Dergi", "İslam", "Din", "Edebiyat", "Müzik", "Politika", "Eğitim", "Roman" };
            return kategoriler;
        }
        public static string[] login(string nick, string password)
        {
            string[] bilgiler = new string[9];
            bool success =false;
            baglanti.Open();
            komut = new SqlCommand("select memurAd, memurSoyad, yetki_id, kutuphane_id from Memur where kullanici_ad ='" + nick + "' and sifre ='" + password + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                bilgiler[0] = dr[0].ToString();
                bilgiler[1] = dr[1].ToString();
                bilgiler[2] = dr[2].ToString();
                bilgiler[3] = dr[3].ToString();
                success = true;
            }
            baglanti.Close();

            if (success == false)
            {
                baglanti.Open();
                komut = new SqlCommand("select uye_id, uyeAd, uyeSoyad, TCno, cinsiyet,ePosta, uyeTel, adres from Uye where kullanici_ad ='" + nick + "' and sifre ='" + password + "'", baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    bilgiler[0] = dr[0].ToString();
                    bilgiler[1] = dr[1].ToString();
                    bilgiler[2] = dr[2].ToString();
                    bilgiler[3] = dr[3].ToString();
                    bilgiler[4] = dr[4].ToString();
                    bilgiler[5] = dr[5].ToString();
                    bilgiler[6] = dr[6].ToString();
                    bilgiler[7] = dr[7].ToString();
                    bilgiler[8] = "uye";
                }
                baglanti.Close();
            }
            return bilgiler;
        }

        public static bool uyeVarmi(string uyead)
        {
            int varmi = -1;
            string sorgu = "select COUNT(*) from Uye where kullanici_ad='"+ uyead +"'";
            komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                varmi = Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
            return varmi == 0;
        }

        public static bool memurVarmi(string memurad)
        {
            int donen = -1;
            string sorgu = "select COUNT(*) from Memur where kullanici_ad='" + memurad + "'";
            komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                donen = Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
            return donen == 0;
        }

        public static int yeniKitap(string bookname, DateTime basımtarih, DateTime gelistarih, string category, string home)
        {
            int id;
            string sorgu = "Insert into Kitap (kitapAd,basimTarih,gelisTarih,kategori,yayinEvi) values (@kitapAd,@basimTarih,@gelisTarih,@kategori,@yayinEvi) SET @ID = SCOPE_IDENTITY()";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kitapAd", bookname);
            komut.Parameters.AddWithValue("@basimTarih", basımtarih);
            komut.Parameters.AddWithValue("@gelisTarih", gelistarih);
            komut.Parameters.AddWithValue("@kategori", category);
            komut.Parameters.AddWithValue("@yayinEvi", home);
            komut.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
            
            baglanti.Open();
            komut.ExecuteNonQuery();
            id = Convert.ToInt32(komut.Parameters["@ID"].Value);
            baglanti.Close();
            return id;
        }

        public static void kitap_yazar(int kitapid, int yazarid)
        {
            string sorgu = "Insert into Kitap_Yazar values (@kitap_id,@yazar_id)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kitap_id", kitapid);
            komut.Parameters.AddWithValue("@yazar_id", yazarid);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static void kutuphane_kitap(int kitapid, int kutupid, int adet)
        {
            string sorgu = "Insert into Kutuphane_Kitap (kitap_id,kutuphane_id,adet) values (@kitap_id,@kutuphane_id,@adet)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kitap_id", kitapid);
            komut.Parameters.AddWithValue("@kutuphane_id", kutupid);
            komut.Parameters.AddWithValue("@adet", adet);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static void kitaplar(DataGridView veriler, int id = -1)
        {
            baglanti.Open();
            string kayit = "";
            if (id == -1)
            {
                kayit = "SELECT k.kitap_id, k.kitapAd, k.basimTarih, k.gelisTarih, k.kategori, k.yayinevi, y.yazarAd from Kitap as k INNER JOIN Kitap_Yazar as c on k.kitap_id = c.kitap_id INNER JOIN Yazar as y on y.yazar_id = c.yazar_id";
            }
            else
            {
                kayit = "SELECT k.kitap_id, k.kitapAd, k.basimTarih, k.gelisTarih, k.kategori, k.yayinevi, y.yazarAd from Kitap as k INNER JOIN Kitap_Yazar as c on k.kitap_id = c.kitap_id INNER JOIN Yazar as y on y.yazar_id = c.yazar_id where k.kitap_id='" + id.ToString() + "'";
            }
            komut = new SqlCommand(kayit, baglanti);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            veriler.DataSource = dt;
            baglanti.Close();
        }

        public static string kitaplarem(int id)
        {
            baglanti.Open();
            string kayit = "", kitapad ="" ;            
            kayit = "SELECT * from Kitap where kitap_id='" + id + "'";
            komut = new SqlCommand(kayit, baglanti);
            SqlDataReader oku1 = komut.ExecuteReader();
            while (oku1.Read())
            {
                kitapad = oku1[1].ToString();
            }
            baglanti.Close();
            return kitapad;
        }

        public static void kitapSil(int id)
        {
            baglanti.Open();
            string silmeSorgusu = "DELETE from Kitap where kitap_id=@kitap_id";
            komut = new SqlCommand(silmeSorgusu, baglanti);
            komut.Parameters.AddWithValue("@kitap_id", id);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi...");
            baglanti.Close();
        }

        public static void yazarlar(DataGridView veriler, int id = -1)
        {
            baglanti.Open();
            string kayit = "";
            if (id == -1)
            {
                kayit = "SELECT * from Yazar";
            }
            else
            {
                kayit = "SELECT * from Yazar where yazar_id='" + id + "'";
            }
            komut = new SqlCommand(kayit, baglanti);
            da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            veriler.DataSource = dt;
            baglanti.Close();
        }

        public static int yazarid(string yazarad)
        {
            baglanti.Open();
            int id=-1;
            string kayit = "SELECT * from Yazar where yazarAd='" + yazarad + "'";
            komut = new SqlCommand(kayit, baglanti);
            SqlDataReader oku = komut.ExecuteReader(); while (oku.Read())
            {
                id = Convert.ToInt32(oku[0]);   
            }
            baglanti.Close();
            return id;
        }

        public static void yazarlarilistele(ComboBox cb)
        {
            baglanti.Open();
            string kayit = "SELECT yazarAd from Yazar";
            komut = new SqlCommand(kayit, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            int i = 0;
            while (oku.Read())
            {
                cb.Items.Add(oku[0].ToString());
                cb.AutoCompleteCustomSource.Insert(i, oku[0].ToString());
                i += 1;
            }
            baglanti.Close();
        }

        public static void gelismisKitapArama(string kitapad, string yazarad, string kategori, string kutuphane, string orderby, DataGridView dgv)
        {
            string kayit = "SELECT k.kitap_id, k.kitapAd, k.kategori, y.yazarAd, ku.kutuphaneAd, kk.adet from Kitap as k INNER JOIN Kitap_Yazar as ky on ky.kitap_id = k.kitap_id INNER JOIN Yazar as y on y.yazar_id = ky.yazar_id INNER JOIN Kutuphane_Kitap as kk on kk.kitap_id = k.kitap_id INNER JOIN Kutuphane as ku on kk.kutuphane_id = ku.kutuphane_id where 1=1 ";
            if (kitapad.Trim() != "")
            {
                kayit += "and k.kitapAd like '%" + kitapad + "%' ";
            }
            if (kategori.Trim() != "")
            {
                kayit += "and k.kategori='" + kategori + "' ";
            }
            if (yazarad.Trim() != "")
            {
                kayit += "and y.yazarAd='" + yazarad + "' ";
            }
            if (kutuphane.Trim() != "")
            {
                kayit += "and ku.kutuphaneAd='" + kutuphane + "' ";
            }
            baglanti.Open();
            kayit += " Order by " + orderby;
            komut = new SqlCommand(kayit, baglanti);
            da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            baglanti.Close();
        }

        public static bool YeniYazar(string yazarad, string yazartip)
        {
            bool s;
            string sorgu = "Insert into Yazar (yazarAd,yazarTip) values (@yazarAd,@yazarTip)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@yazarAd", yazarad);
            komut.Parameters.AddWithValue("@yazarTip", yazartip);

            baglanti.Open();
            try
            {
                komut.ExecuteNonQuery();
                s = true;
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Hata oluştu. Lütfen bilgileri kontrol ediniz!");
                s = false;
                baglanti.Close();
            }
            return s;
        }

        public static void YazarDuzenle(int ID, string yadi, string ytipi)
        {
            baglanti.Open();
            string sorgu = "update Yazar set yazarAd=@yazarAd,yazarTip=@yazarTip where yazar_id=@yazar_id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@yazarAd", yadi);
            komut.Parameters.AddWithValue("@yazarTip", ytipi);
            komut.Parameters.AddWithValue("@yazar_id", ID);            
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static void yazarSil(int id)
        {
            baglanti.Open();
            string silmeSorgusu = "DELETE from Yazar where yazar_id=@yazar_id";
            komut = new SqlCommand(silmeSorgusu, baglanti);
            komut.Parameters.AddWithValue("@yazar_id", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static string kutuphanead(int id)
        {
            string ad = "";
            baglanti.Open();
            string kayit = "SELECT * from Kutuphane where kutuphane_id='" + id + "'";
            komut = new SqlCommand(kayit, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            int i = 0;
            if (oku.Read())
            {
                ad = oku[1].ToString();
            }
            baglanti.Close();
            return ad;
        }

        public static void kutuphaneler(DataGridView veriler, int x = -1)
        {
            string kayit = "";
            if (x == -1)
            {
                kayit = "SELECT * from Kutuphane";
            }
            else
            {
                kayit = "SELECT * from Kutuphane where kutuphane_id='"+ x + "'";
            }
            komut = new SqlCommand(kayit, baglanti);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            veriler.DataSource = dt;
            baglanti.Close();
        }

        public static void kutuphanesec(ComboBox kutuphane)
        {
            baglanti.Open();
            string kayit = "SELECT * from Kutuphane";
            komut = new SqlCommand(kayit, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            int i = 0;
            while (oku.Read())
            {
                kutuphane.Items.Add(oku[1].ToString());
                kutuphane.AutoCompleteCustomSource.Insert(i, oku[1].ToString());
                i += 1;
            }
            baglanti.Close();
        }

        public static int kutuphaneid(string kutupad)
        {
            int id = -1;
            baglanti.Open();
            string kayit = "SELECT kutuphane_id from Kutuphane where kutuphaneAd='"+ kutupad + "'";
            komut = new SqlCommand(kayit, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                id = Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
            return id;
        }

        public static string[] kutuphanelistesi()
        {
            string[] list = new string[40];
            baglanti.Open();
            string kayit = "SELECT kutuphaneAd from Kutuphane";
            komut = new SqlCommand(kayit, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            int i = 0;
            while (oku.Read())
            {
                list[i] = oku[0].ToString();
                i += 1;                
            }
            baglanti.Close();
            return list;
        }
    

        public static void kutuphaneguncelle(string ad, string adres, string id)
        {
            baglanti.Open();
            string sorgu = "update Kutuphane set kutuphaneAd=@kutuphaneAd,adres=@adres where kutuphane_id=@kutuphane_id";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kutuphaneAd", ad);
            komut.Parameters.AddWithValue("@adres", adres);
            komut.Parameters.AddWithValue("@kutuphane_id", id);
            komut.ExecuteNonQuery();
            baglanti.Close();            
        }

        public static void yeniKutuphane(string ad, string adres)
        {
            baglanti.Open();
            string sorgu = "Insert into Kutuphane (kutuphaneAd,adres) values (@kutuphaneAd,@adres)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kutuphaneAd", ad);
            komut.Parameters.AddWithValue("@adres", adres);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public static void kutuphanesil(int id)
        {
            baglanti.Open();
            string silmeSorgusu = "DELETE from Kutuphane where kutuphane_id=@kutuphane_id";
            SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
            silKomutu.Parameters.AddWithValue("@kutuphane_id", id);
            silKomutu.ExecuteNonQuery();
            baglanti.Close();
        }

        public static bool yeniUye(string name, string surname, string tel, string cinsiyet, string mail, string nickname, string password, string adres, string Tc)
        {
            bool s;
            string sorgu = "Insert into Uye (uyeAd,uyeSoyad,uyeTel,cinsiyet,ePosta,kullanici_ad,sifre,adres,TCno) values (@uyeAd,@uyeSoyad,@uyeTel,@cinsiyet,@ePosta,@kullanici_ad,@sifre,@adres,@TCno)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@uyeAd", name);
            komut.Parameters.AddWithValue("@uyeSoyad", surname);
            komut.Parameters.AddWithValue("@uyeTel", tel);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            komut.Parameters.AddWithValue("@ePosta", mail);
            komut.Parameters.AddWithValue("@kullanici_ad", nickname);
            komut.Parameters.AddWithValue("@sifre", password);
            komut.Parameters.AddWithValue("@adres", adres);
            komut.Parameters.AddWithValue("@TCno", Tc);

            baglanti.Open();
            try
            {
                komut.ExecuteNonQuery();
                s = true;
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Hata oluştu. Lütfen bilgileri kontrol ediniz!");
                s = false;
                baglanti.Close();
            }
            return s;
        }

        public static void uyeler(DataGridView veriler, int id = -1)
        {
            baglanti.Open();
            string kayit = "";
            if (id == -1) {
                kayit = "SELECT * from Uye";
            }
            else
            {
                kayit = "SELECT * from Uye where uye_id='" + id + "'";
            }
            komut = new SqlCommand(kayit, baglanti);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            veriler.DataSource = dt;
            baglanti.Close();
        }

        public static string uyelerem(int id)
        {
            baglanti.Open();
            string kayit = "", uyead = "";
            kayit = "SELECT * from Uye where uye_id='" + id + "'";            
            komut = new SqlCommand(kayit, baglanti);
            SqlDataReader oku1 = komut.ExecuteReader();
            while (oku1.Read())
            {
                uyead = oku1[1].ToString();
                uyead += " ";
                uyead += oku1[2].ToString();
            }
            baglanti.Close();
            return uyead;
        }

        public static void uyeSil(int id)
        {
            baglanti.Open();
            string silmeSorgusu = "DELETE from Uye where uye_id=@uye_id";
            SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
            silKomutu.Parameters.AddWithValue("@uye_id", id);
            silKomutu.ExecuteNonQuery();
            baglanti.Close();
        }

        public static void uyeGuncelle(int uyeid, String name, String surname, String tcnumber, String sex, String email, String telno, String place)
        {
            baglanti.Open();
            string kayit = "update Uye set uyeAd=@uyeAd,uyeSoyad=@uyeSoyad,uyeTel=@telefon,cinsiyet=@cinsiyet,ePosta=@ePosta,adres=@adres,TCno=@TCno where uye_id=@uye_id";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@uyeAd", name);
            komut.Parameters.AddWithValue("@uyeSoyad", surname);
            komut.Parameters.AddWithValue("@telefon", telno);
            komut.Parameters.AddWithValue("@cinsiyet", sex);
            komut.Parameters.AddWithValue("@ePosta", email);
            komut.Parameters.AddWithValue("@adres", place);
            komut.Parameters.AddWithValue("@TCno", tcnumber);
            komut.Parameters.AddWithValue("@uye_id", uyeid);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static void memurlar(DataGridView veriler, int id = -1)
        {
            baglanti.Open();
            string kayit = "";
            if (id == -1)
            {
                kayit = "SELECT m.memur_id, m.memurAd, m.memurSoyad, m.TCno, m.memurTel, m.cinsiyet, m.ePosta, k.kutuphaneAd from Memur as m INNER JOIN Kutuphane as k ON m.kutuphane_id = k.kutuphane_id";
            }
            else
            {
                kayit = "SELECT m.memur_id, m.memurAd, m.memurSoyad, m.memurTel, m.cinsiyet, m.ePosta, m.TCno, k.kutuphaneAd from Memur as m INNER JOIN Kutuphane as k ON m.kutuphane_id = k.kutuphane_id where m.memur_id='" + id +"'";
            }
            komut = new SqlCommand(kayit, baglanti);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            veriler.DataSource = dt;
            baglanti.Close();
        }

        public static bool yeniMemur(string name, string surname, string tel, string cinsiyet, string mail, string nickname, string password, string Tc, string kutupad)
        {
            bool s;
            int kutupid = -1;
            baglanti.Open();
            string kayit = "SELECT * from Kutuphane where kutuphaneAd='" + kutupad + "'";
            komut = new SqlCommand(kayit, baglanti);
            SqlDataReader oku1 = komut.ExecuteReader();
            while (oku1.Read())
            {
                kutupid = Convert.ToInt32(oku1[0]);
            }
            baglanti.Close();
            string sorgu = "Insert into Memur (memurAd,memurSoyad,memurTel,cinsiyet,ePosta,kullanici_Ad,sifre,TCno,kutuphane_id,yetki_id) values (@memurAd,@memurSoyad,@memurTel,@cinsiyet,@ePosta,@kullanici_Ad,@sifre,@TCno,@kutuphane_id,@yetki_id)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@memurAd", name);
            komut.Parameters.AddWithValue("@memurSoyad", surname);
            komut.Parameters.AddWithValue("@memurTel", tel);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            komut.Parameters.AddWithValue("@ePosta", mail);
            komut.Parameters.AddWithValue("@kullanici_Ad", nickname);
            komut.Parameters.AddWithValue("@sifre", password);
            komut.Parameters.AddWithValue("@TCno", Tc);
            komut.Parameters.AddWithValue("@kutuphane_id", kutupid);
            komut.Parameters.AddWithValue("@yetki_id", 1);

            baglanti.Open();
            try
            {
                komut.ExecuteNonQuery();
                s = true;
            }
            catch
            {
                MessageBox.Show("Hata oluştu. Lütfen bilgileri kontrol ediniz!");
                s = false;
            }

            baglanti.Close();
            return s;
        }

        public static void memurGuncelle(int memur_id, string memurAd, string memurSoyad, string TCno, string memurTel, string cinsiyet, string ePosta, string kutuphaneAd)
        {
            int kutupid = -1;
            baglanti.Open();
            string kayit = "SELECT * from Kutuphane where kutuphaneAd='" + kutuphaneAd + "'";
            komut = new SqlCommand(kayit, baglanti);
            SqlDataReader oku1 = komut.ExecuteReader();
            while (oku1.Read())
            {
                kutupid = Convert.ToInt32(oku1[0]);
            }
            baglanti.Close();

            baglanti.Open();
            kayit = "update Memur set memurAd=@memurAd,memurSoyad=@memurSoyad,TCno=@TCno,memurTel=@memurTel,cinsiyet=@cinsiyet,ePosta=@ePosta,kutuphane_id=@kutuphane_id where memur_id=@memur_id";
            komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@memurAd", memurAd);
            komut.Parameters.AddWithValue("@memurSoyad", memurSoyad);
            komut.Parameters.AddWithValue("@TCno", TCno);
            komut.Parameters.AddWithValue("@memurTel", memurTel);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            komut.Parameters.AddWithValue("@ePosta", ePosta);
            komut.Parameters.AddWithValue("@kutuphane_id", kutupid);
            komut.Parameters.AddWithValue("@memur_id", memur_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static void memurSil(int id)
        {
            baglanti.Open();
            string silmeSorgusu = "DELETE from Uye where uye_id=@uye_id";
            SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
            silKomutu.Parameters.AddWithValue("@uye_id", id);
            silKomutu.ExecuteNonQuery();
            baglanti.Close();
        }

        public static bool yeniEmanet(int uyeid, int kitapid, int kutupid)
        {
            bool s;
            DateTime today = DateTime.Today;
            string sorgu = "Insert into Emanet (üye_id,kitap_id,kutuphane_id,emanetTarih,teslimTarih,iade) values (@üye_id,@kitap_id,@kutuphane_id,@emanetTarih,@teslimTarih, @iade)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@üye_id", uyeid);
            komut.Parameters.AddWithValue("@kitap_id", kitapid);
            komut.Parameters.AddWithValue("@kutuphane_id", kutupid);
            komut.Parameters.AddWithValue("@emanetTarih", today.Date);
            komut.Parameters.AddWithValue("@teslimTarih", today.AddDays(15).Date);
            komut.Parameters.AddWithValue("@iade", 0);

            baglanti.Open();
            try
            {
                komut.ExecuteNonQuery();
                s = true;
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.ToString());
                s = false;
            }
            baglanti.Close();
            return s;
        }

        public static bool uyealabilir(int id)
        {
            bool sonuc;
            baglanti.Open();
            string sorgu = "SELECT count(iade) From Emanet where iade=0 and üye_id='" + id + "'";
            komut = new SqlCommand(sorgu, baglanti);            
            int sayi = (int) komut.ExecuteScalar();
            baglanti.Close();
            if(sayi < 2)
            {
                sonuc = true;
            }
            else
            {
                sonuc = false;
            }
            return sonuc;
        }

        public static bool[] kitapkaldimi(int kitapid, int kutupid)
        {
            bool varmi = true, verilebilirmi = true;
            int sayi = -1;
            int sayi2 = -1;
            baglanti.Open();
            string sorgu = "SELECT adet From Kutuphane_Kitap where kitap_id='" + kitapid + "' and kutuphane_id='" + kutupid + "'";
            komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                try
                {
                    sayi = Convert.ToInt32(dr[0]);
                }
                catch
                {
                    varmi = false;
                }
            }
            else
            {
                varmi = false;
            }
            baglanti.Close();

            if (varmi != false)
            {
                baglanti.Open();
                sorgu = "select count(emanet_id)emanet from Emanet where iade=0 and kitap_id='" + kitapid + "' and kutuphane_id='" + kutupid + "'";
                komut = new SqlCommand(sorgu, baglanti);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    sayi2 = Convert.ToInt32(dr[0]);
                }

                verilebilirmi = sayi2 < sayi;
                baglanti.Close();
            }
            bool[] array = new bool[2] { varmi, verilebilirmi };
            return array;
        }

        public static void aldigikitaplar(int uyeid, Dictionary<int,int> ab, int kutupid = -1)
        {
            string sorgu;
            if (kutupid == -1)
            {
                sorgu = "select emanet_id, kitap_id from Emanet where üye_id='" + uyeid + "' and iade=0";
            }
            else
            {
                sorgu = "select emanet_id, kitap_id from Emanet where üye_id='" + uyeid + "' and iade=0 and kutuphane_id='"+ kutupid.ToString() +"'";
            }
            baglanti.Open();
            komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ab[Convert.ToInt32(dr[1])] = Convert.ToInt32(dr[0]);
            }
            baglanti.Close();
        }

        public static void iade(int emanetid)
        {
            baglanti.Open();
            DateTime today = DateTime.Today;
            int iade = 1;
            string kayit = "update Emanet set iade=@iade,teslimTarih=@teslimTarih where emanet_id='"+ emanetid +"'";
            komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@iade", iade);
            komut.Parameters.AddWithValue("@teslimTarih", today.Date);
            try
            {
                komut.ExecuteNonQuery();
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
            baglanti.Close();
        }

        public static void aldigikitaplar(DataGridView veriler, int uyeid, string bicim, string durum, string artan)
        {
            baglanti.Open();
            string kayit = "select u.uyeAd, u.uyeSoyad, ki.kitapAd, e.emanetTarih, e.teslimTarih, e.iade, ku.kutuphaneAd from Uye as u INNER JOIN Emanet as e on u.uye_id = e.üye_id INNER JOIN Kutuphane as ku on e.kutuphane_id = ku.kutuphane_id INNER JOIN Kitap as ki on ki.kitap_id = e.kitap_id where u.uye_id = " + uyeid.ToString() + bicim + durum + artan;            
            komut = new SqlCommand(kayit, baglanti);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            veriler.DataSource = dt;
            baglanti.Close();
        }

        public static Dictionary<string,string> kitapsayisi()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string sorgu = "select ku.kutuphaneAd, COUNT(*) from Kitap as k INNER JOIN Kutuphane_Kitap as kk on k.kitap_id = kk.kitap_id INNER JOIN Kutuphane as ku on kk.kutuphane_id = ku.kutuphane_id group by ku.kutuphaneAd";
            baglanti.Open();
            komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                dict.Add(dr[0].ToString(), dr[1].ToString());
            }
            baglanti.Close();
            return dict;
        }
    }
}
