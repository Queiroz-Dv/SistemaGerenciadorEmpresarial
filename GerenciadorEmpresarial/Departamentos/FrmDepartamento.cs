using BLL.Departamento;
using BLL.ValidacoesGenericas;
using DAL;
using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Departamentos
{
    public partial class FrmDepartamento : Form
    {
        public FrmDepartamento() => InitializeComponent();

        private void btnVoltar_Click(object sender, EventArgs e) => this.Close();

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidateBase.Quando(txtDepartamento.Text.Trim() == ""))
            {
                MessageBox.Show("Preencha o campo de departamento!", Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (ValidateBase.Quando(txtDepartamento.Text.Length > 50))
            {
                MessageBox.Show("Quantidade de caracteres inválido", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ValidateBase.Quando(txtDepartamento.Text.Length < 3))
            {
                MessageBox.Show("Quantidade de caracteres inválido", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Criando o objeto de acesso
                var departamento = new DEPARTAMENTO
                {
                    //Atribui o valor digitado para a propriedade
                    DepartamentoNome = txtDepartamento.Text
                };

                // Repassa para a camada de negócio tratar e gravar
                new DepartamentosBLL().GravarDepartamento(departamento);
                MessageBox.Show($"Departamento de {txtDepartamento.Text} adicionado com sucesso!");
                LimparCampo();
            }
        }

        private void LimparCampo() => txtDepartamento.Clear();
    }
}
