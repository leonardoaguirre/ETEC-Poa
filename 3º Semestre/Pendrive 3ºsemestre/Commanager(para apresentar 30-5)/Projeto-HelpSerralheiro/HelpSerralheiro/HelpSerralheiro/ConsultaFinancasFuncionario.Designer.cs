namespace HelpSerralheiro
{
    partial class ConsultaFinancasFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFinancasFuncionario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterarRegistro = new System.Windows.Forms.Button();
            this.btnExcluirRegistro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::HelpSerralheiro.Properties.Resources.form;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Controls.Add(this.btnAlterarRegistro);
            this.panel1.Controls.Add(this.btnExcluirRegistro);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDespesa);
            this.panel1.Controls.Add(this.dgvDespesas);
            this.panel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-21, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 584);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 187;
            this.label1.Text = "Pesquisa por nome do funcionário";
            // 
            // txtDespesa
            // 
            this.txtDespesa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespesa.Location = new System.Drawing.Point(78, 52);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(239, 21);
            this.txtDespesa.TabIndex = 188;
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Location = new System.Drawing.Point(78, 84);
            this.dgvDespesas.MultiSelect = false;
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.ReadOnly = true;
            this.dgvDespesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespesas.Size = new System.Drawing.Size(726, 399);
            this.dgvDespesas.TabIndex = 182;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Image = global::HelpSerralheiro.Properties.Resources.adicionar;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(368, 511);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(149, 32);
            this.btnInserir.TabIndex = 194;
            this.btnInserir.Text = "Inserir Registro";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterarRegistro
            // 
            this.btnAlterarRegistro.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnAlterarRegistro.Image = global::HelpSerralheiro.Properties.Resources.alterar;
            this.btnAlterarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarRegistro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterarRegistro.Location = new System.Drawing.Point(523, 511);
            this.btnAlterarRegistro.Name = "btnAlterarRegistro";
            this.btnAlterarRegistro.Size = new System.Drawing.Size(140, 32);
            this.btnAlterarRegistro.TabIndex = 193;
            this.btnAlterarRegistro.Text = "Alterar Registro\r\n";
            this.btnAlterarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarRegistro.UseVisualStyleBackColor = true;
            this.btnAlterarRegistro.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluirRegistro
            // 
            this.btnExcluirRegistro.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnExcluirRegistro.Image = global::HelpSerralheiro.Properties.Resources.trash;
            this.btnExcluirRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirRegistro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirRegistro.Location = new System.Drawing.Point(669, 511);
            this.btnExcluirRegistro.Name = "btnExcluirRegistro";
            this.btnExcluirRegistro.Size = new System.Drawing.Size(134, 32);
            this.btnExcluirRegistro.TabIndex = 192;
            this.btnExcluirRegistro.Text = "Excluir Registro";
            this.btnExcluirRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirRegistro.UseVisualStyleBackColor = true;
            this.btnExcluirRegistro.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnVoltar.Image = global::HelpSerralheiro.Properties.Resources.voltar;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVoltar.Location = new System.Drawing.Point(65, 511);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(89, 32);
            this.btnVoltar.TabIndex = 191;
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
            this.btnPesquisar.Location = new System.Drawing.Point(323, 52);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 21);
            this.btnPesquisar.TabIndex = 190;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // ConsultaFinancasFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HelpSerralheiro.Properties.Resources.blur_wallpaper_HD_Download1;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaFinancasFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commanager";
            this.Load += new System.EventHandler(this.ConsultaFinancasFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterarRegistro;
        private System.Windows.Forms.Button btnExcluirRegistro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}