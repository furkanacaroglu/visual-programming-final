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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace ArabaKiralama
{
    public partial class frmSozlesme : Form
    {
        public frmSozlesme()
        {
            InitializeComponent();
        }
        arackayit arac = new arackayit();
       
        private void frmSozlesme_Load(object sender, EventArgs e)
        {
          
            
            Bos_araclar();
            Yenile();

        }

        private void Bos_araclar()
        {
            string sorgu2 = "select * from arackayit where durumu='Boş'";
            arac.BosAraclar(comboaraclar, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select * from sozlesme";
            MySqlDataAdapter adtr2 = new MySqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2,sorgu3);
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboaraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from arackayit where plaka like '" + comboaraclar.SelectedItem + "'";
            arac.combodangetir(comboaraclar, txtmarka, txtmodel, txtrenk, sorgu2);
        }

        private void combosekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from arackayit where plaka like '" + comboaraclar.SelectedItem + "'";
            arac.ucrethesapla(combosekli,txtucret,sorgu2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(datecikis.Text) - DateTime.Parse(dategiris.Text);
            int day = gun.Days;
            txtgun.Text = day.ToString();
            txttutar.Text = (day * int.Parse(txtucret.Text)).ToString();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            datecikis.Text = DateTime.Now.ToShortDateString();
            dategiris.Text = DateTime.Now.ToShortDateString();
            combosekli.Text = "";
            txtucret.Text = "";
            txttutar.Text = "";
            txtgun.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into sozlesme(tc,adsoyad,telefon,ehliyetno,e_tarih,plaka,marka,model,renk,kirasekli,kiraucreti,gun,tutar,ctarihi,gtarihi) values(@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@plaka,@marka,@model,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@ctarihi,@gtarihi)";
            MySqlCommand komut2 = new MySqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtehliyetno.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtehliyett.Text);
            komut2.Parameters.AddWithValue("@plaka", comboaraclar.Text);
            komut2.Parameters.AddWithValue("@marka", txtmarka.Text);
            komut2.Parameters.AddWithValue("@model", txtmodel.Text);
            komut2.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", combosekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", txtucret.Text);
            komut2.Parameters.AddWithValue("@gun", txtgun.Text);
            komut2.Parameters.AddWithValue("@tutar", txttutar.Text);
            komut2.Parameters.AddWithValue("@ctarihi", datecikis.Text);
            komut2.Parameters.AddWithValue("@gtarihi", dategiris.Text);
            arac.ekle_sil_guncelle(komut2, sorgu2);

            string sorgu3 = "update arackayit set durumu='Dolu' where plaka='" + comboaraclar.Text + "'";
            MySqlCommand komut3 = new MySqlCommand();
            arac.ekle_sil_guncelle(komut3, sorgu3);
            comboaraclar.Items.Clear();
            Bos_araclar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboaraclar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme eklendi");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txttcara.Text == "")
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select * from kullanicilar where kullanici_tc like '" + txttcara.Text + "'";
            arac.Tc_ara(txttcara, txtTC, txtAd, txtTelefon, sorgu2);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update sozlesme set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyetno=@ehliyetno,e_tarih=@e_tarih,marka=@marka,model=@model,renk=@renk,kirasekli=@kirasekli,	kiraucreti=@kiraucreti,gun=@gun,tutar=@tutar,ctarihi=@ctarihi,gtarihi=@gtarihi where plaka=@plaka";
            MySqlCommand komut2 = new MySqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtehliyetno.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtehliyett.Text);
            komut2.Parameters.AddWithValue("@plaka", comboaraclar.Text);
            komut2.Parameters.AddWithValue("@marka", txtmarka.Text);
            komut2.Parameters.AddWithValue("@model", txtmodel.Text);
            komut2.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", combosekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", txtucret.Text);
            komut2.Parameters.AddWithValue("@gun", txtgun.Text);
            komut2.Parameters.AddWithValue("@tutar", txttutar.Text);
            komut2.Parameters.AddWithValue("@ctarihi", datecikis.Text);
            komut2.Parameters.AddWithValue("@gtarihi", dategiris.Text);
            arac.ekle_sil_guncelle(komut2, sorgu2);
           
            comboaraclar.Items.Clear();
            Bos_araclar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboaraclar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme güncellendi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTC.Text = satir.Cells[0].Value.ToString();
            txtAd.Text = satir.Cells[1].Value.ToString();
            txtTelefon.Text = satir.Cells[2].Value.ToString();
            txtehliyetno.Text = satir.Cells[3].Value.ToString();
            txtehliyett.Text = satir.Cells[4].Value.ToString();
            comboaraclar.Text = satir.Cells[5].Value.ToString();
            txtmarka.Text = satir.Cells[6].Value.ToString();
            txtmodel.Text = satir.Cells[7].Value.ToString();
            txtrenk.Text = satir.Cells[8].Value.ToString();
            combosekli.Text = satir.Cells[9].Value.ToString();
            txtucret.Text = satir.Cells[10].Value.ToString();
            txtgun.Text = satir.Cells[11].Value.ToString();
            txttutar.Text = satir.Cells[12].Value.ToString();
            datecikis.Text = satir.Cells[13].Value.ToString();
            dategiris.Text = satir.Cells[14].Value.ToString();
            
            
        }
        
        private void btnteslim_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtextra.Text)>=0 || int.Parse(txtextra.Text)<0)
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(satir.Cells["tutar"].Value.ToString());
                DateTime cikis = DateTime.Parse(satir.Cells["ctarihi"].Value.ToString());
                TimeSpan gun = bugun - cikis;
                int _gun = gun.Days;
                int toplamtutar = _gun * ucret;
                string sorgu1 = "delete from sozlesme where plaka='" + satir.Cells["plaka"].Value.ToString() + "'";
                MySqlCommand komut = new MySqlCommand();
                arac.ekle_sil_guncelle(komut,sorgu1);
                string sorgu2 = "update arackayit set durumu='Boş' where plaka='" + satir.Cells["plaka"].Value.ToString() + "'";
                MySqlCommand komut3 = new MySqlCommand();
                arac.ekle_sil_guncelle(komut3, sorgu2);

                string sorgu3 = "insert into satis(tc,adsoyad,plaka,marka,model,renk,gun,fiyat,tutar,ctarihi,gtarihi) values(@tc,@adsoyad,@plaka,@marka,@model,@renk,@gun,@fiyat,@tutar,@ctarihi,@gtarihi)";
                MySqlCommand komut2 = new MySqlCommand();
                komut2.Parameters.AddWithValue("@tc", satir.Cells["tc"].Value.ToString());
                komut2.Parameters.AddWithValue("@adsoyad", satir.Cells["adsoyad"].Value.ToString());
                komut2.Parameters.AddWithValue("@plaka", satir.Cells["plaka"].Value.ToString());
                komut2.Parameters.AddWithValue("@marka", satir.Cells["marka"].Value.ToString());
                komut2.Parameters.AddWithValue("@model", satir.Cells["model"].Value.ToString());
                komut2.Parameters.AddWithValue("@renk", satir.Cells["renk"].Value.ToString());
                komut2.Parameters.AddWithValue("@gun", _gun);
                komut2.Parameters.AddWithValue("@fiyat", toplamtutar);
                komut2.Parameters.AddWithValue("@tutar", ucret);
                komut2.Parameters.AddWithValue("@ctarihi", cikis.ToString("yyyy-MM-dd H:i:s"));
                komut2.Parameters.AddWithValue("@gtarihi", DateTime.Now.ToShortDateString());
                arac.ekle_sil_guncelle(komut2, sorgu3);
                MessageBox.Show("Araç teslim edildi");
                comboaraclar.Text = "";
                comboaraclar.Items.Clear();
                Bos_araclar();
                Yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboaraclar.Text = "";
                Temizle();
                txtextra.Text = "";
            }
            else if(txtextra.Text == "")
            {
                MessageBox.Show("Lütfen seçim yapınız", "Uyarı");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime donus = DateTime.Parse(satir.Cells["gtarihi"].Value.ToString());
            int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunfarki = bugun - donus;
            int _gunfarki = gunfarki.Days;
            int ucretfarki;
            ucretfarki = _gunfarki * ucret;
            txtextra.Text=ucretfarki.ToString();
        }

        private void frmSozlesme_FormClosing(object sender, FormClosingEventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            this.Hide();
            anasayfa.Show();
        }
    }
}
