
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
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblDataPermissao = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.pnlForAdmin = new System.Windows.Forms.Panel();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumeroUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNumeroUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPermissao = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtQuantidadeDias = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblQuantidadeDias = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDataFinal = new System.Windows.Forms.RadioButton();
            this.rbDataInicial = new System.Windows.Forms.RadioButton();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissoes)).BeginInit();
            this.pnlCrud.SuspendLayout();
            this.pnlForAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPermissao.SuspendLayout();
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
            this.btnGravar.Location = new System.Drawing.Point(165, 26);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 38);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(321, 26);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 38);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(479, 26);
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
            this.btnVoltar.Location = new System.Drawing.Point(628, 26);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 38);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // dpStart
            // 
            this.dpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStart.Location = new System.Drawing.Point(125, 36);
            this.dpStart.Margin = new System.Windows.Forms.Padding(2);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(93, 23);
            this.dpStart.TabIndex = 0;
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
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(129, 134);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(210, 28);
            this.cmbPosition.TabIndex = 4;
            // 
            // pnlForAdmin
            // 
            this.pnlForAdmin.Controls.Add(this.cmbPosition);
            this.pnlForAdmin.Controls.Add(this.cmbDepartment);
            this.pnlForAdmin.Controls.Add(this.lblCargo);
            this.pnlForAdmin.Controls.Add(this.lblDepartamento);
            this.pnlForAdmin.Controls.Add(this.txtSurname);
            this.pnlForAdmin.Controls.Add(this.txtName);
            this.pnlForAdmin.Controls.Add(this.txtNumeroUsuario);
            this.pnlForAdmin.Controls.Add(this.label3);
            this.pnlForAdmin.Controls.Add(this.lblNome);
            this.pnlForAdmin.Controls.Add(this.lblNumeroUsuario);
            this.pnlForAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlForAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlForAdmin.Name = "pnlForAdmin";
            this.pnlForAdmin.Size = new System.Drawing.Size(402, 183);
            this.pnlForAdmin.TabIndex = 0;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(129, 99);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(210, 28);
            this.cmbDepartment.TabIndex = 3;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(2, 133);
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
            this.lblDepartamento.Location = new System.Drawing.Point(2, 101);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(102, 18);
            this.lblDepartamento.TabIndex = 21;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(129, 68);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(210, 26);
            this.txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(129, 35);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtNumeroUsuario
            // 
            this.txtNumeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroUsuario.Location = new System.Drawing.Point(129, 4);
            this.txtNumeroUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroUsuario.Name = "txtNumeroUsuario";
            this.txtNumeroUsuario.Size = new System.Drawing.Size(210, 26);
            this.txtNumeroUsuario.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sobrenome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(2, 37);
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
            this.lblNumeroUsuario.Location = new System.Drawing.Point(2, 6);
            this.lblNumeroUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroUsuario.Name = "lblNumeroUsuario";
            this.lblNumeroUsuario.Size = new System.Drawing.Size(100, 18);
            this.lblNumeroUsuario.TabIndex = 19;
            this.lblNumeroUsuario.Text = "Nº de Usuário";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlPermissao);
            this.panel1.Controls.Add(this.pnlForAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 183);
            this.panel1.TabIndex = 3;
            // 
            // pnlPermissao
            // 
            this.pnlPermissao.Controls.Add(this.btnLimpar);
            this.pnlPermissao.Controls.Add(this.cmbState);
            this.pnlPermissao.Controls.Add(this.btnPesquisar);
            this.pnlPermissao.Controls.Add(this.txtQuantidadeDias);
            this.pnlPermissao.Controls.Add(this.lblEstado);
            this.pnlPermissao.Controls.Add(this.lblQuantidadeDias);
            this.pnlPermissao.Controls.Add(this.groupBox1);
            this.pnlPermissao.Controls.Add(this.dpEnd);
            this.pnlPermissao.Controls.Add(this.dpStart);
            this.pnlPermissao.Controls.Add(this.lblFinal);
            this.pnlPermissao.Controls.Add(this.lblInicio);
            this.pnlPermissao.Controls.Add(this.lblDataPermissao);
            this.pnlPermissao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPermissao.Location = new System.Drawing.Point(402, 0);
            this.pnlPermissao.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPermissao.Name = "pnlPermissao";
            this.pnlPermissao.Size = new System.Drawing.Size(462, 183);
            this.pnlPermissao.TabIndex = 1;
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
            // cmbState
            // 
            this.cmbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(125, 134);
            this.cmbState.Margin = new System.Windows.Forms.Padding(2);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(141, 28);
            this.cmbState.TabIndex = 3;
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
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(4, 133);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 18);
            this.lblEstado.TabIndex = 21;
            this.lblEstado.Text = "Estado";
            // 
            // lblQuantidadeDias
            // 
            this.lblQuantidadeDias.AutoSize = true;
            this.lblQuantidadeDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeDias.Location = new System.Drawing.Point(4, 101);
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
            this.groupBox1.Location = new System.Drawing.Point(222, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(123, 84);
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
            // dpEnd
            // 
            this.dpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEnd.Location = new System.Drawing.Point(125, 70);
            this.dpEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(93, 23);
            this.dpEnd.TabIndex = 1;
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
            this.pnlPermissao.ResumeLayout(false);
            this.pnlPermissao.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblDataPermissao;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Panel pnlForAdmin;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumeroUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNumeroUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPermissao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtQuantidadeDias;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblQuantidadeDias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDataFinal;
        private System.Windows.Forms.RadioButton rbDataInicial;
        private System.Windows.Forms.DateTimePicker dpEnd;
    }
}