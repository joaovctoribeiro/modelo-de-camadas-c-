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

namespace Modelo_em_3_camadas.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginController LoginController = new LoginController(txt_name.Text, txt_email.Text);
        }
    }
}
