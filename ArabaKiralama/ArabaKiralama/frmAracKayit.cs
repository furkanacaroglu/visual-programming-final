using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ArabaKiralama
{
    public partial class frmAracKayit : Form
    {
        public frmAracKayit()
        {
            InitializeComponent();
        }
        arackayit araclistele = new arackayit();
        string arac_resim;
        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            arac_resim = openFileDialog1.FileName;  
            resimBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }
        private void frmAracKayit_Load(object sender, EventArgs e)
        {
            JArray cars;
            using (StreamReader file = File.OpenText(@"..\..\Resources\cars.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                cars = JArray.Load(reader);
            }
            foreach (var car in cars)
            {
                markacombo.Items.Add(car["title"].ToString());
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (markacombo.SelectedIndex == 0)
                {

                    markacombo.Items.Add("Egea");
                    markacombo.Items.Add("Linea");
                    markacombo.Items.Add("Albea");

                }
                else if (markacombo.SelectedIndex == 1)
                {
                    markacombo.Items.Add("Focus");
                    markacombo.Items.Add("Puma");
                    markacombo.Items.Add("Mustang");
                }
                else if (markacombo.SelectedIndex == 2)
                {
                    markacombo.Items.Add("Megan");
                    markacombo.Items.Add("Kadjar");
                    markacombo.Items.Add("Clio");
                }
                else if (markacombo.SelectedIndex == 3)
                {
                    markacombo.Items.Add("CLA200");
                    markacombo.Items.Add("E250");
                    markacombo.Items.Add("Vito");
                }
                else if (markacombo.SelectedIndex == 4)
                {
                    markacombo.Items.Add("i20");
                    markacombo.Items.Add("Tucson");
                    markacombo.Items.Add("Elantra");
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now;
            string cumle = "insert into arackayit(resim,plaka,marka,model,renk,km,yakit,kiraucreti,durumu,tarih) values (@resim, @plaka,@marka, @model,@renk,@km,@yakit,@kiraucreti,@durumu,@tarih)";
            MySqlCommand komut2 = new MySqlCommand(); 
            komut2.Parameters.AddWithValue("@plaka",plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", markacombo.Text);
            komut2.Parameters.AddWithValue("@model", modeltxt.Text);
            komut2.Parameters.AddWithValue("@renk", renktxt.Text);
            komut2.Parameters.AddWithValue("@km", kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakit", yakitcombo.Text);
            komut2.Parameters.AddWithValue("@resim", resimBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@kiraucreti", Convert.ToInt32(ücrettxt.Text));
            komut2.Parameters.AddWithValue("@durumu", "Boş");
            komut2.Parameters.AddWithValue("@tarih", tarih.ToString("yyyy-MM-dd HH:mm:ss"));
            araclistele.ekle_sil_guncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            resimBox1.ImageLocation = "";

        }

        private void frmAracKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            this.Hide();
            anasayfa.Show();
        }


    }
}
