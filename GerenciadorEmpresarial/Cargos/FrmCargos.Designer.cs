
namespace GerenciadorEmpresarial.Cargos
{
    partial class FrmCargos
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
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDepartamentos = new System.Windows.Forms.Label();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(311, 202);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 47);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(86, 202);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(119, 47);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(234, 60);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(176, 26);
            this.txtCargo.TabIndex = 1;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(85, 60);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 20);
            this.lblCargo.TabIndex = 10;
            this.lblCargo.Text = "Cargo";
            // 
            // lblDepartamentos
            // 
            this.lblDepartamentos.AutoSize = true;
            this.lblDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentos.Location = new System.Drawing.Point(85, 119);
            this.lblDepartamentos.Name = "lblDepartamentos";
            this.lblDepartamentos.Size = new System.Drawing.Size(120, 20);
            this.lblDepartamentos.TabIndex = 12;
            this.lblDepartamentos.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(234, 117);
            this.cmbDepartamentos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(176, 28);
            this.cmbDepartamentos.TabIndex = 13;
            // 
            // FrmCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 283);
            this.Controls.Add(this.cmbDepartamentos);
            this.Controls.Add(this.lblDepartamentos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblCargo);
            this.MaximizeBox = false;
            this.Name = "FrmCargos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargos";
            this.Load += new System.EventHandler(this.FrmCargos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDepartamentos;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
    }
}