
namespace GerenciadorEmpresarial.Menu
{
    partial class FrmMenuPrincipal
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
            this.btnColaborador = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnSalario = new System.Windows.Forms.Button();
            this.btnPermissao = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.btnCargo = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColaborador
            // 
            this.btnColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaborador.Location = new System.Drawing.Point(12, 12);
            this.btnColaborador.Name = "btnColaborador";
            this.btnColaborador.Size = new System.Drawing.Size(123, 111);
            this.btnColaborador.TabIndex = 0;
            this.btnColaborador.Text = "Colaboradores";
            this.btnColaborador.UseVisualStyleBackColor = true;
            // 
            // btnTarefas
            // 
            this.btnTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarefas.Location = new System.Drawing.Point(177, 12);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(123, 111);
            this.btnTarefas.TabIndex = 1;
            this.btnTarefas.Text = "Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            // 
            // btnSalario
            // 
            this.btnSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalario.Location = new System.Drawing.Point(347, 12);
            this.btnSalario.Name = "btnSalario";
            this.btnSalario.Size = new System.Drawing.Size(123, 111);
            this.btnSalario.TabIndex = 2;
            this.btnSalario.Text = "Salario";
            this.btnSalario.UseVisualStyleBackColor = true;
            // 
            // btnPermissao
            // 
            this.btnPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermissao.Location = new System.Drawing.Point(12, 155);
            this.btnPermissao.Name = "btnPermissao";
            this.btnPermissao.Size = new System.Drawing.Size(123, 111);
            this.btnPermissao.TabIndex = 3;
            this.btnPermissao.Text = "Permissões";
            this.btnPermissao.UseVisualStyleBackColor = true;
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartamento.Location = new System.Drawing.Point(177, 155);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(123, 111);
            this.btnDepartamento.TabIndex = 4;
            this.btnDepartamento.Text = "Departamentos";
            this.btnDepartamento.UseVisualStyleBackColor = true;
            // 
            // btnCargo
            // 
            this.btnCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargo.Location = new System.Drawing.Point(347, 155);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(123, 111);
            this.btnCargo.TabIndex = 5;
            this.btnCargo.Text = "Cargos";
            this.btnCargo.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(95, 321);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 111);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(273, 321);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(123, 111);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 449);
            this.Controls.Add(this.btnCargo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.btnPermissao);
            this.Controls.Add(this.btnSalario);
            this.Controls.Add(this.btnTarefas);
            this.Controls.Add(this.btnColaborador);
            this.Name = "FrmMenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColaborador;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnSalario;
        private System.Windows.Forms.Button btnPermissao;
        private System.Windows.Forms.Button btnDepartamento;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFechar;
    }
}