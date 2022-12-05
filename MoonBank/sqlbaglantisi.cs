using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MoonBank
{
    class sqlbaglantisi
    {
        public string adres = System.IO.File.ReadAllText(@"Databasepath.txt");
        public SqlConnection baglanti()
        {         
            SqlConnection baglan = new SqlConnection(adres);
            baglan.Open();
            return baglan;
        }
    }
}
