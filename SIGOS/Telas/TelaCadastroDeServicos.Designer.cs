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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTecnico = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluirServico = new System.Windows.Forms.Button();
            this.btnEditarServico = new System.Windows.Forms.Button();
            this.btnSalvarServico = new System.Windows.Forms.Button();
            this.btnLimparFormulario = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).BeginInit();
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
            this.cbStatusServico.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbStatusServico.Location = new System.Drawing.Point(480, 238);
            this.cbStatusServico.Name = "cbStatusServico";
            this.cbStatusServico.Size = new System.Drawing.Size(344, 23);
            this.cbStatusServico.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvTecnico);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExcluirServico);
            this.panel1.Controls.Add(this.btnEditarServico);
            this.panel1.Controls.Add(this.btnSalvarServico);
            this.panel1.Controls.Add(this.btnLimparFormulario);
            this.panel1.Controls.Add(this.lblDadosDoServico);
            this.panel1.Location = new System.Drawing.Point(61, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 345);
            this.panel1.TabIndex = 25;
            // 
            // dgvTecnico
            // 
            this.dgvTecnico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecnico.Location = new System.Drawing.Point(-1, 194);
            this.dgvTecnico.Name = "dgvTecnico";
            this.dgvTecnico.Size = new System.Drawing.Size(807, 150);
            this.dgvTecnico.TabIndex = 41;
            this.dgvTecnico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTecnico_CellContentClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(566, 165);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(151, 23);
            this.btnPesquisar.TabIndex = 40;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(201, 165);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(359, 23);
            this.txtPesquisar.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Pesquisar serviço(descricao)";
            // 
            // btnExcluirServico
            // 
            this.btnExcluirServico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluirServico.FlatAppearance.BorderSize = 0;
            this.btnExcluirServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirServico.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirServico.Location = new System.Drawing.Point(201, 125);
            this.btnExcluirServico.Name = "btnExcluirServico";
            this.btnExcluirServico.Size = new System.Drawing.Size(151, 34);
            this.btnExcluirServico.TabIndex = 37;
            this.btnExcluirServico.Text = "Excluir";
            this.btnExcluirServico.UseVisualStyleBackColor = false;
            this.btnExcluirServico.Click += new System.EventHandler(this.btnExcluirServico_Click);
            // 
            // btnEditarServico
            // 
            this.btnEditarServico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditarServico.FlatAppearance.BorderSize = 0;
            this.btnEditarServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarServico.ForeColor = System.Drawing.Color.Black;
            this.btnEditarServico.Location = new System.Drawing.Point(358, 125);
            this.btnEditarServico.Name = "btnEditarServico";
            this.btnEditarServico.Size = new System.Drawing.Size(151, 34);
            this.btnEditarServico.TabIndex = 36;
            this.btnEditarServico.Text = "Editar";
            this.btnEditarServico.UseVisualStyleBackColor = false;
            this.btnEditarServico.Click += new System.EventHandler(this.btnEditarServico_Click);
            // 
            // btnSalvarServico
            // 
            this.btnSalvarServico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvarServico.FlatAppearance.BorderSize = 0;
            this.btnSalvarServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarServico.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarServico.Location = new System.Drawing.Point(515, 125);
            this.btnSalvarServico.Name = "btnSalvarServico";
            this.btnSalvarServico.Size = new System.Drawing.Size(151, 34);
            this.btnSalvarServico.TabIndex = 35;
            this.btnSalvarServico.Text = "Salvar serviço";
            this.btnSalvarServico.UseVisualStyleBackColor = false;
            this.btnSalvarServico.Click += new System.EventHandler(this.btnSalvarServico_Click);
            // 
            // btnLimparFormulario
            // 
            this.btnLimparFormulario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFormulario.Location = new System.Drawing.Point(44, 125);
            this.btnLimparFormulario.Name = "btnLimparFormulario";
            this.btnLimparFormulario.Size = new System.Drawing.Size(151, 34);
            this.btnLimparFormulario.TabIndex = 34;
            this.btnLimparFormulario.Text = "Limpar formulario";
            this.btnLimparFormulario.UseVisualStyleBackColor = true;
            this.btnLimparFormulario.Click += new System.EventHandler(this.btnLimparFormulario_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(778, 12);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(90, 40);
            this.btnMenuPrincipal.TabIndex = 40;
            this.btnMenuPrincipal.Text = "Menu";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // TelaCadastroDeServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(907, 498);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.cbStatusServico);
            this.Controls.Add(this.lblStatusServico);
            this.Controls.Add(this.txtPrecoUnitarioServico);
            this.Controls.Add(this.lblPrecoUnitario);
            this.Controls.Add(this.txtDescricaoServico);
            this.Controls.Add(this.lblDescricaoServico);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroDeServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroDeServicos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluirServico;
        private System.Windows.Forms.Button btnEditarServico;
        private System.Windows.Forms.Button btnSalvarServico;
        private System.Windows.Forms.Button btnLimparFormulario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTecnico;
        private System.Windows.Forms.Button btnMenuPrincipal;
    }
}