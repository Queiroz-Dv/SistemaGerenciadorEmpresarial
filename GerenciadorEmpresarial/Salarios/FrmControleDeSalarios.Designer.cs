
namespace GerenciadorEmpresarial.Salarios
{
    partial class FrmControleDeSalarios
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
            this.dgvControleSalarios = new System.Windows.Forms.DataGridView();
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlForAdmin = new System.Windows.Forms.Panel();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNumeroUsuario = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.grpbPesquisarSalario = new System.Windows.Forms.GroupBox();
            this.rbIgual = new System.Windows.Forms.RadioButton();
            this.rbMenos = new System.Windows.Forms.RadioButton();
            this.rbMais = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlForSearch = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControleSalarios)).BeginInit();
            this.pnlCrud.SuspendLayout();
            this.pnlForAdmin.SuspendLayout();
            this.grpbPesquisarSalario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlForSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvControleSalarios
            // 
            this.dgvControleSalarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControleSalarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControleSalarios.Location = new System.Drawing.Point(0, 167);
            this.dgvControleSalarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvControleSalarios.MultiSelect = false;
            this.dgvControleSalarios.Name = "dgvControleSalarios";
            this.dgvControleSalarios.RowTemplate.Height = 28;
            this.dgvControleSalarios.Size = new System.Drawing.Size(960, 274);
            this.dgvControleSalarios.TabIndex = 5;
            // 
            // pnlCrud
            // 
            this.pnlCrud.Controls.Add(this.btnGravar);
            this.pnlCrud.Controls.Add(this.btnAtualizar);
            this.pnlCrud.Controls.Add(this.btnDeletar);
            this.pnlCrud.Controls.Add(this.btnVoltar);
            this.pnlCrud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCrud.Location = new System.Drawing.Point(0, 441);
            this.pnlCrud.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(960, 71);
            this.pnlCrud.TabIndex = 4;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(199, 18);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 38);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(355, 18);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 38);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(513, 18);
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
            this.btnVoltar.Location = new System.Drawing.Point(662, 18);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 38);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pnlForAdmin
            // 
            this.pnlForAdmin.Controls.Add(this.cmbPosition);
            this.pnlForAdmin.Controls.Add(this.cmbDepartment);
            this.pnlForAdmin.Controls.Add(this.lblCargo);
            this.pnlForAdmin.Controls.Add(this.lblDepartamento);
            this.pnlForAdmin.Controls.Add(this.txtSurname);
            this.pnlForAdmin.Controls.Add(this.txtName);
            this.pnlForAdmin.Controls.Add(this.txtUserNo);
            this.pnlForAdmin.Controls.Add(this.lblSobrenome);
            this.pnlForAdmin.Controls.Add(this.lblNome);
            this.pnlForAdmin.Controls.Add(this.lblNumeroUsuario);
            this.pnlForAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlForAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlForAdmin.Name = "pnlForAdmin";
            this.pnlForAdmin.Size = new System.Drawing.Size(483, 167);
            this.pnlForAdmin.TabIndex = 0;
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(196, 130);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(210, 28);
            this.cmbPosition.TabIndex = 4;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(196, 97);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(210, 28);
            this.cmbDepartment.TabIndex = 3;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(22, 132);
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
            this.lblDepartamento.Location = new System.Drawing.Point(22, 99);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(102, 18);
            this.lblDepartamento.TabIndex = 21;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(196, 66);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(210, 26);
            this.txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(196, 36);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNo.Location = new System.Drawing.Point(196, 4);
            this.txtUserNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(210, 26);
            this.txtUserNo.TabIndex = 0;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(22, 70);
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
            this.lblNome.Location = new System.Drawing.Point(22, 38);
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
            this.lblNumeroUsuario.Location = new System.Drawing.Point(22, 8);
            this.lblNumeroUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroUsuario.Name = "lblNumeroUsuario";
            this.lblNumeroUsuario.Size = new System.Drawing.Size(100, 18);
            this.lblNumeroUsuario.TabIndex = 19;
            this.lblNumeroUsuario.Text = "Nº de Usuário";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(125, 6);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(121, 26);
            this.txtSalary.TabIndex = 0;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(27, 38);
            this.lblAno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(34, 18);
            this.lblAno.TabIndex = 28;
            this.lblAno.Text = "Ano";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(27, 12);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(54, 18);
            this.lblSalario.TabIndex = 29;
            this.lblSalario.Text = "Salário";
            // 
            // grpbPesquisarSalario
            // 
            this.grpbPesquisarSalario.Controls.Add(this.rbIgual);
            this.grpbPesquisarSalario.Controls.Add(this.rbMenos);
            this.grpbPesquisarSalario.Controls.Add(this.rbMais);
            this.grpbPesquisarSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPesquisarSalario.Location = new System.Drawing.Point(274, 11);
            this.grpbPesquisarSalario.Margin = new System.Windows.Forms.Padding(2);
            this.grpbPesquisarSalario.Name = "grpbPesquisarSalario";
            this.grpbPesquisarSalario.Padding = new System.Windows.Forms.Padding(2);
            this.grpbPesquisarSalario.Size = new System.Drawing.Size(159, 88);
            this.grpbPesquisarSalario.TabIndex = 6;
            this.grpbPesquisarSalario.TabStop = false;
            // 
            // rbIgual
            // 
            this.rbIgual.AutoSize = true;
            this.rbIgual.Location = new System.Drawing.Point(0, 64);
            this.rbIgual.Margin = new System.Windows.Forms.Padding(2);
            this.rbIgual.Name = "rbIgual";
            this.rbIgual.Size = new System.Drawing.Size(61, 21);
            this.rbIgual.TabIndex = 2;
            this.rbIgual.TabStop = true;
            this.rbIgual.Text = "Igual";
            this.rbIgual.UseVisualStyleBackColor = true;
            // 
            // rbMenos
            // 
            this.rbMenos.AutoSize = true;
            this.rbMenos.Location = new System.Drawing.Point(0, 37);
            this.rbMenos.Margin = new System.Windows.Forms.Padding(2);
            this.rbMenos.Name = "rbMenos";
            this.rbMenos.Size = new System.Drawing.Size(73, 21);
            this.rbMenos.TabIndex = 1;
            this.rbMenos.TabStop = true;
            this.rbMenos.Text = "Menos";
            this.rbMenos.UseVisualStyleBackColor = true;
            // 
            // rbMais
            // 
            this.rbMais.AutoSize = true;
            this.rbMais.Location = new System.Drawing.Point(0, 7);
            this.rbMais.Margin = new System.Windows.Forms.Padding(2);
            this.rbMais.Name = "rbMais";
            this.rbMais.Size = new System.Drawing.Size(59, 21);
            this.rbMais.TabIndex = 0;
            this.rbMais.TabStop = true;
            this.rbMais.Text = "Mais";
            this.rbMais.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlForSearch);
            this.panel1.Controls.Add(this.pnlForAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 167);
            this.panel1.TabIndex = 3;
            // 
            // pnlForSearch
            // 
            this.pnlForSearch.Controls.Add(this.btnLimpar);
            this.pnlForSearch.Controls.Add(this.btnPesquisar);
            this.pnlForSearch.Controls.Add(this.grpbPesquisarSalario);
            this.pnlForSearch.Controls.Add(this.cmbMonth);
            this.pnlForSearch.Controls.Add(this.lblMes);
            this.pnlForSearch.Controls.Add(this.txtYear);
            this.pnlForSearch.Controls.Add(this.txtSalary);
            this.pnlForSearch.Controls.Add(this.lblAno);
            this.pnlForSearch.Controls.Add(this.lblSalario);
            this.pnlForSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForSearch.Location = new System.Drawing.Point(483, 0);
            this.pnlForSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnlForSearch.Name = "pnlForSearch";
            this.pnlForSearch.Size = new System.Drawing.Size(477, 167);
            this.pnlForSearch.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(250, 127);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 27);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(125, 127);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 27);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(125, 68);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 28);
            this.cmbMonth.TabIndex = 2;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(27, 70);
            this.lblMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(37, 18);
            this.lblMes.TabIndex = 30;
            this.lblMes.Text = "Mês";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(125, 36);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 26);
            this.txtYear.TabIndex = 1;
            // 
            // FrmControleDeSalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 512);
            this.Controls.Add(this.dgvControleSalarios);
            this.Controls.Add(this.pnlCrud);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmControleDeSalarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle De Salarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvControleSalarios)).EndInit();
            this.pnlCrud.ResumeLayout(false);
            this.pnlForAdmin.ResumeLayout(false);
            this.pnlForAdmin.PerformLayout();
            this.grpbPesquisarSalario.ResumeLayout(false);
            this.grpbPesquisarSalario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlForSearch.ResumeLayout(false);
            this.pnlForSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvControleSalarios;
        private System.Windows.Forms.Panel pnlCrud;
        private System.Windows.Forms.Panel pnlForAdmin;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNumeroUsuario;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.GroupBox grpbPesquisarSalario;
        private System.Windows.Forms.RadioButton rbIgual;
        private System.Windows.Forms.RadioButton rbMenos;
        private System.Windows.Forms.RadioButton rbMais;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlForSearch;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnVoltar;
    }
}