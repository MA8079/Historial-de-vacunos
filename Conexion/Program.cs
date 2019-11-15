using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Conexion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String connchain = "Data Source=LAPTOP-NKDVUSVE\\SQLEXPRESS;Initial Catalog=PruebaMAQ;Integrated Security=true";
                SqlConnection Connect = new SqlConnection(connchain);
                Connect.Open();
                Console.WriteLine("Conexion abierta");
                Connect.Close();
                Console.WriteLine("Conexion cerrada");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadLine();
        }
    }
}
