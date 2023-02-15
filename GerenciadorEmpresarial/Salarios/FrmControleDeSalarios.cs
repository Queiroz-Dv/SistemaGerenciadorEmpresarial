using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEmpresarial.Salarios
{
    public partial class FrmControleDeSalarios : Form
    {
        public FrmControleDeSalarios() => InitializeComponent();

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmSalarios().ShowDialog();
            Visible = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmSalarios().ShowDialog();
            Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e) => Close();
    }
}
