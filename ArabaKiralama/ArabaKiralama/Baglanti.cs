using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace ArabaKiralama
{
    public class Baglanti
    {
        public MySqlConnection baglanti;
        public Baglanti()
        {

            baglanti = new MySqlConnection("server=localhost;database=arackiralama;uid=root;password=Zeynep123412");
        }
        public void kontrol()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti_ac();
            }
        }
        public void baglanti_ac()
        {
            baglanti.Open();
            
        }
        public void baglanti_kapat()
        {
            baglanti.Close();
        }
    }
}
