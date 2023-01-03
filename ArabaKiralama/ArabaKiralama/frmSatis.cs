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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        arackayit arac = new arackayit();
        Baglanti baglanti = new Baglanti(); 
        private void frmSatis_Load(object sender, EventArgs e)
        {
            string sorgu2 = "SELECT * FROM satis";
            MySqlDataAdapter adtr2 = new MySqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2,sorgu2);
            arac.satishesapla(label1);
        }

        private void frmSatis_FormClosing(object sender, FormClosingEventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            this.Hide();
            anasayfa.Show();
        }
    }
}
