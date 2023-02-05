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
    }
}
