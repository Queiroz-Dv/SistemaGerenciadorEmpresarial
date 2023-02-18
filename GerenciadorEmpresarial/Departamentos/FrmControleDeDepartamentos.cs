using BLL.Departamento;
using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Departamentos
{
    public partial class FrmControleDeDepartamentos : Form
    {
        private readonly DepartamentosBLL departamentoBLL = new DepartamentosBLL();

        public FrmControleDeDepartamentos() => InitializeComponent();

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmDepartamento().ShowDialog();
            Visible = true;
            PreencheGrid();
        }

        private void PreencheGrid()
        {
            // Busca os departamentos através da camada de negócio
            var departamentos = departamentoBLL.ObterDepartamentos();

            // Repassa o objeto pra preencher a grid
            dgvDepartamentos.DataSource = departamentos;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmDepartamento().ShowDialog();
            Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e) => Close();

        private void FrmControleDeDepartamentos_Load(object sender, EventArgs e)
        {
            PreencheGrid();
            ConfigurarColunasDataGrid();
        }

        private void ConfigurarColunasDataGrid()
        {
            dgvDepartamentos.Columns[0].Visible = false;
            dgvDepartamentos.Columns[1].HeaderText = "Departamentos";
        }
    }
}
