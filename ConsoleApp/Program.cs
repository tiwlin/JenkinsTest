using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using Z.Dapper.Plus;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DemoConnectionString"].ConnectionString))
            {
                var order = conn.Query("select * from SalesOrder").ToList();
                Console.WriteLine(order.Count);

                var first = conn.QueryFirst("select * from SalesOrder");

                using (var mulit = conn.QueryMultiple("select * from SalesOrder; select * from Customer; "))
                {
                    
                }
            }

            Console.Read();
           
        }
    }
}
