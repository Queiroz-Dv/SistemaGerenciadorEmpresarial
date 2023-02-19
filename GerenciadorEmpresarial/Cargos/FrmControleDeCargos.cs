using BLL.Cargo;
using DAL.DTO.Cargo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Cargos
{
    public partial class FrmControleDeCargos : Form
    {
        private List<CargosDTO> cargosDTOs = new List<CargosDTO>();

        public FrmControleDeCargos() => InitializeComponent();

        private void btnVoltar_Click(object sender, EventArgs e) => Close();

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ExibirFrmCargos();
            PreencherGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ExibirFrmCargos(); 
            PreencherGrid();
        }

        private void FrmControleDeCargos_Load(object sender, EventArgs e)
        {
            PreencherGrid();
            ConfigurarColunasDgvCargos();
        }

        private void ConfigurarColunasDgvCargos()
        {
            dgvCargos.Columns[1].Visible = false;
            dgvCargos.Columns[3].Visible = false;

            dgvCargos.Columns[0].HeaderText = "Departamentos";
            dgvCargos.Columns[2].HeaderText = "Cargos";
        }

        private void PreencherGrid()
        {
            cargosDTOs = new CargosBLL().ObterCargos();
            dgvCargos.DataSource = cargosDTOs;
        }

        private void ExibirFrmCargos()
        {
            Hide();
            new FrmCargos().ShowDialog();
            Visible = true;
        }
    }
}
