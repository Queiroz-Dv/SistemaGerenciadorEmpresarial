using System;
using System.Windows.Forms;
using UI.MenuPrincipalView;

namespace UI.LoginView
{
    public partial class FrmLogin : Form
    {
        public FrmLogin() => InitializeComponent();

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmMenuPrincipal().ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e) => Application.Exit();
    }
}
