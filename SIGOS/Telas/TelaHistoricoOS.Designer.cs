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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvHistoricoOs = new System.Windows.Forms.DataGridView();
            this.txtNumeroDaOS = new System.Windows.Forms.TextBox();
            this.lblDescricaoServico = new System.Windows.Forms.Label();
            this.lblDadosDaOS = new System.Windows.Forms.Label();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoOs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.dgvHistoricoOs);
            this.panel1.Controls.Add(this.txtNumeroDaOS);
            this.panel1.Controls.Add(this.lblDescricaoServico);
            this.panel1.Controls.Add(this.lblDadosDaOS);
            this.panel1.Location = new System.Drawing.Point(59, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 366);
            this.panel1.TabIndex = 28;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(171, 54);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(151, 23);
            this.btnPesquisar.TabIndex = 45;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvHistoricoOs
            // 
            this.dgvHistoricoOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricoOs.Location = new System.Drawing.Point(44, 83);
            this.dgvHistoricoOs.Name = "dgvHistoricoOs";
            this.dgvHistoricoOs.Size = new System.Drawing.Size(712, 154);
            this.dgvHistoricoOs.TabIndex = 33;
            // 
            // txtNumeroDaOS
            // 
            this.txtNumeroDaOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroDaOS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDaOS.Location = new System.Drawing.Point(44, 54);
            this.txtNumeroDaOS.Name = "txtNumeroDaOS";
            this.txtNumeroDaOS.Size = new System.Drawing.Size(121, 23);
            this.txtNumeroDaOS.TabIndex = 14;
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
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(765, 12);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(90, 40);
            this.btnMenuPrincipal.TabIndex = 29;
            this.btnMenuPrincipal.Text = "Menu";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // TelaHistoricoOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(907, 498);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "TelaHistoricoOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaHistoricoOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoOs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHistoricoOs;
        private System.Windows.Forms.TextBox txtNumeroDaOS;
        private System.Windows.Forms.Label lblDescricaoServico;
        private System.Windows.Forms.Label lblDadosDaOS;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnMenuPrincipal;
    }
}