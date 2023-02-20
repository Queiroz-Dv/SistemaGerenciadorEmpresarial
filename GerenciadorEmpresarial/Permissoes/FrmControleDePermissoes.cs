using BLL.ValidacoesGenericas;
using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Permissoes
{
    public partial class FrmControleDePermissoes : Form
    {
        public FrmControleDePermissoes() => InitializeComponent();

        private void txtNumeroUsuario_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = VerificarDigito.VerificaDigitoNumerico(e);

        private void txtQuantidadeDias_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = VerificarDigito.VerificaDigitoNumerico(e);

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmPermissoes().ShowDialog();
            Visible = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmPermissoes().ShowDialog();
            Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e) => Close();

    }
}
