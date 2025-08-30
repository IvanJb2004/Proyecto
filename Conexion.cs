using MySql.Data.MySqlClient;
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
        public static MySqlConnection ConectarSQL()
        {
            
            
                string conectionstring = "SERVER=82.25.67.19;PORT=3306;DATABASE=u700978481_registro;UID=u700978481_sena;PWD=Faber271204*";

                MySqlConnection connection = new MySqlConnection(conectionstring);


            connection.Open();
            return connection;
        }
    }
}
