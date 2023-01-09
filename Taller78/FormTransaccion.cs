using Npgsql;
using static System.Net.Mime.MediaTypeNames;

namespace Taller78
{
    public partial class FormTransaccion : Form
    {
        

        public FormTransaccion()
        {
            InitializeComponent();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void FormTransaccion_Load(object sender, EventArgs e)
        {

        }

        private void buttonSaldo_Click(object sender, EventArgs e)
        {
            string bd = "BDBANCO";

            string cadenaConexion = "server= localhost;" + "port=" + textpuerto.Text + ";" +
             "user id=" + textusuario.Text + ";" + "password=" + textpass.Text + ";" + "database=" + bd + ";";
            NpgsqlConnection conn = new NpgsqlConnection();
            conn.ConnectionString = cadenaConexion;
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "Select * from cuenta order by idcuenta asc";
            cmd.Connection = conn;
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                textsaldo1.Text= dr["Saldo"].ToString();
                while(dr.Read()) 
                {
                    textsaldo2.Text = dr["Saldo"].ToString();
                }
            
            }

            conn.Close();

        }

        private void buttonTransaccionMala_Click(object sender, EventArgs e)
        {
            Transacciones transacciones = new Transacciones();
            transacciones.IngresarNoTransaccional(textpuerto.Text, textpass.Text, Convert.ToInt32(textorigen.Text), Convert.ToInt32(textdestino.Text), Convert.ToInt32(textValor.Text));
            string bd = "BDBANCO";

            string cadenaConexion = "server= localhost;" + "port=" + textpuerto.Text + ";" +
                "user id= postgres;" + "password=" + textpass.Text + ";" + "database=" + bd + ";";
            NpgsqlConnection conn = new NpgsqlConnection();
            conn.ConnectionString = cadenaConexion;
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "Select * from cuenta order by idcuenta asc";
            cmd.Connection = conn;
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textsaldo1.Text = dr["Saldo"].ToString();
                while (dr.Read())
                {
                    textsaldo2.Text = dr["Saldo"].ToString();
                }

            }

            conn.Close();
        }

        private void buttonTransaccionBuena_Click(object sender, EventArgs e)
        {
            Transacciones transacciones = new Transacciones();
            transacciones.IngresarTransaccional(textpuerto.Text, textpass.Text, Convert.ToInt32(textorigen.Text), Convert.ToInt32(textdestino.Text), Convert.ToInt32(textValor.Text));
            string bd = "BDBANCO";

            string cadenaConexion = "server= localhost;" + "port=" + textpuerto.Text + ";" +
                "user id= postgres;" + "password=" + textpass.Text + ";" + "database=" + bd + ";";
            NpgsqlConnection conn = new NpgsqlConnection();
            conn.ConnectionString = cadenaConexion;
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "Select * from cuenta order by idcuenta asc";
            cmd.Connection = conn;
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textsaldo1.Text = dr["Saldo"].ToString();
                while (dr.Read())
                {
                    textsaldo2.Text = dr["Saldo"].ToString();
                }

            }

            conn.Close();
        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}