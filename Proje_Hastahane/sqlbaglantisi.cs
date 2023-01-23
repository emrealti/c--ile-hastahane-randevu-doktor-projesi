using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Permissions;

namespace Proje_Hastahane
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-URKG832\\SQLEXPRESS;Initial Catalog=HastahaneOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
