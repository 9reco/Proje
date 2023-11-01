using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
     public class sqlbaglantisi
    {
       public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-KFP7OUR\\RECEP;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
