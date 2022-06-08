using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1
using System.Data.SqlClient;

namespace AppKasir
{
    internal class Koneksi
    {
        //2
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data source=LAPTOP-R6Q0VSQU;initial catalog=db_kasir;integrated security=true";
            return Conn;
        }
    }
}
