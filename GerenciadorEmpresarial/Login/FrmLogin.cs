using BLL.Validacoes;
using System.Windows.Forms;

namespace GerenciadorEmpresarial
{
    public partial class FrmLogin : Form
    {
        public FrmLogin() => InitializeComponent();

        private void txtNumeroUsuario_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = VerificarDigito.VerificaDigitoNumerico(e);

        private void btnFechar_Click(object sender, System.EventArgs e) 
            => Application.Exit();
    }
}
