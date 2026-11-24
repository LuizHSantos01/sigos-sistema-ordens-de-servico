namespace SIGOS.Telas
{
    partial class TelaConsultaOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaConsultaOS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterarStatus = new System.Windows.Forms.Button();
            this.cbNovoStatusOs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOs = new System.Windows.Forms.DataGridView();
            this.dtpFimOS = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpAberturaOS = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatusOs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimparFormularioServico = new System.Windows.Forms.Button();
            this.btnSalvarServico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoUnitarioServico = new System.Windows.Forms.TextBox();
            this.cbClienteOs = new System.Windows.Forms.ComboBox();
            this.lblDescricaoServico = new System.Windows.Forms.Label();
            this.lblAdicionarItens = new System.Windows.Forms.Label();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAlterarStatus);
            this.panel1.Controls.Add(this.cbNovoStatusOs);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvOs);
            this.panel1.Controls.Add(this.dtpFimOS);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpAberturaOS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbStatusOs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLimparFormularioServico);
            this.panel1.Controls.Add(this.btnSalvarServico);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPrecoUnitarioServico);
            this.panel1.Controls.Add(this.cbClienteOs);
            this.panel1.Controls.Add(this.lblDescricaoServico);
            this.panel1.Controls.Add(this.lblAdicionarItens);
            this.panel1.Location = new System.Drawing.Point(52, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 366);
            this.panel1.TabIndex = 27;
            // 
            // btnAlterarStatus
            // 
            this.btnAlterarStatus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAlterarStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterarStatus.Location = new System.Drawing.Point(44, 327);
            this.btnAlterarStatus.Name = "btnAlterarStatus";
            this.btnAlterarStatus.Size = new System.Drawing.Size(180, 34);
            this.btnAlterarStatus.TabIndex = 36;
            this.btnAlterarStatus.Text = "Alterar status";
            this.btnAlterarStatus.UseVisualStyleBackColor = false;
            // 
            // cbNovoStatusOs
            // 
            this.cbNovoStatusOs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNovoStatusOs.FormattingEnabled = true;
            this.cbNovoStatusOs.Location = new System.Drawing.Point(126, 300);
            this.cbNovoStatusOs.Name = "cbNovoStatusOs";
            this.cbNovoStatusOs.Size = new System.Drawing.Size(243, 23);
            this.cbNovoStatusOs.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Novo Status";
            // 
            // dgvOs
            // 
            this.dgvOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOs.Location = new System.Drawing.Point(44, 168);
            this.dgvOs.Name = "dgvOs";
            this.dgvOs.Size = new System.Drawing.Size(712, 127);
            this.dgvOs.TabIndex = 33;
            // 
            // dtpFimOS
            // 
            this.dtpFimOS.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFimOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFimOS.Location = new System.Drawing.Point(544, 100);
            this.dtpFimOS.Name = "dtpFimOS";
            this.dtpFimOS.Size = new System.Drawing.Size(212, 22);
            this.dtpFimOS.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Até";
            // 
            // dtpAberturaOS
            // 
            this.dtpAberturaOS.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAberturaOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAberturaOS.Location = new System.Drawing.Point(293, 100);
            this.dtpAberturaOS.Name = "dtpAberturaOS";
            this.dtpAberturaOS.Size = new System.Drawing.Size(212, 22);
            this.dtpAberturaOS.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Periodo";
            // 
            // cbStatusOs
            // 
            this.cbStatusOs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusOs.FormattingEnabled = true;
            this.cbStatusOs.Location = new System.Drawing.Point(44, 100);
            this.cbStatusOs.Name = "cbStatusOs";
            this.cbStatusOs.Size = new System.Drawing.Size(243, 23);
            this.cbStatusOs.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Status OS";
            // 
            // btnLimparFormularioServico
            // 
            this.btnLimparFormularioServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFormularioServico.Location = new System.Drawing.Point(390, 128);
            this.btnLimparFormularioServico.Name = "btnLimparFormularioServico";
            this.btnLimparFormularioServico.Size = new System.Drawing.Size(180, 34);
            this.btnLimparFormularioServico.TabIndex = 26;
            this.btnLimparFormularioServico.Text = "Limpar filtros";
            this.btnLimparFormularioServico.UseVisualStyleBackColor = true;
            // 
            // btnSalvarServico
            // 
            this.btnSalvarServico.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalvarServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarServico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarServico.Location = new System.Drawing.Point(576, 128);
            this.btnSalvarServico.Name = "btnSalvarServico";
            this.btnSalvarServico.Size = new System.Drawing.Size(180, 34);
            this.btnSalvarServico.TabIndex = 24;
            this.btnSalvarServico.Text = "Pesquisar";
            this.btnSalvarServico.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cliente";
            // 
            // txtPrecoUnitarioServico
            // 
            this.txtPrecoUnitarioServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoUnitarioServico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitarioServico.Location = new System.Drawing.Point(44, 54);
            this.txtPrecoUnitarioServico.Name = "txtPrecoUnitarioServico";
            this.txtPrecoUnitarioServico.Size = new System.Drawing.Size(313, 23);
            this.txtPrecoUnitarioServico.TabIndex = 14;
            // 
            // cbClienteOs
            // 
            this.cbClienteOs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClienteOs.FormattingEnabled = true;
            this.cbClienteOs.Location = new System.Drawing.Point(363, 53);
            this.cbClienteOs.Name = "cbClienteOs";
            this.cbClienteOs.Size = new System.Drawing.Size(393, 23);
            this.cbClienteOs.TabIndex = 13;
            // 
            // lblDescricaoServico
            // 
            this.lblDescricaoServico.AutoSize = true;
            this.lblDescricaoServico.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoServico.Location = new System.Drawing.Point(41, 34);
            this.lblDescricaoServico.Name = "lblDescricaoServico";
            this.lblDescricaoServico.Size = new System.Drawing.Size(96, 17);
            this.lblDescricaoServico.TabIndex = 4;
            this.lblDescricaoServico.Text = "Número da OS";
            // 
            // lblAdicionarItens
            // 
            this.lblAdicionarItens.AutoSize = true;
            this.lblAdicionarItens.BackColor = System.Drawing.Color.Transparent;
            this.lblAdicionarItens.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarItens.Location = new System.Drawing.Point(40, 5);
            this.lblAdicionarItens.Name = "lblAdicionarItens";
            this.lblAdicionarItens.Size = new System.Drawing.Size(132, 20);
            this.lblAdicionarItens.TabIndex = 2;
            this.lblAdicionarItens.Text = "Filtros de pesquisa";
            this.lblAdicionarItens.Click += new System.EventHandler(this.lblAdicionarItens_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(758, 38);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(90, 40);
            this.btnMenuPrincipal.TabIndex = 42;
            this.btnMenuPrincipal.Text = "Menu";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click_1);
            // 
            // TelaConsultaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(907, 550);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "TelaConsultaOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaConsultaOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvarServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecoUnitarioServico;
        private System.Windows.Forms.ComboBox cbClienteOs;
        private System.Windows.Forms.Label lblDescricaoServico;
        private System.Windows.Forms.Label lblAdicionarItens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStatusOs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimparFormularioServico;
        private System.Windows.Forms.DateTimePicker dtpFimOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpAberturaOS;
        private System.Windows.Forms.DataGridView dgvOs;
        private System.Windows.Forms.Button btnAlterarStatus;
        private System.Windows.Forms.ComboBox cbNovoStatusOs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMenuPrincipal;
    }
}