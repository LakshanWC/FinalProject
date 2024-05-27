using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalProject.MVC.Model
{
    public class MDBConnection
    {
        static string Conn = @"Data Source = DESKTOP-F9OET40; Initial Catalog = restaurantdb ; Integrated Security = true ";
        SqlConnection con = new SqlConnection(Conn);

        public SqlConnection openConnection() { 
            con.Open();
            return con;
        }
        public void closeConnection() {
            con.Close();
        }

    }
}
