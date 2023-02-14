using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Colaboradores
{
    public partial class FrmControleDeColaboradores : Form
    {
        public FrmControleDeColaboradores() => InitializeComponent();

        private void btnVoltar_Click(object sender, EventArgs e) => Close();

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmColaboradores().ShowDialog();
            Visible = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmColaboradores().ShowDialog();
            Visible = true;
        }
    }
}
