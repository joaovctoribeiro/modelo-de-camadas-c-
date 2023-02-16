using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo_em_3_camadas.Forms;
using Npgsql;

namespace Modelo_em_3_camadas.DAO
{
    public class Login
    {
        Connection connection = new Connection();

        public bool result;
        public int count;
        public bool logged;

        // Função para Logar no sistema
        public Login(string name, string email)
        {
            //LoginForm loginForm = new LoginForm();
            //MainForm mainForm = new MainForm();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM usuario WHERE nome_usuario=@name AND email_usuario=@email;");

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", email);

            try
            {
                command.Connection = connection.Connect();

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);

                count = ds.Tables[0].Rows.Count;

                connection.Disconnect();

                if (count == 1)
                {
                    MessageBox.Show("Logado com sucesso!");
                    logged = true;
                    result = true;

                    //loginForm.Close();
                    //mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Dados inválidos");
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}