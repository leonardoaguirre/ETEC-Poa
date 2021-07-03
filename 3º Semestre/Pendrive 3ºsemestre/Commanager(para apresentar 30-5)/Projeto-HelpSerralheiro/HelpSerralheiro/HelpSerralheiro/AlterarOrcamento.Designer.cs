namespace HelpSerralheiro
{
    partial class AlterarOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarOrcamento));
            this.btSair = new System.Windows.Forms.Button();
            this.txtClienteOrcamento = new System.Windows.Forms.TextBox();
            this.btnOculto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVendedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtTotalOrcamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFreteOrcamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescontoOrcamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorItensOrcamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dgvOrcamento = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(140, 487);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(141, 48);
            this.btSair.TabIndex = 40;
            this.btSair.Text = "Cancelar";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // txtClienteOrcamento
            // 
            this.txtClienteOrcamento.Location = new System.Drawing.Point(140, 63);
            this.txtClienteOrcamento.Name = "txtClienteOrcamento";
            this.txtClienteOrcamento.Size = new System.Drawing.Size(224, 21);
            this.txtClienteOrcamento.TabIndex = 39;
            // 
            // btnOculto
            // 
            this.btnOculto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOculto.Location = new System.Drawing.Point(651, 90);
            this.btnOculto.Name = "btnOculto";
            this.btnOculto.Size = new System.Drawing.Size(75, 23);
            this.btnOculto.TabIndex = 38;
            this.btnOculto.UseVisualStyleBackColor = true;
            this.btnOculto.Visible = false;
            this.btnOculto.Click += new System.EventHandler(this.btnOculto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::HelpSerralheiro.Properties.Resources.form;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.txtClienteOrcamento);
            this.panel1.Controls.Add(this.btnOculto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtVendedor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGerar);
            this.panel1.Controls.Add(this.txtTotalOrcamento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtFreteOrcamento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDescontoOrcamento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtValorItensOrcamento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnIncluir);
            this.panel1.Controls.Add(this.dgvOrcamento);
            this.panel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-30, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 579);
            this.panel1.TabIndex = 1;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.FormattingEnabled = true;
            this.txtVendedor.Location = new System.Drawing.Point(490, 63);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(257, 21);
            this.txtVendedor.TabIndex = 33;
            this.txtVendedor.Click += new System.EventHandler(this.txtVendedor_Click);
            this.txtVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendedor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nome do Vendedor / Atendente";
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(140, 416);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(141, 48);
            this.btnGerar.TabIndex = 31;
            this.btnGerar.Text = "Alterar Orçamento";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtTotalOrcamento
            // 
            this.txtTotalOrcamento.Enabled = false;
            this.txtTotalOrcamento.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrcamento.Location = new System.Drawing.Point(629, 471);
            this.txtTotalOrcamento.Multiline = true;
            this.txtTotalOrcamento.Name = "txtTotalOrcamento";
            this.txtTotalOrcamento.ReadOnly = true;
            this.txtTotalOrcamento.Size = new System.Drawing.Size(118, 31);
            this.txtTotalOrcamento.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Valor Total";
            // 
            // txtFreteOrcamento
            // 
            this.txtFreteOrcamento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreteOrcamento.Location = new System.Drawing.Point(629, 431);
            this.txtFreteOrcamento.Name = "txtFreteOrcamento";
            this.txtFreteOrcamento.Size = new System.Drawing.Size(80, 21);
            this.txtFreteOrcamento.TabIndex = 28;
            this.txtFreteOrcamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFreteOrcamento_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(540, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Valor do Frete";
            // 
            // txtDescontoOrcamento
            // 
            this.txtDescontoOrcamento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoOrcamento.Location = new System.Drawing.Point(629, 401);
            this.txtDescontoOrcamento.Name = "txtDescontoOrcamento";
            this.txtDescontoOrcamento.Size = new System.Drawing.Size(80, 21);
            this.txtDescontoOrcamento.TabIndex = 26;
            this.txtDescontoOrcamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescontoOrcamento_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(568, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Desconto";
            // 
            // txtValorItensOrcamento
            // 
            this.txtValorItensOrcamento.Enabled = false;
            this.txtValorItensOrcamento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorItensOrcamento.Location = new System.Drawing.Point(629, 369);
            this.txtValorItensOrcamento.Name = "txtValorItensOrcamento";
            this.txtValorItensOrcamento.ReadOnly = true;
            this.txtValorItensOrcamento.Size = new System.Drawing.Size(80, 21);
            this.txtValorItensOrcamento.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Valor dos itens";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(247, 359);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 39);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir Produto";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(140, 359);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(101, 39);
            this.btnIncluir.TabIndex = 20;
            this.btnIncluir.Text = "Incluir Produto";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // dgvOrcamento
            // 
            this.dgvOrcamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrcamento.Location = new System.Drawing.Point(140, 121);
            this.dgvOrcamento.Name = "dgvOrcamento";
            this.dgvOrcamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrcamento.Size = new System.Drawing.Size(607, 232);
            this.dgvOrcamento.TabIndex = 19;
            // 
            // AlterarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HelpSerralheiro.Properties.Resources.blur_wallpaper_HD_Download1;
            this.ClientSize = new System.Drawing.Size(842, 573);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlterarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commanager";
            this.Load += new System.EventHandler(this.AlterarOrcamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TextBox txtClienteOrcamento;
        private System.Windows.Forms.Button btnOculto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtTotalOrcamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFreteOrcamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescontoOrcamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorItensOrcamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView dgvOrcamento;

    }
}