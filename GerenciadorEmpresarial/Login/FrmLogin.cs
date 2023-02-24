using DAL.ValidacoesGenericas;
using GerenciadorEmpresarial.Menu;
using System.Windows.Forms;

namespace GerenciadorEmpresarial
{
    public partial class FrmLogin : Form
    {
        public FrmLogin() => InitializeComponent();

        private void txtNumeroUsuario_KeyPress(object sender, KeyPressEventArgs e) 
            => e.Handled = VerificarDigito.VerificaDigitoNumerico(e);

        private void btnFechar_Click(object sender, System.EventArgs e) => Application.Exit();

        private void btnConectar_Click(object sender, System.EventArgs e)
        {
            Hide(); // Pra esconder o form de Login do próximo form
            new FrmMenuPrincipal().ShowDialog();
        }
    }
}
