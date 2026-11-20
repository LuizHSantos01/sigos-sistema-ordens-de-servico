namespace SIGOS.Telas
{
    partial class TelaMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenuPrincipal));
            this.btnTelaClientes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTelaTecnicos = new System.Windows.Forms.Button();
            this.btnTelaEquipamentos = new System.Windows.Forms.Button();
            this.btnTelaServicos = new System.Windows.Forms.Button();
            this.btnTelaAbrirOS = new System.Windows.Forms.Button();
            this.btnTelaConsulta = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnTestarConexaoBanco = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTelaClientes
            // 
            this.btnTelaClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelaClientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTelaClientes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaClientes.Location = new System.Drawing.Point(3, 3);
            this.btnTelaClientes.Name = "btnTelaClientes";
            this.btnTelaClientes.Size = new System.Drawing.Size(210, 90);
            this.btnTelaClientes.TabIndex = 0;
            this.btnTelaClientes.Text = "Clientes";
            this.btnTelaClientes.UseVisualStyleBackColor = true;
            this.btnTelaClientes.Click += new System.EventHandler(this.btnTelaClientes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnTelaConsulta);
            this.panel1.Controls.Add(this.btnTelaAbrirOS);
            this.panel1.Controls.Add(this.btnTelaServicos);
            this.panel1.Controls.Add(this.btnTelaEquipamentos);
            this.panel1.Controls.Add(this.btnTelaTecnicos);
            this.panel1.Controls.Add(this.btnTelaClientes);
            this.panel1.Location = new System.Drawing.Point(72, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 291);
            this.panel1.TabIndex = 1;
            // 
            // btnTelaTecnicos
            // 
            this.btnTelaTecnicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelaTecnicos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTelaTecnicos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaTecnicos.Location = new System.Drawing.Point(219, 3);
            this.btnTelaTecnicos.Name = "btnTelaTecnicos";
            this.btnTelaTecnicos.Size = new System.Drawing.Size(210, 90);
            this.btnTelaTecnicos.TabIndex = 1;
            this.btnTelaTecnicos.Text = "Técnicos";
            this.btnTelaTecnicos.UseVisualStyleBackColor = true;
            this.btnTelaTecnicos.Click += new System.EventHandler(this.btnTelaTecnicos_Click);
            // 
            // btnTelaEquipamentos
            // 
            this.btnTelaEquipamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelaEquipamentos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTelaEquipamentos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaEquipamentos.Location = new System.Drawing.Point(435, 3);
            this.btnTelaEquipamentos.Name = "btnTelaEquipamentos";
            this.btnTelaEquipamentos.Size = new System.Drawing.Size(210, 90);
            this.btnTelaEquipamentos.TabIndex = 2;
            this.btnTelaEquipamentos.Text = "Equipamentos";
            this.btnTelaEquipamentos.UseVisualStyleBackColor = true;
            this.btnTelaEquipamentos.Click += new System.EventHandler(this.btnTelaEquipamentos_Click);
            // 
            // btnTelaServicos
            // 
            this.btnTelaServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelaServicos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTelaServicos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaServicos.Location = new System.Drawing.Point(3, 99);
            this.btnTelaServicos.Name = "btnTelaServicos";
            this.btnTelaServicos.Size = new System.Drawing.Size(210, 90);
            this.btnTelaServicos.TabIndex = 3;
            this.btnTelaServicos.Text = "Serviços";
            this.btnTelaServicos.UseVisualStyleBackColor = true;
            this.btnTelaServicos.Click += new System.EventHandler(this.btnTelaServicos_Click);
            // 
            // btnTelaAbrirOS
            // 
            this.btnTelaAbrirOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelaAbrirOS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTelaAbrirOS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaAbrirOS.Location = new System.Drawing.Point(219, 99);
            this.btnTelaAbrirOS.Name = "btnTelaAbrirOS";
            this.btnTelaAbrirOS.Size = new System.Drawing.Size(210, 90);
            this.btnTelaAbrirOS.TabIndex = 4;
            this.btnTelaAbrirOS.Text = "Abrir OS";
            this.btnTelaAbrirOS.UseVisualStyleBackColor = true;
            this.btnTelaAbrirOS.Click += new System.EventHandler(this.btnTelaAbrirOS_Click);
            // 
            // btnTelaConsulta
            // 
            this.btnTelaConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTelaConsulta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaConsulta.Location = new System.Drawing.Point(435, 99);
            this.btnTelaConsulta.Name = "btnTelaConsulta";
            this.btnTelaConsulta.Size = new System.Drawing.Size(210, 90);
            this.btnTelaConsulta.TabIndex = 5;
            this.btnTelaConsulta.Text = "Consultar OS";
            this.btnTelaConsulta.UseVisualStyleBackColor = true;
            this.btnTelaConsulta.Click += new System.EventHandler(this.btnTelaConsulta_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(219, 195);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 90);
            this.button6.TabIndex = 6;
            this.button6.Text = "Histórico OS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnTestarConexaoBanco
            // 
            this.btnTestarConexaoBanco.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarConexaoBanco.Location = new System.Drawing.Point(291, 427);
            this.btnTestarConexaoBanco.Name = "btnTestarConexaoBanco";
            this.btnTestarConexaoBanco.Size = new System.Drawing.Size(210, 23);
            this.btnTestarConexaoBanco.TabIndex = 2;
            this.btnTestarConexaoBanco.Text = "Testar conexão com o banco";
            this.btnTestarConexaoBanco.UseVisualStyleBackColor = true;
            this.btnTestarConexaoBanco.Click += new System.EventHandler(this.btnTestarConexaoBanco_Click);
            // 
            // TelaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestarConexaoBanco);
            this.Controls.Add(this.panel1);
            this.Name = "TelaMenuPrincipal";
            this.Text = "TelaMenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTelaClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnTelaConsulta;
        private System.Windows.Forms.Button btnTelaAbrirOS;
        private System.Windows.Forms.Button btnTelaServicos;
        private System.Windows.Forms.Button btnTelaEquipamentos;
        private System.Windows.Forms.Button btnTelaTecnicos;
        private System.Windows.Forms.Button btnTestarConexaoBanco;
    }
}