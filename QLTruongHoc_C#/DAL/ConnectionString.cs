using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectionString
    {
        public static SqlConnection getConnection()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-I1MCBOK\LAP;Initial Catalog=QL_TruongHoc;Integrated Security=True");
            return Conn;
        }
    }
}
