using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ArabaKiralama
{
    public partial class musterikayit : Form
    {
        arackayit Arac_kiralama = new arackayit();
        public musterikayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        } 

        private void button1_Click(object sender, EventArgs e)
        {

                string cumle = "insert into kullanicilar (kullanici_tc,kullanici_ad,kullanici_soyad, kullanici_adi, kullanici_sifre, kullanici_telefon, kullanici_email, kullanici_adres, kullanici_sehir, kullanici_ilce) values(@tc,@ad,@soyad,@kullaniciadi,@kullanicisifre,@telefon,@email,@adres,@sehir,@ilce)";
                MySqlCommand komut2 = new MySqlCommand();
                komut2.Parameters.AddWithValue("@tc", txtTC.Text);
                komut2.Parameters.AddWithValue("@ad", txtAd.Text);
                komut2.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut2.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
                komut2.Parameters.AddWithValue("@kullanicisifre", txtSifre.Text);
                komut2.Parameters.AddWithValue("@email", txtEmail.Text);
                komut2.Parameters.AddWithValue("@sehir", txtSehir.Text);
                komut2.Parameters.AddWithValue("@ilce", txtIlce.Text);
                komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
                Arac_kiralama.ekle_sil_guncelle(komut2, cumle);
                MessageBox.Show("kayıt eklendi");
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";

        }

        private void musterikayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void musterikayit_Load(object sender, EventArgs e)
        {

        }
    }
}
