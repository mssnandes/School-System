using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    public static class Conexao
    {
        public static SqlConnection conn;
        public static string conexao =
            @"Data Source=SJC0557972W10-1;
                Initial Catalog = SchoolSys;
                User Id = sa;
                Password = Senac123";

        public static void Conectar()
        {
            conn = new SqlConnection(conexao);
            conn.Open();
        }
        public static void Fechar()
        {
            conn.Close();
        }
    }
}
