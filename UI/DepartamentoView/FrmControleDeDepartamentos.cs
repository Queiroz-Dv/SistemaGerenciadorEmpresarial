using System;
using System.Windows.Forms;

namespace UI.DepartamentoView
{
    public partial class FrmControleDepartamentos : Form
    {
        public FrmControleDepartamentos() => InitializeComponent();

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmDepartamento().ShowDialog();
            Visible = true;
        }
    }
}
