namespace HelpSerralheiro
{
    partial class ConsultaProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProdutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAlterarRegistro = new System.Windows.Forms.Button();
            this.btnExcluirRegistro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HelpSerralheiro.Properties.Resources.blur_wallpaper_HD_Download1;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 573);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::HelpSerralheiro.Properties.Resources.form;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnAlterarRegistro);
            this.panel2.Controls.Add(this.btnExcluirRegistro);
            this.panel2.Controls.Add(this.btnVoltar);
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Controls.Add(this.dgvProdutos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtPesquisaProduto);
            this.panel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(-40, -15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 609);
            this.panel2.TabIndex = 2;
            // 
            // btnAlterarRegistro
            // 
            this.btnAlterarRegistro.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnAlterarRegistro.Image = global::HelpSerralheiro.Properties.Resources.alterar;
            this.btnAlterarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarRegistro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterarRegistro.Location = new System.Drawing.Point(544, 526);
            this.btnAlterarRegistro.Name = "btnAlterarRegistro";
            this.btnAlterarRegistro.Size = new System.Drawing.Size(140, 32);
            this.btnAlterarRegistro.TabIndex = 198;
            this.btnAlterarRegistro.Text = "Alterar Registro\r\n";
            this.btnAlterarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarRegistro.UseVisualStyleBackColor = true;
            this.btnAlterarRegistro.Click += new System.EventHandler(this.btnAlterarRegistro_Click);
            // 
            // btnExcluirRegistro
            // 
            this.btnExcluirRegistro.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnExcluirRegistro.Image = global::HelpSerralheiro.Properties.Resources.trash;
            this.btnExcluirRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirRegistro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirRegistro.Location = new System.Drawing.Point(690, 526);
            this.btnExcluirRegistro.Name = "btnExcluirRegistro";
            this.btnExcluirRegistro.Size = new System.Drawing.Size(134, 32);
            this.btnExcluirRegistro.TabIndex = 197;
            this.btnExcluirRegistro.Text = "Excluir Registro";
            this.btnExcluirRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirRegistro.UseVisualStyleBackColor = true;
            this.btnExcluirRegistro.Click += new System.EventHandler(this.btnExcluirRegistro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnVoltar.Image = global::HelpSerralheiro.Properties.Resources.voltar;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVoltar.Location = new System.Drawing.Point(110, 526);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(89, 32);
            this.btnVoltar.TabIndex = 196;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnPesquisar.Image = global::HelpSerralheiro.Properties.Resources.pesquisar;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisar.Location = new System.Drawing.Point(355, 67);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 21);
            this.btnPesquisar.TabIndex = 195;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(110, 105);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(714, 399);
            this.dgvProdutos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pesquisa por nome do produto:";
            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaProduto.Location = new System.Drawing.Point(110, 67);
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(239, 21);
            this.txtPesquisaProduto.TabIndex = 9;
            this.txtPesquisaProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaProduto_KeyPress);
            // 
            // ConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 573);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commanager";
            this.Load += new System.EventHandler(this.ConsultaProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaProduto;
        private System.Windows.Forms.Button btnAlterarRegistro;
        private System.Windows.Forms.Button btnExcluirRegistro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}