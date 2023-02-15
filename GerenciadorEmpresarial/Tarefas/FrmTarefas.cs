using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Tarefas
{
    public partial class FrmTarefas : Form
    {
        public FrmTarefas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e) => Close();
    }
}
