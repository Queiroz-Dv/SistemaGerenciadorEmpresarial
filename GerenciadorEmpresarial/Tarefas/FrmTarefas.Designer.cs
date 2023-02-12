
namespace GerenciadorEmpresarial.Tarefas
{
    partial class FrmTarefas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbEstadoTarefa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumeroUsuario = new System.Windows.Forms.TextBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.pnlDepartamentoCargo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNumeroUsuario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.pnlDepartamentoCargo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(282, 472);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 30);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(150, 472);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(95, 30);
            this.btnGravar.TabIndex = 23;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // txtConteudo
            // 
            this.txtConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudo.Location = new System.Drawing.Point(118, 199);
            this.txtConteudo.Margin = new System.Windows.Forms.Padding(2);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(318, 209);
            this.txtConteudo.TabIndex = 22;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(183, 161);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(176, 26);
            this.txtTitulo.TabIndex = 21;
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudo.Location = new System.Drawing.Point(11, 204);
            this.lblConteudo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(73, 18);
            this.lblConteudo.TabIndex = 32;
            this.lblConteudo.Text = "Conteúdo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(11, 165);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(44, 18);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "Título";
            // 
            // cmbEstadoTarefa
            // 
            this.cmbEstadoTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoTarefa.FormattingEnabled = true;
            this.cmbEstadoTarefa.Location = new System.Drawing.Point(183, 125);
            this.cmbEstadoTarefa.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstadoTarefa.Name = "cmbEstadoTarefa";
            this.cmbEstadoTarefa.Size = new System.Drawing.Size(176, 28);
            this.cmbEstadoTarefa.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Estado da tarefa";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BackColor = System.Drawing.SystemColors.Window;
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(183, 90);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(2);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.ReadOnly = true;
            this.txtSobrenome.Size = new System.Drawing.Size(176, 26);
            this.txtSobrenome.TabIndex = 27;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(183, 52);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(176, 26);
            this.txtNome.TabIndex = 26;
            // 
            // txtNumeroUsuario
            // 
            this.txtNumeroUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroUsuario.Location = new System.Drawing.Point(183, 16);
            this.txtNumeroUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroUsuario.Name = "txtNumeroUsuario";
            this.txtNumeroUsuario.ReadOnly = true;
            this.txtNumeroUsuario.Size = new System.Drawing.Size(176, 26);
            this.txtNumeroUsuario.TabIndex = 25;
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(19, 110);
            this.cmbCargo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(176, 28);
            this.cmbCargo.TabIndex = 1;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(19, 40);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(176, 28);
            this.cmbDepartamento.TabIndex = 0;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(16, 90);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(49, 18);
            this.lblCargo.TabIndex = 14;
            this.lblCargo.Text = "Cargo";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(16, 19);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(102, 18);
            this.lblDepartamento.TabIndex = 15;
            this.lblDepartamento.Text = "Departamento";
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarefas.Location = new System.Drawing.Point(0, 153);
            this.dgvTarefas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.RowTemplate.Height = 28;
            this.dgvTarefas.Size = new System.Drawing.Size(297, 370);
            this.dgvTarefas.TabIndex = 1;
            // 
            // pnlDepartamentoCargo
            // 
            this.pnlDepartamentoCargo.Controls.Add(this.cmbCargo);
            this.pnlDepartamentoCargo.Controls.Add(this.cmbDepartamento);
            this.pnlDepartamentoCargo.Controls.Add(this.lblCargo);
            this.pnlDepartamentoCargo.Controls.Add(this.lblDepartamento);
            this.pnlDepartamentoCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDepartamentoCargo.Location = new System.Drawing.Point(0, 0);
            this.pnlDepartamentoCargo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDepartamentoCargo.Name = "pnlDepartamentoCargo";
            this.pnlDepartamentoCargo.Size = new System.Drawing.Size(297, 153);
            this.pnlDepartamentoCargo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTarefas);
            this.panel1.Controls.Add(this.pnlDepartamentoCargo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 523);
            this.panel1.TabIndex = 20;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(11, 91);
            this.lblSobrenome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(86, 18);
            this.lblSobrenome.TabIndex = 37;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblNumeroUsuario
            // 
            this.lblNumeroUsuario.AutoSize = true;
            this.lblNumeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroUsuario.Location = new System.Drawing.Point(11, 19);
            this.lblNumeroUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroUsuario.Name = "lblNumeroUsuario";
            this.lblNumeroUsuario.Size = new System.Drawing.Size(100, 18);
            this.lblNumeroUsuario.TabIndex = 39;
            this.lblNumeroUsuario.Text = "Nº de Usuário";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(11, 54);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 38;
            this.lblNome.Text = "Nome";
            // 
            // FrmTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNumeroUsuario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbEstadoTarefa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNumeroUsuario);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTarefas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.pnlDepartamentoCargo.ResumeLayout(false);
            this.pnlDepartamentoCargo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbEstadoTarefa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumeroUsuario;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Panel pnlDepartamentoCargo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNumeroUsuario;
        private System.Windows.Forms.Label lblNome;
    }
}