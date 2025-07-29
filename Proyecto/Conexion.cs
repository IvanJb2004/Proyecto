using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Conexion 
    {
        public static SqlConnection ConectarSQL()
        {
            
            
                string conectionstring = "data source=DESKTOP-NCT2NEU\\SQLEXPRESS; initial catalog = registro; integrated security=true";

                SqlConnection connection = new SqlConnection(conectionstring);


            connection.Open();
            return connection;
        }
    }
}
