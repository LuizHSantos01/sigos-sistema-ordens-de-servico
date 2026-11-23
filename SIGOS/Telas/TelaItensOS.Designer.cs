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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalOS = new System.Windows.Forms.TextBox();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.dgvItensServico = new System.Windows.Forms.DataGridView();
            this.btnAdicionarServico = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.txtQuantidadeServico = new System.Windows.Forms.TextBox();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.lblDescricaoServico = new System.Windows.Forms.Label();
            this.lblAdicionarItens = new System.Windows.Forms.Label();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensServico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTotalOS);
            this.panel1.Controls.Add(this.btnRemoverItem);
            this.panel1.Controls.Add(this.dgvItensServico);
            this.panel1.Controls.Add(this.btnAdicionarServico);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPrecoUnitario);
            this.panel1.Controls.Add(this.txtQuantidadeServico);
            this.panel1.Controls.Add(this.cbServico);
            this.panel1.Controls.Add(this.lblDescricaoServico);
            this.panel1.Controls.Add(this.lblAdicionarItens);
            this.panel1.Location = new System.Drawing.Point(61, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 353);
            this.panel1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Total OS:";
            // 
            // txtTotalOS
            // 
            this.txtTotalOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalOS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOS.Location = new System.Drawing.Point(635, 308);
            this.txtTotalOS.Name = "txtTotalOS";
            this.txtTotalOS.Size = new System.Drawing.Size(113, 23);
            this.txtTotalOS.TabIndex = 27;
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.Location = new System.Drawing.Point(44, 299);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(180, 34);
            this.btnRemoverItem.TabIndex = 26;
            this.btnRemoverItem.Text = "Remover item selecionado";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // dgvItensServico
            // 
            this.dgvItensServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensServico.Location = new System.Drawing.Point(44, 123);
            this.dgvItensServico.Name = "dgvItensServico";
            this.dgvItensServico.Size = new System.Drawing.Size(704, 154);
            this.dgvItensServico.TabIndex = 25;
            this.dgvItensServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItensServico_CellContentClick);
            // 
            // btnAdicionarServico
            // 
            this.btnAdicionarServico.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdicionarServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarServico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionarServico.Location = new System.Drawing.Point(44, 83);
            this.btnAdicionarServico.Name = "btnAdicionarServico";
            this.btnAdicionarServico.Size = new System.Drawing.Size(151, 34);
            this.btnAdicionarServico.TabIndex = 24;
            this.btnAdicionarServico.Text = "Adicionar serviço";
            this.btnAdicionarServico.UseVisualStyleBackColor = false;
            this.btnAdicionarServico.Click += new System.EventHandler(this.btnAdicionarServico_Click);
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
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoUnitario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnitario.Location = new System.Drawing.Point(482, 54);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(113, 23);
            this.txtPrecoUnitario.TabIndex = 15;
            // 
            // txtQuantidadeServico
            // 
            this.txtQuantidadeServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidadeServico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeServico.Location = new System.Drawing.Point(363, 54);
            this.txtQuantidadeServico.Name = "txtQuantidadeServico";
            this.txtQuantidadeServico.Size = new System.Drawing.Size(113, 23);
            this.txtQuantidadeServico.TabIndex = 14;
            // 
            // cbServico
            // 
            this.cbServico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Location = new System.Drawing.Point(44, 54);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(313, 23);
            this.cbServico.TabIndex = 13;
            this.cbServico.SelectedIndexChanged += new System.EventHandler(this.cbServico_SelectedIndexChanged);
            // 
            // lblDescricaoServico
            // 
            this.lblDescricaoServico.AutoSize = true;
            this.lblDescricaoServico.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoServico.Location = new System.Drawing.Point(41, 34);
            this.lblDescricaoServico.Name = "lblDescricaoServico";
            this.lblDescricaoServico.Size = new System.Drawing.Size(50, 17);
            this.lblDescricaoServico.TabIndex = 4;
            this.lblDescricaoServico.Text = "Servico";
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
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(767, 12);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(90, 40);
            this.btnMenuPrincipal.TabIndex = 41;
            this.btnMenuPrincipal.Text = "Menu";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // TelaItensOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(907, 498);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "TelaItensOS";
            this.Text = "TelaItensOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdicionarItens;
        private System.Windows.Forms.Label lblDescricaoServico;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.TextBox txtQuantidadeServico;
        private System.Windows.Forms.Button btnAdicionarServico;
        private System.Windows.Forms.DataGridView dgvItensServico;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalOS;
        private System.Windows.Forms.Button btnMenuPrincipal;
    }
}