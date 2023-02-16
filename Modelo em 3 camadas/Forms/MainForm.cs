using Modelo_em_3_camadas.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo_em_3_camadas.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            DialogResult confirm = MessageBox.Show("Deseja sair?", "Sair?", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                this.Close();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Operação cancelada.");
            }
        }

        private void btn_funcionarios_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}