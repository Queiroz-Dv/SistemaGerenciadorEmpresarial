using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Cargos
{
    public partial class FrmControleDeCargos : Form
    {
        public FrmControleDeCargos() => InitializeComponent();

        private void btnVoltar_Click(object sender, EventArgs e) => Close();

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmCargos().ShowDialog();
            Visible = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmCargos().ShowDialog();
            Visible = true;
        }
    }
}
