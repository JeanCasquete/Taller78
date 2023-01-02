using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller78
{
      public class ConexionDB
    {

        public NpgsqlConnection  EstablecerConex(string puerto, string pass)
        {
             string bd = "BDBANCO";

            string cadenaConexion = "server= localhost;" + "port=" + puerto + ";" +
                "user id= postgres;" + "password=" + pass + ";" + "database=" + bd + ";";
            NpgsqlConnection conn = new NpgsqlConnection();

            try
            {
                conn.ConnectionString = cadenaConexion;
                conn.Open();
                MessageBox.Show("Se conectó correctamente a la Base de datos: " + bd);
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos de PostgreSQL, error: " + e.ToString());
                
            }return conn;
           
        }

    }
}
