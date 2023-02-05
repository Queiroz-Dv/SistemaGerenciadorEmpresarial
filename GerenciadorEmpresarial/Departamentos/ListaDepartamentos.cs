using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Departamentos
{
    public partial class ListaDepartamentos : Form
    {
        public ListaDepartamentos() => InitializeComponent();

        private void btnVoltar_Click(object sender, EventArgs e) => this.Close();
    }
}
