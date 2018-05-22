using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFunc
{
    class MySqlDatabaseConfig
    {
       public MySqlConnection baglanti = new MySqlConnection("Server=94.73.144.47;Database=u6772018_Hope;Uid=u6772018_Hope;Pwd='VJzx33H7';SslMode=none");
        public MySqlDatabaseConfig()
        { 
            baglanti.Open();        
        }
        public void quarysend(string Temp_Quary)
        {
            MySqlCommand ekle = new MySqlCommand(Temp_Quary, baglanti);
            baglanti.Open();
            ekle.ExecuteNonQuery();
        }
        private void GetQuary()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string sonuc = dr[""].ToString() + " " + dr[""].ToString();
            }
        }
    }
}
