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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AracKayit_Click(object sender, EventArgs e)
        {
            frmAracKayit frmAracKayit = new frmAracKayit();
            frmAracKayit.Show();
            this.Hide();
        }

        private void Cıkıs_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();
        }

        private void MusteriEkle_Click(object sender, EventArgs e)
        {
            musterikayit musterikayit = new musterikayit();
            musterikayit.Show();
            this.Hide();
        }

        private void MusteriListele_Click(object sender, EventArgs e)
        {
            frmMusteriListele frmMusteriListele = new frmMusteriListele();
            frmMusteriListele.Show();
            this.Hide();
        }

        private void AracListele_Click(object sender, EventArgs e)
        {
            frmAraclistele listele = new frmAraclistele();
            listele.ShowDialog();
        }

        private void Sozlesme_Click(object sender, EventArgs e)
        {
            frmSozlesme sozlesme = new frmSozlesme();
            sozlesme.ShowDialog();
        }

        private void Satis_Click(object sender, EventArgs e)
        {
            frmSatis satis = new frmSatis();
            satis.ShowDialog();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

           // MessageBox.Show(giris.yetki);
        }
    }
}
