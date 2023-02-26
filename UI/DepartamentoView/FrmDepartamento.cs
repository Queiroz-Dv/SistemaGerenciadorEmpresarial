using Domain.Services;
using Infra.Application.DTO;
using Infra.Application.Interfaces;
using Infra.Application.Services;
using System;
using System.Windows.Forms;

namespace UI.DepartamentoView
{
    public partial class FrmDepartamento : Form
    {
        public FrmDepartamento()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Cria o DTO e o Service do Domain
            var departamentoDto = new DepartamentoDto(Guid.NewGuid(), txtNovoDepartamento.Text);
            var departamentoService = new DepartamentoService(departamentoDto.Id, departamentoDto.Nome);

            // Repassa ao método de Salvar do Frm
            SalvarDepartamento(departamentoService, departamentoDto);
        }

        
        private async void SalvarDepartamento(DepartamentoService departamentoService, DepartamentoDto departamentoDto)
        {
            DepartamentoApplicationService applicationService = new();
            await applicationService.CriarDepartamentoService(departamentoDto);
            // Repassa os dados para o domain service executar 
            departamentoService.SalvarDepartamentoService(departamentoDto.Id, departamentoDto.Nome);

            if (departamentoService.HasNotifications)
                ShowNotifications(departamentoService);
        }

        private void ShowNotifications(DepartamentoService departamentoService)
        {
            if (!departamentoService.HasNotifications) return;

            if (departamentoService.HasErrors)
            {
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("\nErrors\n");

                foreach (var error in departamentoService.Errors())
                {
                    MessageBox.Show(error.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (departamentoService.HasWarnings)
            {

                //Console.WriteLine("\nWarnings\n");
                //MessageBox.Show()

                foreach (var error in departamentoService.Warnings())
                {
                    //Console.WriteLine(error.ToString());
                    MessageBox.Show(error.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (departamentoService.HasInformations)
            {
                //Console.ForegroundColor = ConsoleColor.Blue;
                //Console.WriteLine("\nInformations\n");

                foreach (var error in departamentoService.Informations())
                {
                    MessageBox.Show(error.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}