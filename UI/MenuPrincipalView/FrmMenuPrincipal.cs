using System;
using System.Windows.Forms;
using UI.CargoView;
using UI.DepartamentoView;

namespace UI.MenuPrincipalView
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmControleDeCargos().ShowDialog();
            Visible = true;
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmControleDepartamentos().ShowDialog();
            Visible = true;
        }
    }
}
