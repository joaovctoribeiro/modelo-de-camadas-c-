using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo_em_3_camadas.Controller;

namespace Modelo_em_3_camadas
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            RegisterController RegisterController = new RegisterController(txt_name.Text, txt_email.Text, mtb_contato.Text);
        }
    }
}
