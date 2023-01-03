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
    public partial class kullaniciAnasayfa : Form
    {
        public kullaniciAnasayfa()
        {
            InitializeComponent();
        }

        private void kullaniciAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAraclistele listele = new frmAraclistele();
            listele.ShowDialog();
        }

        private void kullaniciAnasayfa_Load(object sender, EventArgs e)
        {
            
        }
    }
}
