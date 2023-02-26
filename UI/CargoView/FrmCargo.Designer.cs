
namespace UI.CargoView
{
    partial class FrmCargo
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNovoCargo = new System.Windows.Forms.TextBox();
            this.lblNovoCargo = new System.Windows.Forms.Label();
            this.lblDepartamentos = new System.Windows.Forms.Label();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.Location = new System.Drawing.Point(222, 205);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 47);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(67, 205);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(119, 47);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtNovoCargo
            // 
            this.txtNovoCargo.Location = new System.Drawing.Point(178, 58);
            this.txtNovoCargo.Name = "txtNovoCargo";
            this.txtNovoCargo.Size = new System.Drawing.Size(199, 23);
            this.txtNovoCargo.TabIndex = 10;
            // 
            // lblNovoCargo
            // 
            this.lblNovoCargo.AutoSize = true;
            this.lblNovoCargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNovoCargo.Location = new System.Drawing.Point(22, 56);
            this.lblNovoCargo.Name = "lblNovoCargo";
            this.lblNovoCargo.Size = new System.Drawing.Size(94, 21);
            this.lblNovoCargo.TabIndex = 9;
            this.lblNovoCargo.Text = "Novo Cargo";
            // 
            // lblDepartamentos
            // 
            this.lblDepartamentos.AutoSize = true;
            this.lblDepartamentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartamentos.Location = new System.Drawing.Point(22, 117);
            this.lblDepartamentos.Name = "lblDepartamentos";
            this.lblDepartamentos.Size = new System.Drawing.Size(117, 21);
            this.lblDepartamentos.TabIndex = 13;
            this.lblDepartamentos.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(178, 110);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(199, 28);
            this.cmbDepartamentos.TabIndex = 14;
            // 
            // FrmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 310);
            this.Controls.Add(this.cmbDepartamentos);
            this.Controls.Add(this.lblDepartamentos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNovoCargo);
            this.Controls.Add(this.lblNovoCargo);
            this.MaximizeBox = false;
            this.Name = "FrmCargo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cargos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNovoCargo;
        private System.Windows.Forms.Label lblNovoCargo;
        private System.Windows.Forms.Label lblDepartamentos;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
    }
}