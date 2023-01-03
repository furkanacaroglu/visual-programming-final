using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;

namespace ArabaKiralama
{
    public class arackayit
    {
        Baglanti baglanti = new Baglanti();

        DataTable tablo;
        MySqlDataAdapter adtr;
        public void ekle_sil_guncelle(MySqlCommand komut, string sorgu)
        {
            baglanti.kontrol();
            komut.Connection = baglanti.baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.baglanti_kapat();
        }
        
        public DataTable listele(MySqlDataAdapter adtr2, string sorgu)
        {
            tablo = new DataTable();
            adtr = new MySqlDataAdapter(sorgu, baglanti.baglanti);
            adtr.Fill(tablo);
            baglanti.baglanti_kapat();
            return tablo;
        }
        public void BosAraclar(ComboBox combo,string sorgu)
        {
            baglanti.baglanti_ac();
            MySqlCommand komut = new MySqlCommand(sorgu,baglanti.baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            baglanti.baglanti_kapat();
        }
        public void Tc_ara(TextBox tcara,TextBox tc, TextBox txtAd, TextBox txtTelefon, string sorgu)
        {
            baglanti.baglanti_ac();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti.baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["kullanici_tc"].ToString();
                txtAd.Text = read["kullanici_ad"].ToString();
                txtTelefon.Text = read["kullanici_telefon"].ToString();
            }
            baglanti.baglanti_kapat();
        }
        public void ucrethesapla(ComboBox combosekli,TextBox txtucret, string sorgu)
        {
            baglanti.baglanti_ac();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti.baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (combosekli.SelectedIndex == 0) txtucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 1).ToString();
                if (combosekli.SelectedIndex == 1) txtucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.80).ToString();
                if (combosekli.SelectedIndex == 2) txtucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.70).ToString();
            }
            baglanti.baglanti_kapat();
        }
        public void combodangetir(ComboBox comboaraclar,TextBox txtmarka, TextBox txtmodel, TextBox txtrenk, string sorgu)
        {
            baglanti.baglanti_ac();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti.baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtmarka.Text = read["marka"].ToString();
                txtmodel.Text = read["model"].ToString();
                txtrenk.Text = read["renk"].ToString();
            }
            baglanti.baglanti_kapat();
        }
        public void satishesapla(Label lbl)
        {
            baglanti.baglanti_ac();
            MySqlCommand komut = new MySqlCommand("select sum(tutar) from satis",baglanti.baglanti);
            lbl.Text = "Toplam Tutar" + komut.ExecuteScalar() + "TL";
            baglanti.baglanti_kapat();
           
        }
    }
}
