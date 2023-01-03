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
using MySql.Data; 
namespace ArabaKiralama
{
    public partial class frmMusteriListele : Form
    {
        arackayit arackiralama = new arackayit();
        public frmMusteriListele()
        {
            InitializeComponent();
        }
        MySqlDataAdapter adapter; 
        Baglanti baglanti = new Baglanti();
        DataSet ds;
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            kullanicilari_getir();
        }

        private void kullanicilari_getir()
        {
            baglanti.kontrol();
            adapter = new MySqlDataAdapter("Select * From kullanicilar", baglanti.baglanti);
            ds = new DataSet();
            adapter.Fill(ds, "kullanicilar");
            dataGridView1.DataSource = ds.Tables["kullanicilar"];
            baglanti.baglanti_kapat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string cumle = "update kullanicilar set kullanici_ad=@kullanici_ad, kullanici_soyad=@kullanici_soyad, kullanici_adi=@kullanici_adi, kullanici_sifre=@kullanici_sifre, kullanici_telefon=@kullanici_telefon, kullanici_email=@kullanici_email, kullanici_adres=@kullanici_adres, kullanici_sehir=@kullanici_sehir, kullanici_ilce=@kullanici_ilce WHERE kullanici_tc='" + txtTC.Text + "'";
            MySqlCommand komut2 = new MySqlCommand();
             
            komut2.Parameters.AddWithValue("@kullanici_ad", txtAd.Text);
            komut2.Parameters.AddWithValue("@kullanici_soyad", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@kullanici_telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@kullanici_adi", txtKullaniciAdi.Text);
            komut2.Parameters.AddWithValue("@kullanici_sifre", txtSifre.Text);
            komut2.Parameters.AddWithValue("@kullanici_email", txtEmail.Text);
            komut2.Parameters.AddWithValue("@kullanici_sehir", txtSehir.Text);
            komut2.Parameters.AddWithValue("@kullanici_ilce", txtIlce.Text);
            komut2.Parameters.AddWithValue("@kullanici_adres", txtAdres.Text);
            arackiralama.ekle_sil_guncelle(komut2, cumle);
            kullanicilari_getir();
            MessageBox.Show("kayıt guncellendi");
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            

        }

        private void frmMusteriListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTC.Text = satır.Cells[1].Value.ToString();
            txtAd.Text = satır.Cells[2].Value.ToString();
            txtSoyad.Text = satır.Cells[3].Value.ToString();
            txtTelefon.Text = satır.Cells[6].Value.ToString();
            txtKullaniciAdi.Text = satır.Cells[4].Value.ToString();
            txtSifre.Text = satır.Cells[5].Value.ToString();
            txtEmail.Text = satır.Cells[7].Value.ToString();
            txtSehir.Text = satır.Cells[9].Value.ToString();
            txtIlce.Text = satır.Cells[10].Value.ToString();
            txtAdres.Text = satır.Cells[8].Value.ToString();
        }
    }
}
