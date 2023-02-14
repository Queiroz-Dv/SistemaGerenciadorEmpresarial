using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Departamentos
{
    public partial class FrmControleDeDepartamentos : Form
    {
        public FrmControleDeDepartamentos() => InitializeComponent();

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmDepartamento().ShowDialog();
            Visible = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmDepartamento().ShowDialog();
            Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e) => Close();
    }
}
