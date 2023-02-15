using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Cargos
{
    public partial class FrmCargos : Form
    {
        public FrmCargos() => InitializeComponent();

        private void btnVoltar_Click(object sender, EventArgs e)
            => Close();
    }
}
