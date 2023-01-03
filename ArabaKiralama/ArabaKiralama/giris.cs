using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaKiralama
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        Baglanti baglanti = new Baglanti();

        private void button1_Click(object sender, EventArgs e)
        {



            baglanti.baglanti_ac();
            MySqlCommand komut =new MySqlCommand("SELECT * FROM yoneticiler WHERE yonetici_kullanici_adi=@yonetici_kullanici_adi AND yonetici_kullanici_sifre=@yonetici_kullanici_sifre", baglanti.baglanti);
            komut.Parameters.AddWithValue("@yonetici_kullanici_adi",textBox1.Text);
            komut.Parameters.AddWithValue("@yonetici_kullanici_sifre", textBox2.Text);
            MySqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                anasayfa anasayfa = new anasayfa();
                anasayfa.Show();
                this.Hide();
                yetki = "yönetici";
            }
            else
            {
                MessageBox.Show("Yönetici bulunamadı");
            }
            oku.Close();
            baglanti.baglanti_kapat();

        }

        private void giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string yetki;
        private void button2_Click_1(object sender, EventArgs e)
        {
            baglanti.baglanti_ac();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM kullanicilar WHERE kullanici_adi=@kullanici_adi AND kullanici_sifre=@kullanici_sifre", baglanti.baglanti);
            komut.Parameters.AddWithValue("@kullanici_adi", textBox1.Text);
            komut.Parameters.AddWithValue("@kullanici_sifre", textBox2.Text);
            MySqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                kullaniciAnasayfa kullaniciAnasayfa = new kullaniciAnasayfa();
                kullaniciAnasayfa.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }
            oku.Close();
            baglanti.baglanti_kapat();
        }
    }
}
