namespace SIGOS.Telas
{
    partial class TelaItensOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaItensOS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdicionarItens = new System.Windows.Forms.Label();
            this.lblDescricaoServico = new System.Windows.Forms.Label();
            this.cbStatusServico = new System.Windows.Forms.ComboBox();
            this.txtPrecoUnitarioServico = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvarServico = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLimparFormularioServico = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLimparFormularioServico);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnSalvarServico);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtPrecoUnitarioServico);
            this.panel1.Controls.Add(this.cbStatusServico);
            this.panel1.Controls.Add(this.lblDescricaoServico);
            this.panel1.Controls.Add(this.lblAdicionarItens);
            this.panel1.Location = new System.Drawing.Point(61, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 353);
            this.panel1.TabIndex = 26;
            // 
            // lblAdicionarItens
            // 
            this.lblAdicionarItens.AutoSize = true;
            this.lblAdicionarItens.BackColor = System.Drawing.Color.Transparent;
            this.lblAdicionarItens.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarItens.Location = new System.Drawing.Point(40, 5);
            this.lblAdicionarItens.Name = "lblAdicionarItens";
            this.lblAdicionarItens.Size = new System.Drawing.Size(108, 20);
            this.lblAdicionarItens.TabIndex = 2;
            this.lblAdicionarItens.Text = "Adicionar itens";
            // 
            // lblDescricaoServico
            // 
            this.lblDescricaoServico.AutoSize = true;
            this.lblDescricaoServico.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoServico.Location = new System.Drawing.Point(41, 34);
            this.lblDescricaoServico.Name = "lblDescricaoServico";
            this.lblDescricaoServico.Size = new System.Drawing.Size(47, 17);
            this.lblDescricaoServico.TabIndex = 4;
            this.lblDescricaoServico.Text = "Cliente";
            // 
            // cbStatusServico
            // 
            this.cbStatusServico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusServico.FormattingEnabled = true;
            this.cbStatusServico.Location = new System.Drawing.Point(44, 54);
            this.cbStatusServico.Name = "cbStatusServico";
            this.cbStatusServico.Size = new System.Drawing.Size(313, 23);
            this.cbStatusServico.TabIndex = 13;
            // 
            // txtPrecoUnitarioServico
            // 
            this.txtPrecoUnitarioServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoUnitarioServico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitarioServico.Location = new System.Drawing.Point(363, 54);
            this.txtPrecoUnitarioServico.Name = "txtPrecoUnitarioServico";
            this.txtPrecoUnitarioServico.Size = new System.Drawing.Size(113, 23);
            this.txtPrecoUnitarioServico.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(482, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 23);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Preço unitario (R$)";
            // 
            // btnSalvarServico
            // 
            this.btnSalvarServico.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalvarServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarServico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarServico.Location = new System.Drawing.Point(44, 83);
            this.btnSalvarServico.Name = "btnSalvarServico";
            this.btnSalvarServico.Size = new System.Drawing.Size(151, 34);
            this.btnSalvarServico.TabIndex = 24;
            this.btnSalvarServico.Text = "Salvar serviço";
            this.btnSalvarServico.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 154);
            this.dataGridView1.TabIndex = 25;
            // 
            // btnLimparFormularioServico
            // 
            this.btnLimparFormularioServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFormularioServico.Location = new System.Drawing.Point(44, 299);
            this.btnLimparFormularioServico.Name = "btnLimparFormularioServico";
            this.btnLimparFormularioServico.Size = new System.Drawing.Size(180, 34);
            this.btnLimparFormularioServico.TabIndex = 26;
            this.btnLimparFormularioServico.Text = "Remover item selecionado";
            this.btnLimparFormularioServico.UseVisualStyleBackColor = true;
            // 
            // TelaItensOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(907, 498);
            this.Controls.Add(this.panel1);
            this.Name = "TelaItensOS";
            this.Text = "TelaItensOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdicionarItens;
        private System.Windows.Forms.Label lblDescricaoServico;
        private System.Windows.Forms.ComboBox cbStatusServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPrecoUnitarioServico;
        private System.Windows.Forms.Button btnSalvarServico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLimparFormularioServico;
    }
}