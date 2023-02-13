using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Tarefas
{
    public partial class FrmControleDeTarefas : Form
    {
        public FrmControleDeTarefas() => InitializeComponent();

        private void btnVoltar_Click(object sender, EventArgs e) => Close();
    }
}
