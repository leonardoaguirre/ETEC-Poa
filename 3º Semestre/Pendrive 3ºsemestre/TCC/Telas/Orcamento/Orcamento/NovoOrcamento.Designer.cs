﻿namespace Orcamento
{
    partial class NovoOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoOrcamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalOrcamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFreteOrcamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescontoOrcamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorItensOrcamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtClienteOrcamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVendedorOrcamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 559);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnGerar);
            this.panel2.Controls.Add(this.txtTotalOrcamento);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtFreteOrcamento);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDescontoOrcamento);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtValorItensOrcamento);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnIncluir);
            this.panel2.Controls.Add(this.txtClienteOrcamento);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtVendedorOrcamento);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 559);
            this.panel2.TabIndex = 0;
            // 
            // txtTotalOrcamento
            // 
            this.txtTotalOrcamento.Enabled = false;
            this.txtTotalOrcamento.Location = new System.Drawing.Point(590, 476);
            this.txtTotalOrcamento.Multiline = true;
            this.txtTotalOrcamento.Name = "txtTotalOrcamento";
            this.txtTotalOrcamento.Size = new System.Drawing.Size(118, 31);
            this.txtTotalOrcamento.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "Valor Total";
            // 
            // txtFreteOrcamento
            // 
            this.txtFreteOrcamento.Location = new System.Drawing.Point(590, 436);
            this.txtFreteOrcamento.Name = "txtFreteOrcamento";
            this.txtFreteOrcamento.Size = new System.Drawing.Size(80, 20);
            this.txtFreteOrcamento.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor do Frete";
            // 
            // txtDescontoOrcamento
            // 
            this.txtDescontoOrcamento.Location = new System.Drawing.Point(590, 406);
            this.txtDescontoOrcamento.Name = "txtDescontoOrcamento";
            this.txtDescontoOrcamento.Size = new System.Drawing.Size(80, 20);
            this.txtDescontoOrcamento.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Desconto";
            // 
            // txtValorItensOrcamento
            // 
            this.txtValorItensOrcamento.Enabled = false;
            this.txtValorItensOrcamento.Location = new System.Drawing.Point(590, 374);
            this.txtValorItensOrcamento.Name = "txtValorItensOrcamento";
            this.txtValorItensOrcamento.Size = new System.Drawing.Size(80, 20);
            this.txtValorItensOrcamento.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor dos itens";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(344, 364);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 39);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir Produto";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(222, 364);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 39);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar Produto";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(101, 364);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(101, 39);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "Incluir Produto";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // txtClienteOrcamento
            // 
            this.txtClienteOrcamento.FormattingEnabled = true;
            this.txtClienteOrcamento.Location = new System.Drawing.Point(194, 63);
            this.txtClienteOrcamento.Name = "txtClienteOrcamento";
            this.txtClienteOrcamento.Size = new System.Drawing.Size(224, 21);
            this.txtClienteOrcamento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 232);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(101, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            // 
            // txtVendedorOrcamento
            // 
            this.txtVendedorOrcamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtVendedorOrcamento.FormattingEnabled = true;
            this.txtVendedorOrcamento.Items.AddRange(new object[] {
            "JOÃO VITOR",
            "JONAS FERREIRA",
            "LEONARDO AGUIRRE",
            "LUCAS NERES",
            "CAIO EDUARDO"});
            this.txtVendedorOrcamento.Location = new System.Drawing.Point(451, 64);
            this.txtVendedorOrcamento.Name = "txtVendedorOrcamento";
            this.txtVendedorOrcamento.Size = new System.Drawing.Size(257, 21);
            this.txtVendedorOrcamento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Vendedor / Atendente";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(101, 459);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(101, 48);
            this.btnGerar.TabIndex = 18;
            this.btnGerar.Text = "Gerar Orçamento";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // NovoOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 559);
            this.Controls.Add(this.panel1);
            this.Name = "NovoOrcamento";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox txtVendedorOrcamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalOrcamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFreteOrcamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescontoOrcamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorItensOrcamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ComboBox txtClienteOrcamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGerar;
    }
}

