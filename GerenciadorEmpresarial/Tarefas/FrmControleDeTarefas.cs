using BLL.Validacoes;
using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Tarefas
{
    public partial class FrmControleDeTarefas : Form
    {
        public FrmControleDeTarefas() => InitializeComponent();
        private void FrmControleDeTarefas_Load(object sender, EventArgs e)
        {
            pnlForAdmin.Hide();
        }
        private void txtNumeroUsuario_KeyPress(object sender, KeyPressEventArgs e) 
            => e.Handled = VerificarDigito.VerificaDigitoNumerico(e);

        private void btnVoltar_Click(object sender, EventArgs e) => Close();

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmTarefas().ShowDialog();
            Visible = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmTarefas().ShowDialog();
            Visible = true;
        }
    }
}
