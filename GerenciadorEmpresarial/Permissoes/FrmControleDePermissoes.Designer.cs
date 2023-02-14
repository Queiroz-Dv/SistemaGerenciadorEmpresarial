
namespace GerenciadorEmpresarial.Permissoes
{
    partial class FrmControleDePermissoes
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
            this.dgvPermissoes = new System.Windows.Forms.DataGridView();
            this.btnRecusar = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblDataPermissao = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.pnlForAdmin = new System.Windows.Forms.Panel();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumeroUsuario = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNumeroUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPesquisaPermissao = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbEstadosTarefa = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtQuantidadeDias = new System.Windows.Forms.TextBox();
            this.lblEstadoTarefas = new System.Windows.Forms.Label();
            this.lblQuantidadeDias = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDataFinal = new System.Windows.Forms.RadioButton();
            this.rbDataInicial = new System.Windows.Forms.RadioButton();
            this.dpFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissoes)).BeginInit();
            this.pnlCrud.SuspendLayout();
            this.pnlForAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPesquisaPermissao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPermissoes
            // 
            this.dgvPermissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermissoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPermissoes.Location = new System.Drawing.Point(0, 183);
            this.dgvPermissoes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPermissoes.MultiSelect = false;
            this.dgvPermissoes.Name = "dgvPermissoes";
            this.dgvPermissoes.RowTemplate.Height = 28;
            this.dgvPermissoes.Size = new System.Drawing.Size(864, 214);
            this.dgvPermissoes.TabIndex = 5;
            // 
            // btnRecusar
            // 
            this.btnRecusar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecusar.Location = new System.Drawing.Point(22, 52);
            this.btnRecusar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecusar.Name = "btnRecusar";
            this.btnRecusar.Size = new System.Drawing.Size(109, 38);
            this.btnRecusar.TabIndex = 1;
            this.btnRecusar.Text = "Recusar";
            this.btnRecusar.UseVisualStyleBackColor = true;
            // 
            // btnAprovar
            // 
            this.btnAprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovar.Location = new System.Drawing.Point(22, 4);
            this.btnAprovar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(109, 38);
            this.btnAprovar.TabIndex = 0;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(192, 30);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 38);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(348, 30);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 38);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(506, 30);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 38);
            this.btnDeletar.TabIndex = 4;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // pnlCrud
            // 
            this.pnlCrud.Controls.Add(this.btnRecusar);
            this.pnlCrud.Controls.Add(this.btnAprovar);
            this.pnlCrud.Controls.Add(this.btnGravar);
            this.pnlCrud.Controls.Add(this.btnAtualizar);
            this.pnlCrud.Controls.Add(this.btnDeletar);
            this.pnlCrud.Controls.Add(this.btnVoltar);
            this.pnlCrud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCrud.Location = new System.Drawing.Point(0, 397);
            this.pnlCrud.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(864, 98);
            this.pnlCrud.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(655, 30);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 38);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dpInicio
            // 
            this.dpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpInicio.Location = new System.Drawing.Point(125, 36);
            this.dpInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dpInicio.Name = "dpInicio";
            this.dpInicio.Size = new System.Drawing.Size(93, 23);
            this.dpInicio.TabIndex = 0;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(4, 71);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(39, 18);
            this.lblFinal.TabIndex = 14;
            this.lblFinal.Text = "Final";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(4, 37);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(42, 18);
            this.lblInicio.TabIndex = 15;
            this.lblInicio.Text = "Início";
            // 
            // lblDataPermissao
            // 
            this.lblDataPermissao.AutoSize = true;
            this.lblDataPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPermissao.Location = new System.Drawing.Point(4, 6);
            this.lblDataPermissao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataPermissao.Name = "lblDataPermissao";
            this.lblDataPermissao.Size = new System.Drawing.Size(161, 20);
            this.lblDataPermissao.TabIndex = 16;
            this.lblDataPermissao.Text = "Data de Permissão";
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(163, 136);
            this.cmbCargo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(210, 28);
            this.cmbCargo.TabIndex = 4;
            // 
            // pnlForAdmin
            // 
            this.pnlForAdmin.Controls.Add(this.cmbCargo);
            this.pnlForAdmin.Controls.Add(this.cmbDepartamento);
            this.pnlForAdmin.Controls.Add(this.lblCargo);
            this.pnlForAdmin.Controls.Add(this.lblDepartamento);
            this.pnlForAdmin.Controls.Add(this.txtSobrenome);
            this.pnlForAdmin.Controls.Add(this.txtNome);
            this.pnlForAdmin.Controls.Add(this.txtNumeroUsuario);
            this.pnlForAdmin.Controls.Add(this.lblSobrenome);
            this.pnlForAdmin.Controls.Add(this.lblNome);
            this.pnlForAdmin.Controls.Add(this.lblNumeroUsuario);
            this.pnlForAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlForAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlForAdmin.Name = "pnlForAdmin";
            this.pnlForAdmin.Size = new System.Drawing.Size(402, 183);
            this.pnlForAdmin.TabIndex = 0;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(163, 101);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(210, 28);
            this.cmbDepartamento.TabIndex = 3;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(19, 141);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(49, 18);
            this.lblCargo.TabIndex = 20;
            this.lblCargo.Text = "Cargo";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(19, 109);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(102, 18);
            this.lblDepartamento.TabIndex = 21;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(163, 70);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(2);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(210, 26);
            this.txtSobrenome.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(163, 37);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(210, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtNumeroUsuario
            // 
            this.txtNumeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroUsuario.Location = new System.Drawing.Point(163, 6);
            this.txtNumeroUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroUsuario.Name = "txtNumeroUsuario";
            this.txtNumeroUsuario.Size = new System.Drawing.Size(210, 26);
            this.txtNumeroUsuario.TabIndex = 0;
            this.txtNumeroUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroUsuario_KeyPress);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(19, 79);
            this.lblSobrenome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(86, 18);
            this.lblSobrenome.TabIndex = 17;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(19, 45);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome";
            // 
            // lblNumeroUsuario
            // 
            this.lblNumeroUsuario.AutoSize = true;
            this.lblNumeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroUsuario.Location = new System.Drawing.Point(19, 14);
            this.lblNumeroUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroUsuario.Name = "lblNumeroUsuario";
            this.lblNumeroUsuario.Size = new System.Drawing.Size(100, 18);
            this.lblNumeroUsuario.TabIndex = 19;
            this.lblNumeroUsuario.Text = "Nº de Usuário";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlPesquisaPermissao);
            this.panel1.Controls.Add(this.pnlForAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 183);
            this.panel1.TabIndex = 3;
            // 
            // pnlPesquisaPermissao
            // 
            this.pnlPesquisaPermissao.Controls.Add(this.btnLimpar);
            this.pnlPesquisaPermissao.Controls.Add(this.cmbEstadosTarefa);
            this.pnlPesquisaPermissao.Controls.Add(this.btnPesquisar);
            this.pnlPesquisaPermissao.Controls.Add(this.txtQuantidadeDias);
            this.pnlPesquisaPermissao.Controls.Add(this.lblEstadoTarefas);
            this.pnlPesquisaPermissao.Controls.Add(this.lblQuantidadeDias);
            this.pnlPesquisaPermissao.Controls.Add(this.groupBox1);
            this.pnlPesquisaPermissao.Controls.Add(this.dpFinal);
            this.pnlPesquisaPermissao.Controls.Add(this.dpInicio);
            this.pnlPesquisaPermissao.Controls.Add(this.lblFinal);
            this.pnlPesquisaPermissao.Controls.Add(this.lblInicio);
            this.pnlPesquisaPermissao.Controls.Add(this.lblDataPermissao);
            this.pnlPesquisaPermissao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPesquisaPermissao.Location = new System.Drawing.Point(402, 0);
            this.pnlPesquisaPermissao.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPesquisaPermissao.Name = "pnlPesquisaPermissao";
            this.pnlPesquisaPermissao.Size = new System.Drawing.Size(462, 183);
            this.pnlPesquisaPermissao.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(347, 134);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 27);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // cmbEstadosTarefa
            // 
            this.cmbEstadosTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadosTarefa.FormattingEnabled = true;
            this.cmbEstadosTarefa.Location = new System.Drawing.Point(155, 134);
            this.cmbEstadosTarefa.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstadosTarefa.Name = "cmbEstadosTarefa";
            this.cmbEstadosTarefa.Size = new System.Drawing.Size(141, 28);
            this.cmbEstadosTarefa.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(347, 101);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 27);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtQuantidadeDias
            // 
            this.txtQuantidadeDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeDias.Location = new System.Drawing.Point(125, 99);
            this.txtQuantidadeDias.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidadeDias.Name = "txtQuantidadeDias";
            this.txtQuantidadeDias.Size = new System.Drawing.Size(93, 26);
            this.txtQuantidadeDias.TabIndex = 2;
            this.txtQuantidadeDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeDias_KeyPress);
            // 
            // lblEstadoTarefas
            // 
            this.lblEstadoTarefas.AutoSize = true;
            this.lblEstadoTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoTarefas.Location = new System.Drawing.Point(5, 138);
            this.lblEstadoTarefas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoTarefas.Name = "lblEstadoTarefas";
            this.lblEstadoTarefas.Size = new System.Drawing.Size(132, 18);
            this.lblEstadoTarefas.TabIndex = 21;
            this.lblEstadoTarefas.Text = "Estado das tarefas";
            // 
            // lblQuantidadeDias
            // 
            this.lblQuantidadeDias.AutoSize = true;
            this.lblQuantidadeDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeDias.Location = new System.Drawing.Point(5, 101);
            this.lblQuantidadeDias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidadeDias.Name = "lblQuantidadeDias";
            this.lblQuantidadeDias.Size = new System.Drawing.Size(70, 18);
            this.lblQuantidadeDias.TabIndex = 21;
            this.lblQuantidadeDias.Text = "Qtd. Dias";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDataFinal);
            this.groupBox1.Controls.Add(this.rbDataInicial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(222, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(123, 71);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // rbDataFinal
            // 
            this.rbDataFinal.AutoSize = true;
            this.rbDataFinal.Location = new System.Drawing.Point(4, 48);
            this.rbDataFinal.Margin = new System.Windows.Forms.Padding(2);
            this.rbDataFinal.Name = "rbDataFinal";
            this.rbDataFinal.Size = new System.Drawing.Size(87, 21);
            this.rbDataFinal.TabIndex = 1;
            this.rbDataFinal.TabStop = true;
            this.rbDataFinal.Text = "Dt. Final";
            this.rbDataFinal.UseVisualStyleBackColor = true;
            // 
            // rbDataInicial
            // 
            this.rbDataInicial.AutoSize = true;
            this.rbDataInicial.Location = new System.Drawing.Point(4, 9);
            this.rbDataInicial.Margin = new System.Windows.Forms.Padding(2);
            this.rbDataInicial.Name = "rbDataInicial";
            this.rbDataInicial.Size = new System.Drawing.Size(94, 21);
            this.rbDataInicial.TabIndex = 0;
            this.rbDataInicial.TabStop = true;
            this.rbDataInicial.Text = "Dt. Inicial";
            this.rbDataInicial.UseVisualStyleBackColor = true;
            // 
            // dpFinal
            // 
            this.dpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFinal.Location = new System.Drawing.Point(125, 70);
            this.dpFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dpFinal.Name = "dpFinal";
            this.dpFinal.Size = new System.Drawing.Size(93, 23);
            this.dpFinal.TabIndex = 1;
            // 
            // FrmControleDePermissoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 495);
            this.Controls.Add(this.dgvPermissoes);
            this.Controls.Add(this.pnlCrud);
            this.Controls.Add(this.panel1);
            this.Name = "FrmControleDePermissoes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle De Permissoes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissoes)).EndInit();
            this.pnlCrud.ResumeLayout(false);
            this.pnlForAdmin.ResumeLayout(false);
            this.pnlForAdmin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlPesquisaPermissao.ResumeLayout(false);
            this.pnlPesquisaPermissao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPermissoes;
        private System.Windows.Forms.Button btnRecusar;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Panel pnlCrud;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DateTimePicker dpInicio;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblDataPermissao;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Panel pnlForAdmin;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumeroUsuario;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNumeroUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPesquisaPermissao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbEstadosTarefa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtQuantidadeDias;
        private System.Windows.Forms.Label lblEstadoTarefas;
        private System.Windows.Forms.Label lblQuantidadeDias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDataFinal;
        private System.Windows.Forms.RadioButton rbDataInicial;
        private System.Windows.Forms.DateTimePicker dpFinal;
    }
}