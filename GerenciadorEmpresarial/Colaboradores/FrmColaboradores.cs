using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Colaboradores
{
    public partial class FrmColaboradores : Form
    {
        public FrmColaboradores() => InitializeComponent();

        private void btnVoltar_Click(object sender, EventArgs e) => Close();
    }
}
