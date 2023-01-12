using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Taller78
{
    class Transacciones
    {
        public void IngresarNoTransaccional(string puerto, string pass, int origen, int destino, int valor, string usuario)
        {
            string bd = "BDBANCO";

            string cadenaConexion = "server= localhost;" + "port=" + puerto + ";" +
                 "user id=" + usuario + ";" + "password=" + pass + ";" + "database=" + bd + ";";
            NpgsqlConnection conn = new NpgsqlConnection();

            string query = "PA_INSERTAR_NO_TRANSACCIONAL";
            try
            {
                NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
                ejecutor.Parameters.AddWithValue("@pidcuentaorigen", origen);
                ejecutor.Parameters.AddWithValue("@pidcuentadestino", destino);
                ejecutor.Parameters.AddWithValue("@pvalor", valor);
                ejecutor.CommandType = System.Data.CommandType.StoredProcedure;
                conn.ConnectionString = cadenaConexion;
                conn.Open();
                ejecutor.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Ejecutada correctamente");

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error en la transaccion" + ex.Message);
            }

        }

        public void IngresarTransaccional(string puerto, string pass, int origen, int destino, int valor, string usuario)
        {
            string bd = "BDBANCO";

            string cadenaConexion = "server= localhost;" + "port=" + puerto + ";" +
                 "user id=" + usuario + ";" + "password=" + pass + ";" + "database=" + bd + ";";
            NpgsqlConnection conn = new NpgsqlConnection();

            string query = "PA_INSERTAR_TRANSACCIONAL";
            try
            {
                NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
                ejecutor.Parameters.AddWithValue("@pidcuentaorigen", origen);
                ejecutor.Parameters.AddWithValue("@pidcuentadestino", destino);
                ejecutor.Parameters.AddWithValue("@pvalor", valor);
                ejecutor.CommandType = System.Data.CommandType.StoredProcedure;
                conn.ConnectionString = cadenaConexion;
                conn.Open();
                ejecutor.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Ejecutada correctamente");

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error en la transaccion" + ex.Message);
            }

        }
    }
}
