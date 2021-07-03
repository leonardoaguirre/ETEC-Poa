namespace Telas
{
    partial class CadastroVenda
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btSair = new System.Windows.Forms.Button();
            this.btFinalizarVenda = new System.Windows.Forms.Button();
            this.btAlterarProduto = new System.Windows.Forms.Button();
            this.btExcluirProduto = new System.Windows.Forms.Button();
            this.btIncluirProduto = new System.Windows.Forms.Button();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComprador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Venda = new System.Windows.Forms.Label();
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
            this.panel1.BackgroundImage = global::Telas.Properties.Resources.form;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.btFinalizarVenda);
            this.panel1.Controls.Add(this.btAlterarProduto);
            this.panel1.Controls.Add(this.btExcluirProduto);
            this.panel1.Controls.Add(this.btIncluirProduto);
            this.panel1.Controls.Add(this.dgvVenda);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtVendedor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtComprador);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Venda);
            this.panel1.Controls.Add(this.txtHoraVenda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDataVenda);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 565);
            this.panel1.TabIndex = 0;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(610, 393);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(154, 38);
            this.txtValorTotal.TabIndex = 33;
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotal_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(631, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Valor Total";
            // 
            // txtFrete
            // 
            this.txtFrete.Location = new System.Drawing.Point(495, 416);
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(100, 20);
            this.txtFrete.TabIndex = 31;
            this.txtFrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrete_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(420, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Valor do Frete";
            // 
            // txtDescontos
            // 
            this.txtDescontos.Location = new System.Drawing.Point(495, 390);
            this.txtDescontos.Name = "txtDescontos";
            this.txtDescontos.Size = new System.Drawing.Size(100, 20);
            this.txtDescontos.TabIndex = 29;
            this.txtDescontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontos_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Desconto";
            // 
            // txtValorItens
            // 
            this.txtValorItens.Enabled = false;
            this.txtValorItens.Location = new System.Drawing.Point(495, 364);
            this.txtValorItens.Name = "txtValorItens";
            this.txtValorItens.Size = new System.Drawing.Size(100, 20);
            this.txtValorItens.TabIndex = 27;
            this.txtValorItens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorItens_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Valor dos Itens";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(61, 364);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(270, 101);
            this.txtObservacoes.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Observações";
            // 
            // txtHoraEntrega
            // 
            this.txtHoraEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHoraEntrega.Location = new System.Drawing.Point(265, 316);
            this.txtHoraEntrega.Name = "txtHoraEntrega";
            this.txtHoraEntrega.Size = new System.Drawing.Size(66, 20);
            this.txtHoraEntrega.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Hora";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEntrega.Location = new System.Drawing.Point(140, 316);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(86, 20);
            this.txtDataEntrega.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Data de Entrega";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(554, 468);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(95, 59);
            this.btSair.TabIndex = 19;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btFinalizarVenda
            // 
            this.btFinalizarVenda.Location = new System.Drawing.Point(669, 468);
            this.btFinalizarVenda.Name = "btFinalizarVenda";
            this.btFinalizarVenda.Size = new System.Drawing.Size(95, 59);
            this.btFinalizarVenda.TabIndex = 18;
            this.btFinalizarVenda.Text = "Finalizar Venda";
            this.btFinalizarVenda.UseVisualStyleBackColor = true;
            this.btFinalizarVenda.Click += new System.EventHandler(this.btFinalizarVenda_Click);
            // 
            // btAlterarProduto
            // 
            this.btAlterarProduto.Location = new System.Drawing.Point(678, 305);
            this.btAlterarProduto.Name = "btAlterarProduto";
            this.btAlterarProduto.Size = new System.Drawing.Size(95, 43);
            this.btAlterarProduto.TabIndex = 17;
            this.btAlterarProduto.Text = "Alterar Produto";
            this.btAlterarProduto.UseVisualStyleBackColor = true;
            // 
            // btExcluirProduto
            // 
            this.btExcluirProduto.Location = new System.Drawing.Point(577, 305);
            this.btExcluirProduto.Name = "btExcluirProduto";
            this.btExcluirProduto.Size = new System.Drawing.Size(95, 43);
            this.btExcluirProduto.TabIndex = 16;
            this.btExcluirProduto.Text = "Excluir Produto";
            this.btExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // btIncluirProduto
            // 
            this.btIncluirProduto.Location = new System.Drawing.Point(476, 305);
            this.btIncluirProduto.Name = "btIncluirProduto";
            this.btIncluirProduto.Size = new System.Drawing.Size(95, 43);
            this.btIncluirProduto.TabIndex = 15;
            this.btIncluirProduto.Text = "Incluir Produto";
            this.btIncluirProduto.UseVisualStyleBackColor = true;
            // 
            // dgvVenda
            // 
            this.dgvVenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(53, 137);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.Size = new System.Drawing.Size(720, 162);
            this.dgvVenda.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Itens / Produtos";
            // 
            // txtVendedor
            // 
            this.txtVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtVendedor.FormattingEnabled = true;
            this.txtVendedor.Location = new System.Drawing.Point(495, 87);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(254, 21);
            this.txtVendedor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Atendente / Vendedor";
            // 
            // txtComprador
            // 
            this.txtComprador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtComprador.FormattingEnabled = true;
            this.txtComprador.Location = new System.Drawing.Point(115, 87);
            this.txtComprador.Name = "txtComprador";
            this.txtComprador.Size = new System.Drawing.Size(254, 21);
            this.txtComprador.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Comprador";
            // 
            // Venda
            // 
            this.Venda.AutoSize = true;
            this.Venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Venda.Location = new System.Drawing.Point(386, 35);
            this.Venda.Name = "Venda";
            this.Venda.Size = new System.Drawing.Size(75, 25);
            this.Venda.TabIndex = 8;
            this.Venda.Text = "Venda";
            // 
            // txtHoraVenda
            // 
            this.txtHoraVenda.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHoraVenda.Location = new System.Drawing.Point(289, 40);
            this.txtHoraVenda.Name = "txtHoraVenda";
            this.txtHoraVenda.Size = new System.Drawing.Size(66, 20);
            this.txtHoraVenda.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataVenda.Location = new System.Drawing.Point(162, 40);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(86, 20);
            this.txtDataVenda.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data da Venda";
            // 
            // CadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Telas.Properties.Resources.blur_wallpaper_HD_Download1;
            this.ClientSize = new System.Drawing.Size(832, 559);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroVenda";
            this.Text = "CadastroVenda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker txtHoraVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDataVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Venda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtComprador;
        private System.Windows.Forms.ComboBox txtVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btFinalizarVenda;
        private System.Windows.Forms.Button btAlterarProduto;
        private System.Windows.Forms.Button btExcluirProduto;
        private System.Windows.Forms.Button btIncluirProduto;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtHoraEntrega;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtDataEntrega;
        private System.Windows.Forms.Label label6;
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
    }
}