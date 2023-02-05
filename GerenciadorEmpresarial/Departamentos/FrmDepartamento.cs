using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Departamentos
{
    public partial class FrmDepartamento : Form
    {
        public FrmDepartamento() => InitializeComponent();

        private void btnVoltar_Click(object sender, EventArgs e) => this.Close();
    }
}
