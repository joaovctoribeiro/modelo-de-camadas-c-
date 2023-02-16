using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Modelo_em_3_camadas
{
    public class Connection
    {
        Npgsql.NpgsqlConnection con = new Npgsql.NpgsqlConnection();

        /*
         * - Construtor
         * 
         * - Constructor
         */

        public Connection()
        {
            con.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=pgadmin;Database=teste;";
        }

        /*
         * - Método pra conectar com o banco
         * 
         * - Method to connect to the database
         */

        public Npgsql.NpgsqlConnection Connect()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }

        /*
         * - Método para desconectar do banco
         * 
         * - Method to disconnect from database
         */
        public void Disconnect()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}