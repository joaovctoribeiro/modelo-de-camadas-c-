using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Modelo_em_3_camadas
{
    public class Register
    {
        Connection connection = new Connection();
        Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand();
        public string message = "";
        public Register(string name, string email, string contato)
        {
            /*
             * - Comando SQL: INSERT, UPDATE e DELETE
             * 
             * - SQL command: INSERT, UPDATE and DELETE
             */

            command.CommandText = "INSERT INTO usuario (nome_usuario, email_usuario, contato_usuario) VALUES (@name, @email, @contato);";

            /*
             * - Parametros
             * 
             * - Parameters
             */

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@contato", contato);
            //command.Parameters.AddWithValue("@phone", contato);

            try
            {
                // Connect to Database
                command.Connection = connection.Connect();

                // Command execution
                command.ExecuteNonQuery();

                // Disconect to Database
                connection.Disconnect();

                // Information message
                //this.message = "Cadastrado com sucesso!";
            }
            catch (Npgsql.NpgsqlException e)
            {
                // Information message
                MessageBox.Show(e.Message);
            }
        }
    }
}