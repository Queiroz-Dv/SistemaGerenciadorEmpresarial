using BLL.Cargo;
using BLL.Departamento;
using BLL.Validacoes;
using DAL;
using System;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Cargos
{
    public partial class FrmCargos : Form
    {
        private readonly DepartamentosBLL departamentosBLL = new DepartamentosBLL();

        public FrmCargos() => InitializeComponent();

        private void btnVoltar_Click(object sender, EventArgs e) => Close();

        private void FrmCargos_Load(object sender, EventArgs e)
        {
            ConfigurarcmbDepartamentos();
        }

        private void ConfigurarcmbDepartamentos()
        {
            // Obtém os departamentos do banco e preenche o cmb
            var departamentosBD = departamentosBLL.ObterDepartamentos();
            cmbDepartamentos.DataSource = departamentosBD;

            /* Mostra o nome dos departamentos de acordo com o a coluna da tabela,
                sem essa configuração irá mostrar o nome do objeto.
             */
            cmbDepartamentos.DisplayMember = "DepartamentoNome";

            // Quando um item for selecionado do cmb estaremos obtendo ele pelo ID
            cmbDepartamentos.ValueMember = "DepartamentoID";
            cmbDepartamentos.SelectedIndex = -1;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidateBase.Quando(txtCargo.Text.Trim() == ""))
            {
                MessageBox.Show("Por favor preencha o campo de cargo", Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (ValidateBase.Quando(txtCargo.Text.Trim().Length < 3))
            {
                MessageBox.Show("Nome para cargo inválido!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var cargo = new CARGO()
                {
                    CargoNome = txtCargo.Text,
                    DepartamentoID = Convert.ToInt32(cmbDepartamentos.SelectedValue)
                };

                new CargosBLL().GravarCargo(cargo);
                MessageBox.Show("Cargo adicionado com sucesso!", Text, MessageBoxButtons.OK);
                LimparCmapos();
            }
        }

        private void LimparCmapos()
        {
            txtCargo.Clear();
            cmbDepartamentos.SelectedIndex = -1;
        }
    }
}
