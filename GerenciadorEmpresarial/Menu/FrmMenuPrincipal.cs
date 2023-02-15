using GerenciadorEmpresarial.Cargos;
using GerenciadorEmpresarial.Colaboradores;
using GerenciadorEmpresarial.Departamentos;
using GerenciadorEmpresarial.Permissoes;
using GerenciadorEmpresarial.Salarios;
using GerenciadorEmpresarial.Tarefas;
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

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmControleDeTarefas().ShowDialog();
            Visible = true;
        }

        private void btnSalario_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmControleDeSalarios().ShowDialog();
            Visible = true;
        }

        private void btnPermissao_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmControleDePermissoes().ShowDialog();
            Visible = true;
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmControleDeDepartamentos().ShowDialog();
            Visible = true;
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmControleDeCargos().ShowDialog();
            Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmLogin().ShowDialog();
        }

        private void FrmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
    }
}
