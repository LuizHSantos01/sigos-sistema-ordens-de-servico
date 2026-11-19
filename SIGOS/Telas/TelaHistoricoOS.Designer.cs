namespace SIGOS.Telas
{
    partial class TelaHistoricoOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaHistoricoOS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblEquipamento = new System.Windows.Forms.Label();
            this.btnLimparFormularioServico = new System.Windows.Forms.Button();
            this.btnSalvarServico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoUnitarioServico = new System.Windows.Forms.TextBox();
            this.cbStatusServico = new System.Windows.Forms.ComboBox();
            this.lblDescricaoServico = new System.Windows.Forms.Label();
            this.lblDadosDaOS = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblEquipamento);
            this.panel1.Controls.Add(this.btnLimparFormularioServico);
            this.panel1.Controls.Add(this.btnSalvarServico);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPrecoUnitarioServico);
            this.panel1.Controls.Add(this.cbStatusServico);
            this.panel1.Controls.Add(this.lblDescricaoServico);
            this.panel1.Controls.Add(this.lblDadosDaOS);
            this.panel1.Location = new System.Drawing.Point(59, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 366);
            this.panel1.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 154);
            this.dataGridView1.TabIndex = 33;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(459, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 23);
            this.comboBox1.TabIndex = 28;
            // 
            // lblEquipamento
            // 
            this.lblEquipamento.AutoSize = true;
            this.lblEquipamento.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipamento.Location = new System.Drawing.Point(456, 34);
            this.lblEquipamento.Name = "lblEquipamento";
            this.lblEquipamento.Size = new System.Drawing.Size(85, 17);
            this.lblEquipamento.TabIndex = 27;
            this.lblEquipamento.Text = "Equipamento";
            // 
            // btnLimparFormularioServico
            // 
            this.btnLimparFormularioServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFormularioServico.Location = new System.Drawing.Point(44, 83);
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
            this.btnSalvarServico.Location = new System.Drawing.Point(230, 83);
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
            this.label1.Location = new System.Drawing.Point(164, 34);
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
            this.txtPrecoUnitarioServico.Size = new System.Drawing.Size(114, 23);
            this.txtPrecoUnitarioServico.TabIndex = 14;
            // 
            // cbStatusServico
            // 
            this.cbStatusServico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusServico.FormattingEnabled = true;
            this.cbStatusServico.Location = new System.Drawing.Point(164, 54);
            this.cbStatusServico.Name = "cbStatusServico";
            this.cbStatusServico.Size = new System.Drawing.Size(289, 23);
            this.cbStatusServico.TabIndex = 13;
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
            // lblDadosDaOS
            // 
            this.lblDadosDaOS.AutoSize = true;
            this.lblDadosDaOS.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosDaOS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDaOS.Location = new System.Drawing.Point(40, 5);
            this.lblDadosDaOS.Name = "lblDadosDaOS";
            this.lblDadosDaOS.Size = new System.Drawing.Size(96, 20);
            this.lblDadosDaOS.TabIndex = 2;
            this.lblDadosDaOS.Text = "Dados da OS";
            // 
            // TelaHistoricoOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(907, 498);
            this.Controls.Add(this.panel1);
            this.Name = "TelaHistoricoOS";
            this.Text = "TelaHistoricoOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblEquipamento;
        private System.Windows.Forms.Button btnLimparFormularioServico;
        private System.Windows.Forms.Button btnSalvarServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecoUnitarioServico;
        private System.Windows.Forms.ComboBox cbStatusServico;
        private System.Windows.Forms.Label lblDescricaoServico;
        private System.Windows.Forms.Label lblDadosDaOS;
    }
}