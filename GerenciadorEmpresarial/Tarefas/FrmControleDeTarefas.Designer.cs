
namespace GerenciadorEmpresarial.Tarefas
{
    partial class FrmControleDeTarefas
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
            this.dgvControleTarefas = new System.Windows.Forms.DataGridView();
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.pnlForAdmin = new System.Windows.Forms.Panel();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumeroUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDtInicial = new System.Windows.Forms.Label();
            this.lblDataTarefa = new System.Windows.Forms.Label();
            this.pnlPesquisaTarefa = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbTaskState = new System.Windows.Forms.ComboBox();
            this.grpbData = new System.Windows.Forms.GroupBox();
            this.rbDataEntrega = new System.Windows.Forms.RadioButton();
            this.rbDataInicial = new System.Windows.Forms.RadioButton();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEstadoTarefa = new System.Windows.Forms.Label();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNumeroUsuario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControleTarefas)).BeginInit();
            this.pnlCrud.SuspendLayout();
            this.pnlForAdmin.SuspendLayout();
            this.pnlPesquisaTarefa.SuspendLayout();
            this.grpbData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvControleTarefas
            // 
            this.dgvControleTarefas.AllowUserToOrderColumns = true;
            this.dgvControleTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControleTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControleTarefas.Location = new System.Drawing.Point(0, 220);
            this.dgvControleTarefas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvControleTarefas.MultiSelect = false;
            this.dgvControleTarefas.Name = "dgvControleTarefas";
            this.dgvControleTarefas.RowTemplate.Height = 28;
            this.dgvControleTarefas.Size = new System.Drawing.Size(838, 214);
            this.dgvControleTarefas.TabIndex = 5;
            // 
            // pnlCrud
            // 
            this.pnlCrud.Controls.Add(this.btnAprovar);
            this.pnlCrud.Controls.Add(this.btnGravar);
            this.pnlCrud.Controls.Add(this.btnAtualizar);
            this.pnlCrud.Controls.Add(this.btnDeletar);
            this.pnlCrud.Controls.Add(this.btnVoltar);
            this.pnlCrud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCrud.Location = new System.Drawing.Point(0, 434);
            this.pnlCrud.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(838, 86);
            this.pnlCrud.TabIndex = 4;
            // 
            // pnlForAdmin
            // 
            this.pnlForAdmin.Controls.Add(this.lblSobrenome);
            this.pnlForAdmin.Controls.Add(this.lblNumeroUsuario);
            this.pnlForAdmin.Controls.Add(this.lblNome);
            this.pnlForAdmin.Controls.Add(this.lblCargo);
            this.pnlForAdmin.Controls.Add(this.lblDepartamento);
            this.pnlForAdmin.Controls.Add(this.cmbCargo);
            this.pnlForAdmin.Controls.Add(this.cmbDepartamento);
            this.pnlForAdmin.Controls.Add(this.txtSobrenome);
            this.pnlForAdmin.Controls.Add(this.txtNome);
            this.pnlForAdmin.Controls.Add(this.txtNumeroUsuario);
            this.pnlForAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlForAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlForAdmin.Name = "pnlForAdmin";
            this.pnlForAdmin.Size = new System.Drawing.Size(397, 220);
            this.pnlForAdmin.TabIndex = 0;
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(156, 170);
            this.cmbCargo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(176, 28);
            this.cmbCargo.TabIndex = 4;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(156, 128);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(176, 28);
            this.cmbDepartamento.TabIndex = 3;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(156, 88);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(2);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(176, 26);
            this.txtSobrenome.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(156, 50);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtNumeroUsuario
            // 
            this.txtNumeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroUsuario.Location = new System.Drawing.Point(156, 14);
            this.txtNumeroUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroUsuario.Name = "txtNumeroUsuario";
            this.txtNumeroUsuario.Size = new System.Drawing.Size(176, 26);
            this.txtNumeroUsuario.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dt. Final";
            // 
            // lblDtInicial
            // 
            this.lblDtInicial.AutoSize = true;
            this.lblDtInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtInicial.Location = new System.Drawing.Point(11, 53);
            this.lblDtInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtInicial.Name = "lblDtInicial";
            this.lblDtInicial.Size = new System.Drawing.Size(67, 18);
            this.lblDtInicial.TabIndex = 9;
            this.lblDtInicial.Text = "Dt. Inicial";
            // 
            // lblDataTarefa
            // 
            this.lblDataTarefa.AutoSize = true;
            this.lblDataTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTarefa.Location = new System.Drawing.Point(11, 17);
            this.lblDataTarefa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataTarefa.Name = "lblDataTarefa";
            this.lblDataTarefa.Size = new System.Drawing.Size(121, 18);
            this.lblDataTarefa.TabIndex = 9;
            this.lblDataTarefa.Text = "Data das Tarefas";
            // 
            // pnlPesquisaTarefa
            // 
            this.pnlPesquisaTarefa.Controls.Add(this.btnLimpar);
            this.pnlPesquisaTarefa.Controls.Add(this.btnPesquisar);
            this.pnlPesquisaTarefa.Controls.Add(this.cmbTaskState);
            this.pnlPesquisaTarefa.Controls.Add(this.grpbData);
            this.pnlPesquisaTarefa.Controls.Add(this.dpEnd);
            this.pnlPesquisaTarefa.Controls.Add(this.lblEstadoTarefa);
            this.pnlPesquisaTarefa.Controls.Add(this.dpStart);
            this.pnlPesquisaTarefa.Controls.Add(this.label8);
            this.pnlPesquisaTarefa.Controls.Add(this.lblDtInicial);
            this.pnlPesquisaTarefa.Controls.Add(this.lblDataTarefa);
            this.pnlPesquisaTarefa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPesquisaTarefa.Location = new System.Drawing.Point(397, 0);
            this.pnlPesquisaTarefa.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPesquisaTarefa.Name = "pnlPesquisaTarefa";
            this.pnlPesquisaTarefa.Size = new System.Drawing.Size(441, 220);
            this.pnlPesquisaTarefa.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(249, 175);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 27);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(68, 175);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 27);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // cmbTaskState
            // 
            this.cmbTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTaskState.FormattingEnabled = true;
            this.cmbTaskState.Location = new System.Drawing.Point(172, 131);
            this.cmbTaskState.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTaskState.Name = "cmbTaskState";
            this.cmbTaskState.Size = new System.Drawing.Size(176, 28);
            this.cmbTaskState.TabIndex = 2;
            // 
            // grpbData
            // 
            this.grpbData.Controls.Add(this.rbDataEntrega);
            this.grpbData.Controls.Add(this.rbDataInicial);
            this.grpbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbData.Location = new System.Drawing.Point(249, 41);
            this.grpbData.Margin = new System.Windows.Forms.Padding(2);
            this.grpbData.Name = "grpbData";
            this.grpbData.Padding = new System.Windows.Forms.Padding(2);
            this.grpbData.Size = new System.Drawing.Size(153, 81);
            this.grpbData.TabIndex = 11;
            this.grpbData.TabStop = false;
            // 
            // rbDataEntrega
            // 
            this.rbDataEntrega.AutoSize = true;
            this.rbDataEntrega.Location = new System.Drawing.Point(4, 42);
            this.rbDataEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.rbDataEntrega.Name = "rbDataEntrega";
            this.rbDataEntrega.Size = new System.Drawing.Size(145, 21);
            this.rbDataEntrega.TabIndex = 1;
            this.rbDataEntrega.TabStop = true;
            this.rbDataEntrega.Text = "Data de Entrega";
            this.rbDataEntrega.UseVisualStyleBackColor = true;
            // 
            // rbDataInicial
            // 
            this.rbDataInicial.AutoSize = true;
            this.rbDataInicial.Location = new System.Drawing.Point(4, 11);
            this.rbDataInicial.Margin = new System.Windows.Forms.Padding(2);
            this.rbDataInicial.Name = "rbDataInicial";
            this.rbDataInicial.Size = new System.Drawing.Size(107, 21);
            this.rbDataInicial.TabIndex = 0;
            this.rbDataInicial.TabStop = true;
            this.rbDataInicial.Text = "Data Inicial";
            this.rbDataInicial.UseVisualStyleBackColor = true;
            // 
            // dpEnd
            // 
            this.dpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEnd.Location = new System.Drawing.Point(114, 90);
            this.dpEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(111, 23);
            this.dpEnd.TabIndex = 1;
            // 
            // lblEstadoTarefa
            // 
            this.lblEstadoTarefa.AutoSize = true;
            this.lblEstadoTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoTarefa.Location = new System.Drawing.Point(11, 132);
            this.lblEstadoTarefa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoTarefa.Name = "lblEstadoTarefa";
            this.lblEstadoTarefa.Size = new System.Drawing.Size(132, 18);
            this.lblEstadoTarefa.TabIndex = 10;
            this.lblEstadoTarefa.Text = "Estado das tarefas";
            // 
            // dpStart
            // 
            this.dpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStart.Location = new System.Drawing.Point(114, 51);
            this.dpStart.Margin = new System.Windows.Forms.Padding(2);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(111, 23);
            this.dpStart.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlPesquisaTarefa);
            this.panel1.Controls.Add(this.pnlForAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 220);
            this.panel1.TabIndex = 3;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(11, 96);
            this.lblSobrenome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(86, 18);
            this.lblSobrenome.TabIndex = 42;
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
            this.lblNumeroUsuario.TabIndex = 44;
            this.lblNumeroUsuario.Text = "Nº de Usuário";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(11, 55);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 43;
            this.lblNome.Text = "Nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(11, 175);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(49, 18);
            this.lblCargo.TabIndex = 40;
            this.lblCargo.Text = "Cargo";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(11, 135);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(102, 18);
            this.lblDepartamento.TabIndex = 41;
            this.lblDepartamento.Text = "Departamento";
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(232, 23);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 38);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(370, 23);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 38);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(511, 23);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 38);
            this.btnDeletar.TabIndex = 8;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(657, 23);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 38);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnAprovar
            // 
            this.btnAprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovar.Location = new System.Drawing.Point(76, 23);
            this.btnAprovar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(109, 38);
            this.btnAprovar.TabIndex = 10;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = true;
            // 
            // FrmControleDeTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 520);
            this.Controls.Add(this.dgvControleTarefas);
            this.Controls.Add(this.pnlCrud);
            this.Controls.Add(this.panel1);
            this.Name = "FrmControleDeTarefas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle De Tarefas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvControleTarefas)).EndInit();
            this.pnlCrud.ResumeLayout(false);
            this.pnlForAdmin.ResumeLayout(false);
            this.pnlForAdmin.PerformLayout();
            this.pnlPesquisaTarefa.ResumeLayout(false);
            this.pnlPesquisaTarefa.PerformLayout();
            this.grpbData.ResumeLayout(false);
            this.grpbData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvControleTarefas;
        private System.Windows.Forms.Panel pnlCrud;
        private System.Windows.Forms.Panel pnlForAdmin;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumeroUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDtInicial;
        private System.Windows.Forms.Label lblDataTarefa;
        private System.Windows.Forms.Panel pnlPesquisaTarefa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cmbTaskState;
        private System.Windows.Forms.GroupBox grpbData;
        private System.Windows.Forms.RadioButton rbDataEntrega;
        private System.Windows.Forms.RadioButton rbDataInicial;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.Label lblEstadoTarefa;
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNumeroUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAprovar;
    }
}