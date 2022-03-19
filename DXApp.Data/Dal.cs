using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApp.Data
{
    public class Dal
    {
        public string conStr = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public SqlConnection OpenConnection()
        {
            SqlConnection baglanti = new SqlConnection(conStr);
            baglanti.Open();
            return baglanti;
        }
        public SqlCommand SorguOlustur(string sorgu)
        {
            SqlCommand cmd = new SqlCommand(sorgu, OpenConnection());
            return cmd;
        }
    }
}
