namespace SIGOS.Telas
{
    partial class TelaCadastroDeServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroDeServicos));
            this.lblDadosDoServico = new System.Windows.Forms.Label();
            this.lblDescricaoServico = new System.Windows.Forms.Label();
            this.txtDescricaoServico = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitarioServico = new System.Windows.Forms.TextBox();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.lblStatusServico = new System.Windows.Forms.Label();
            this.cbStatusServico = new System.Windows.Forms.ComboBox();
            this.btnSalvarServico = new System.Windows.Forms.Button();
            this.btnLimparFormularioServico = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDadosDoServico
            // 
            this.lblDadosDoServico.AutoSize = true;
            this.lblDadosDoServico.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosDoServico.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDoServico.Location = new System.Drawing.Point(40, 5);
            this.lblDadosDoServico.Name = "lblDadosDoServico";
            this.lblDadosDoServico.Size = new System.Drawing.Size(124, 20);
            this.lblDadosDoServico.TabIndex = 2;
            this.lblDadosDoServico.Text = "Dados do serviço";
            this.lblDadosDoServico.Click += new System.EventHandler(this.lblDadosPessoaisEmpresa_Click);
            // 
            // lblDescricaoServico
            // 
            this.lblDescricaoServico.AutoSize = true;
            this.lblDescricaoServico.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoServico.Location = new System.Drawing.Point(103, 171);
            this.lblDescricaoServico.Name = "lblDescricaoServico";
            this.lblDescricaoServico.Size = new System.Drawing.Size(130, 17);
            this.lblDescricaoServico.TabIndex = 3;
            this.lblDescricaoServico.Text = "Descrição do serviço";
            // 
            // txtDescricaoServico
            // 
            this.txtDescricaoServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoServico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoServico.Location = new System.Drawing.Point(106, 191);
            this.txtDescricaoServico.Name = "txtDescricaoServico";
            this.txtDescricaoServico.Size = new System.Drawing.Size(718, 23);
            this.txtDescricaoServico.TabIndex = 8;
            // 
            // txtPrecoUnitarioServico
            // 
            this.txtPrecoUnitarioServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoUnitarioServico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitarioServico.Location = new System.Drawing.Point(106, 238);
            this.txtPrecoUnitarioServico.Name = "txtPrecoUnitarioServico";
            this.txtPrecoUnitarioServico.Size = new System.Drawing.Size(368, 23);
            this.txtPrecoUnitarioServico.TabIndex = 10;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoUnitario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoUnitario.Location = new System.Drawing.Point(103, 217);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(119, 17);
            this.lblPrecoUnitario.TabIndex = 9;
            this.lblPrecoUnitario.Text = "Preço unitário (R$):";
            // 
            // lblStatusServico
            // 
            this.lblStatusServico.AutoSize = true;
            this.lblStatusServico.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusServico.Location = new System.Drawing.Point(477, 217);
            this.lblStatusServico.Name = "lblStatusServico";
            this.lblStatusServico.Size = new System.Drawing.Size(43, 17);
            this.lblStatusServico.TabIndex = 11;
            this.lblStatusServico.Text = "Status";
            // 
            // cbStatusServico
            // 
            this.cbStatusServico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusServico.FormattingEnabled = true;
            this.cbStatusServico.Location = new System.Drawing.Point(480, 238);
            this.cbStatusServico.Name = "cbStatusServico";
            this.cbStatusServico.Size = new System.Drawing.Size(344, 23);
            this.cbStatusServico.TabIndex = 12;
            // 
            // btnSalvarServico
            // 
            this.btnSalvarServico.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalvarServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarServico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarServico.Location = new System.Drawing.Point(611, 156);
            this.btnSalvarServico.Name = "btnSalvarServico";
            this.btnSalvarServico.Size = new System.Drawing.Size(151, 34);
            this.btnSalvarServico.TabIndex = 23;
            this.btnSalvarServico.Text = "Salvar serviço";
            this.btnSalvarServico.UseVisualStyleBackColor = false;
            // 
            // btnLimparFormularioServico
            // 
            this.btnLimparFormularioServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFormularioServico.Location = new System.Drawing.Point(454, 156);
            this.btnLimparFormularioServico.Name = "btnLimparFormularioServico";
            this.btnLimparFormularioServico.Size = new System.Drawing.Size(151, 34);
            this.btnLimparFormularioServico.TabIndex = 24;
            this.btnLimparFormularioServico.Text = "Limpar formulário";
            this.btnLimparFormularioServico.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDadosDoServico);
            this.panel1.Controls.Add(this.btnLimparFormularioServico);
            this.panel1.Controls.Add(this.btnSalvarServico);
            this.panel1.Location = new System.Drawing.Point(61, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 233);
            this.panel1.TabIndex = 25;
            // 
            // TelaCadastroDeServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(907, 498);
            this.Controls.Add(this.cbStatusServico);
            this.Controls.Add(this.lblStatusServico);
            this.Controls.Add(this.txtPrecoUnitarioServico);
            this.Controls.Add(this.lblPrecoUnitario);
            this.Controls.Add(this.txtDescricaoServico);
            this.Controls.Add(this.lblDescricaoServico);
            this.Controls.Add(this.panel1);
            this.Name = "TelaCadastroDeServicos";
            this.Text = "TelaCadastroDeServicos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDadosDoServico;
        private System.Windows.Forms.Label lblDescricaoServico;
        private System.Windows.Forms.TextBox txtDescricaoServico;
        private System.Windows.Forms.TextBox txtPrecoUnitarioServico;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Label lblStatusServico;
        private System.Windows.Forms.ComboBox cbStatusServico;
        private System.Windows.Forms.Button btnSalvarServico;
        private System.Windows.Forms.Button btnLimparFormularioServico;
        private System.Windows.Forms.Panel panel1;
    }
}