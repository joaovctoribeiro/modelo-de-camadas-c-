using Modelo_em_3_camadas.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Modelo_em_3_camadas.DAO;
using System.Windows.Forms;

namespace Modelo_em_3_camadas.Controller
{
    internal class LoginController
    {
        public bool authenticated = false;

        public LoginController(string name, string email)
        {
            LoginForm loginForm = new LoginForm();
            MainForm mainForm = new MainForm();

            Login login = new Login(name, email);

            if (name == "" || email == "")
            {
                MessageBox.Show("Dados inválidos.");
                authenticated = false;
            }
            else if (login.count == 0)
            {
                MessageBox.Show("Dados inválidos.");
            }
            else
            {
                loginForm.Close();
                mainForm.Show();
            }

            return;
        }
    }
}