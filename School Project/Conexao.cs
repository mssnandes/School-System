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
            @"Data Source=DESKTOP-02R5M43\SQLEXPRESS;
                Initial Catalog = SchoolSys;
                User Id = sa;
                Password = 03sesiom";

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
