using GerenciadorEmpresarial.Colaboradores;
using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Menu
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
            => InitializeComponent();

        private void btnFechar_Click(object sender, EventArgs e)
            => Application.Exit();

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmControleDeColaboradores().ShowDialog();
            Visible = true; // Quando fechar o form de colaborador ele irá mostrar o do menu principal
        }
    }
}
