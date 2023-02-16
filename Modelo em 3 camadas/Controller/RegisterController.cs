using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo_em_3_camadas.Controller
{
    public class RegisterController
    {
        public bool validate = false;
        public RegisterController(string name, string email, string contato)
        {
            RegisterForm form = new RegisterForm();

            if (name == "" || email == "" || contato == "")
            {
                MessageBox.Show("Campos vazios.");
                validate = false;
            }
            else
            {
                Register register = new Register(name, email, contato);
                MessageBox.Show("Cadastrado com sucesso!");
                validate = true;
            }

            return;
        }
    }
}
