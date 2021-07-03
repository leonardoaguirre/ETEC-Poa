namespace HelpSerralheiro
{
    partial class AlterarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOculto = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFrete = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescontos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorItens = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoraEntrega = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btExcluirProduto = new System.Windows.Forms.Button();
            this.btIncluirProduto = new System.Windows.Forms.Button();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComprador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoraVenda = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::HelpSerralheiro.Properties.Resources.form;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnOculto);
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.txtValorTotal);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtFrete);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtDescontos);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtValorItens);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtObservacoes);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtHoraEntrega);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDataEntrega);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btExcluirProduto);
            this.panel1.Controls.Add(this.btIncluirProduto);
            this.panel1.Controls.Add(this.dgvVenda);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtVendedor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtComprador);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtHoraVenda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDataVenda);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-31, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 583);
            this.panel1.TabIndex = 0;
            // 
            // btnOculto
            // 
            this.btnOculto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOculto.Location = new System.Drawing.Point(795, 38);
            this.btnOculto.Name = "btnOculto";
            this.btnOculto.Size = new System.Drawing.Size(37, 23);
            this.btnOculto.TabIndex = 93;
            this.btnOculto.UseVisualStyleBackColor = true;
            this.btnOculto.Visible = false;
            this.btnOculto.Click += new System.EventHandler(this.btnOculto_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(686, 511);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(111, 32);
            this.btnFinalizar.TabIndex = 92;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(87, 511);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 32);
            this.btnSair.TabIndex = 91;
            this.btnSair.Text = "Cancelar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(643, 445);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(154, 31);
            this.txtValorTotal.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(644, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 25);
            this.label12.TabIndex = 89;
            this.label12.Text = "Valor Total";
            // 
            // txtFrete
            // 
            this.txtFrete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrete.Location = new System.Drawing.Point(516, 453);
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(100, 21);
            this.txtFrete.TabIndex = 88;
            this.txtFrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrete_KeyPress);
            this.txtFrete.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFrete_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(422, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "Valor do Frete";
            // 
            // txtDescontos
            // 
            this.txtDescontos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontos.Location = new System.Drawing.Point(516, 427);
            this.txtDescontos.Name = "txtDescontos";
            this.txtDescontos.Size = new System.Drawing.Size(100, 21);
            this.txtDescontos.TabIndex = 86;
            this.txtDescontos.Text = "0";
            this.txtDescontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontos_KeyPress);
            this.txtDescontos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescontos_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(450, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "Desconto";
            // 
            // txtValorItens
            // 
            this.txtValorItens.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorItens.Location = new System.Drawing.Point(516, 401);
            this.txtValorItens.Name = "txtValorItens";
            this.txtValorItens.ReadOnly = true;
            this.txtValorItens.Size = new System.Drawing.Size(100, 21);
            this.txtValorItens.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(416, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Valor dos Itens";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(87, 372);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(309, 101);
            this.txtObservacoes.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Observações";
            // 
            // txtHoraEntrega
            // 
            this.txtHoraEntrega.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHoraEntrega.Location = new System.Drawing.Point(714, 39);
            this.txtHoraEntrega.Name = "txtHoraEntrega";
            this.txtHoraEntrega.Size = new System.Drawing.Size(75, 21);
            this.txtHoraEntrega.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(678, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Hora";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEntrega.Location = new System.Drawing.Point(576, 39);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(96, 21);
            this.txtDataEntrega.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Data de Entrega";
            // 
            // btExcluirProduto
            // 
            this.btExcluirProduto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirProduto.Location = new System.Drawing.Point(529, 313);
            this.btExcluirProduto.Name = "btExcluirProduto";
            this.btExcluirProduto.Size = new System.Drawing.Size(130, 43);
            this.btExcluirProduto.TabIndex = 76;
            this.btExcluirProduto.Text = "Excluir Produto";
            this.btExcluirProduto.UseVisualStyleBackColor = true;
            this.btExcluirProduto.Click += new System.EventHandler(this.btExcluirProduto_Click);
            // 
            // btIncluirProduto
            // 
            this.btIncluirProduto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluirProduto.Location = new System.Drawing.Point(677, 313);
            this.btIncluirProduto.Name = "btIncluirProduto";
            this.btIncluirProduto.Size = new System.Drawing.Size(130, 43);
            this.btIncluirProduto.TabIndex = 75;
            this.btIncluirProduto.Text = "Incluir Produto";
            this.btIncluirProduto.UseVisualStyleBackColor = true;
            this.btIncluirProduto.Click += new System.EventHandler(this.btIncluirProduto_Click);
            // 
            // dgvVenda
            // 
            this.dgvVenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(87, 145);
            this.dgvVenda.MultiSelect = false;
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenda.Size = new System.Drawing.Size(720, 162);
            this.dgvVenda.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Itens / Produtos";
            // 
            // txtVendedor
            // 
            this.txtVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtVendedor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.FormattingEnabled = true;
            this.txtVendedor.Location = new System.Drawing.Point(553, 95);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(254, 21);
            this.txtVendedor.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Atendente / Vendedor";
            // 
            // txtComprador
            // 
            this.txtComprador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtComprador.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComprador.FormattingEnabled = true;
            this.txtComprador.Location = new System.Drawing.Point(156, 95);
            this.txtComprador.Name = "txtComprador";
            this.txtComprador.Size = new System.Drawing.Size(240, 21);
            this.txtComprador.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Comprador";
            // 
            // txtHoraVenda
            // 
            this.txtHoraVenda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraVenda.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHoraVenda.Location = new System.Drawing.Point(322, 40);
            this.txtHoraVenda.Name = "txtHoraVenda";
            this.txtHoraVenda.Size = new System.Drawing.Size(74, 21);
            this.txtHoraVenda.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Hora";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataVenda.Location = new System.Drawing.Point(162, 38);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(89, 21);
            this.txtDataVenda.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Data da Venda";
            // 
            // AlterarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HelpSerralheiro.Properties.Resources.blur_wallpaper_HD_Download1;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlterarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commanager";
            this.Load += new System.EventHandler(this.AlterarVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFrete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescontos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValorItens;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtDataEntrega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btExcluirProduto;
        private System.Windows.Forms.Button btIncluirProduto;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtComprador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtHoraVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDataVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOculto;
        private System.Windows.Forms.DateTimePicker txtHoraEntrega;
    }
}