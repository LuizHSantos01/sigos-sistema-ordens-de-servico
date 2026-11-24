namespace SIGOS.Telas
{
    partial class TelaCadastroDeTecnicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroDeTecnicos));
            this.lblNomeTecnico = new System.Windows.Forms.Label();
            this.txtNomeTecnico = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefoneTecnico = new System.Windows.Forms.TextBox();
            this.txtEspecialidadeTecnico = new System.Windows.Forms.TextBox();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatusTecnico = new System.Windows.Forms.ComboBox();
            this.btnExcluirTecnico = new System.Windows.Forms.Button();
            this.btnEditarTecnico = new System.Windows.Forms.Button();
            this.btnSalvarTecnico = new System.Windows.Forms.Button();
            this.btnLimparFormulario = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTecnico = new System.Windows.Forms.DataGridView();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeTecnico
            // 
            this.lblNomeTecnico.AutoSize = true;
            this.lblNomeTecnico.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeTecnico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTecnico.Location = new System.Drawing.Point(99, 180);
            this.lblNomeTecnico.Name = "lblNomeTecnico";
            this.lblNomeTecnico.Size = new System.Drawing.Size(44, 17);
            this.lblNomeTecnico.TabIndex = 0;
            this.lblNomeTecnico.Text = "Nome";
            this.lblNomeTecnico.Click += new System.EventHandler(this.lblNomeTecnico_Click);
            // 
            // txtNomeTecnico
            // 
            this.txtNomeTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeTecnico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTecnico.Location = new System.Drawing.Point(102, 200);
            this.txtNomeTecnico.Name = "txtNomeTecnico";
            this.txtNomeTecnico.Size = new System.Drawing.Size(368, 23);
            this.txtNomeTecnico.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(473, 180);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(57, 17);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtTelefoneTecnico
            // 
            this.txtTelefoneTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneTecnico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneTecnico.Location = new System.Drawing.Point(476, 200);
            this.txtTelefoneTecnico.Name = "txtTelefoneTecnico";
            this.txtTelefoneTecnico.Size = new System.Drawing.Size(337, 23);
            this.txtTelefoneTecnico.TabIndex = 3;
            // 
            // txtEspecialidadeTecnico
            // 
            this.txtEspecialidadeTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEspecialidadeTecnico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidadeTecnico.Location = new System.Drawing.Point(102, 246);
            this.txtEspecialidadeTecnico.Name = "txtEspecialidadeTecnico";
            this.txtEspecialidadeTecnico.Size = new System.Drawing.Size(368, 23);
            this.txtEspecialidadeTecnico.TabIndex = 5;
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecialidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidade.Location = new System.Drawing.Point(99, 226);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(88, 17);
            this.lblEspecialidade.TabIndex = 4;
            this.lblEspecialidade.Text = "Especialidade";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(473, 226);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 17);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // cbStatusTecnico
            // 
            this.cbStatusTecnico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusTecnico.FormattingEnabled = true;
            this.cbStatusTecnico.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbStatusTecnico.Location = new System.Drawing.Point(476, 246);
            this.cbStatusTecnico.Name = "cbStatusTecnico";
            this.cbStatusTecnico.Size = new System.Drawing.Size(337, 23);
            this.cbStatusTecnico.TabIndex = 29;
            // 
            // btnExcluirTecnico
            // 
            this.btnExcluirTecnico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluirTecnico.FlatAppearance.BorderSize = 0;
            this.btnExcluirTecnico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTecnico.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirTecnico.Location = new System.Drawing.Point(259, 275);
            this.btnExcluirTecnico.Name = "btnExcluirTecnico";
            this.btnExcluirTecnico.Size = new System.Drawing.Size(151, 34);
            this.btnExcluirTecnico.TabIndex = 33;
            this.btnExcluirTecnico.Text = "Excluir";
            this.btnExcluirTecnico.UseVisualStyleBackColor = false;
            this.btnExcluirTecnico.Click += new System.EventHandler(this.btnExcluirTecnico_Click);
            // 
            // btnEditarTecnico
            // 
            this.btnEditarTecnico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditarTecnico.FlatAppearance.BorderSize = 0;
            this.btnEditarTecnico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTecnico.ForeColor = System.Drawing.Color.Black;
            this.btnEditarTecnico.Location = new System.Drawing.Point(416, 275);
            this.btnEditarTecnico.Name = "btnEditarTecnico";
            this.btnEditarTecnico.Size = new System.Drawing.Size(151, 34);
            this.btnEditarTecnico.TabIndex = 32;
            this.btnEditarTecnico.Text = "Editar";
            this.btnEditarTecnico.UseVisualStyleBackColor = false;
            this.btnEditarTecnico.Click += new System.EventHandler(this.btnEditarTecnico_Click);
            // 
            // btnSalvarTecnico
            // 
            this.btnSalvarTecnico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvarTecnico.FlatAppearance.BorderSize = 0;
            this.btnSalvarTecnico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTecnico.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarTecnico.Location = new System.Drawing.Point(573, 275);
            this.btnSalvarTecnico.Name = "btnSalvarTecnico";
            this.btnSalvarTecnico.Size = new System.Drawing.Size(151, 34);
            this.btnSalvarTecnico.TabIndex = 31;
            this.btnSalvarTecnico.Text = "Salvar técnico";
            this.btnSalvarTecnico.UseVisualStyleBackColor = false;
            this.btnSalvarTecnico.Click += new System.EventHandler(this.btnSalvarTecnico_Click);
            // 
            // btnLimparFormulario
            // 
            this.btnLimparFormulario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFormulario.Location = new System.Drawing.Point(102, 275);
            this.btnLimparFormulario.Name = "btnLimparFormulario";
            this.btnLimparFormulario.Size = new System.Drawing.Size(151, 34);
            this.btnLimparFormulario.TabIndex = 30;
            this.btnLimparFormulario.Text = "Limpar formulario";
            this.btnLimparFormulario.UseVisualStyleBackColor = true;
            this.btnLimparFormulario.Click += new System.EventHandler(this.btnLimparFormulario_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(624, 315);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(151, 23);
            this.btnPesquisar.TabIndex = 36;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(259, 315);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(359, 23);
            this.txtPesquisar.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Pesquisar tecnico(nome)";
            // 
            // dgvTecnico
            // 
            this.dgvTecnico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecnico.Location = new System.Drawing.Point(58, 344);
            this.dgvTecnico.Name = "dgvTecnico";
            this.dgvTecnico.Size = new System.Drawing.Size(788, 142);
            this.dgvTecnico.TabIndex = 37;
            this.dgvTecnico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTecnico_CellClick);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(758, 12);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(90, 40);
            this.btnMenuPrincipal.TabIndex = 38;
            this.btnMenuPrincipal.Text = "Menu";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // TelaCadastroDeTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(907, 498);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.dgvTecnico);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluirTecnico);
            this.Controls.Add(this.btnEditarTecnico);
            this.Controls.Add(this.btnSalvarTecnico);
            this.Controls.Add(this.btnLimparFormulario);
            this.Controls.Add(this.cbStatusTecnico);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtEspecialidadeTecnico);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.txtTelefoneTecnico);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNomeTecnico);
            this.Controls.Add(this.lblNomeTecnico);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroDeTecnicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroDeTecnicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeTecnico;
        private System.Windows.Forms.TextBox txtNomeTecnico;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefoneTecnico;
        private System.Windows.Forms.TextBox txtEspecialidadeTecnico;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatusTecnico;
        private System.Windows.Forms.Button btnExcluirTecnico;
        private System.Windows.Forms.Button btnEditarTecnico;
        private System.Windows.Forms.Button btnSalvarTecnico;
        private System.Windows.Forms.Button btnLimparFormulario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTecnico;
        private System.Windows.Forms.Button btnMenuPrincipal;
    }
}