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
    public partial class frmAraclistele : Form
    {
        arackayit arackiralama = new arackayit();
        public frmAraclistele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
        string arac_resim;
        private void frmAraclistele_Load(object sender, EventArgs e)
        {  

            YenileAraclar();
            try
            {
                comboAraclar.SelectedIndex = 0;
            }
            catch
            {
                ;
            }

        }

        private void YenileAraclar()
        {
             
            string cumle = "select * from arackayit";
            MySqlDataAdapter adtr2 = new MySqlDataAdapter();
            dataGridView1.DataSource=arackiralama.listele(adtr2, cumle);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now; 
            string cumle = "update arackayit set marka=@marka, model=@model, renk=@renk, km=@km, yakit=@yakit, kiraucreti=@kiraucreti, resim=@resim, tarih=@tarih WHERE plaka=@plaka";
            MySqlCommand komut2 = new MySqlCommand();
            komut2.Parameters.AddWithValue("@plaka", plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", markacombo.Text);
            komut2.Parameters.AddWithValue("@model", modeltxt.Text);
            komut2.Parameters.AddWithValue("@renk", renktxt.Text);
            komut2.Parameters.AddWithValue("@km", kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakit", yakitcombo.Text);
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@kiraucreti", Convert.ToInt32(ucrettxt.Text));
            komut2.Parameters.AddWithValue("@tarih",  tarih.ToString("yyyy-MM-dd HH:mm:ss"));
            arackiralama.ekle_sil_guncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
            YenileAraclar();

        }

        private void frmAraclistele_FormClosing(object sender, FormClosingEventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            arac_resim = openFileDialog1.FileName;
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            plakatxt.Text = satir.Cells[1].Value.ToString();
            markacombo.Text = satir.Cells[2].Value.ToString(); 
            modeltxt.Text = satir.Cells[3].Value.ToString();
            renktxt.Text = satir.Cells[4].Value.ToString();
            kmtxt.Text = satir.Cells[5].Value.ToString();
            yakitcombo.Text = satir.Cells[6].Value.ToString();
            ucrettxt.Text = satir.Cells[8].Value.ToString(); 
            pictureBox1.ImageLocation = satir.Cells[7].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "delete from arackayit where plaka='" + satir.Cells["plaka"].Value.ToString()+"'";
            MySqlCommand komut2 = new MySqlCommand();
            arackiralama.ekle_sil_guncelle(komut2, cumle);
            pictureBox1.ImageLocation = "";
            YenileAraclar();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

        }

        private void markacombo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboAraclar.SelectedIndex == 0)
                {
                    YenileAraclar();
                }
                if (comboAraclar.SelectedIndex == 1)
                {
                    string cumle = "select * from arackayit where durumu='Boş'";
                    MySqlDataAdapter adtr2 = new MySqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
                }
                if (comboAraclar.SelectedIndex == 2)
                {
                    string cumle = "select * from arackayit where durumu='Dolu'";
                    MySqlDataAdapter adtr2 = new MySqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
                }
            }
            catch
            {
                ;
            }
        }

    }
}
