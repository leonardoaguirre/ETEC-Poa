namespace ProjetoRelatorio
{
    partial class ConsultaAgenda
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
            this.btGerar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btPesquisar2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btInserir = new System.Windows.Forms.Button();
            this.btnAlterarRegistro = new System.Windows.Forms.Button();
            this.btnExcluirRegistro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvAgendamento = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProjetoRelatorio.Properties.Resources.blur_wallpaper_HD_Download1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btGerar);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.btPesquisar2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btInserir);
            this.panel1.Controls.Add(this.btnAlterarRegistro);
            this.panel1.Controls.Add(this.btnExcluirRegistro);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.dgvAgendamento);
            this.panel1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.panel1.Location = new System.Drawing.Point(-32, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 573);
            this.panel1.TabIndex = 1;
            // 
            // btGerar
            // 
            this.btGerar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btGerar.Image = global::ProjetoRelatorio.Properties.Resources.relatorio;
            this.btGerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btGerar.Location = new System.Drawing.Point(224, 505);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(140, 32);
            this.btGerar.TabIndex = 186;
            this.btGerar.Text = "Gerar Relatorio";
            this.btGerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(109, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(252, 21);
            this.txtNome.TabIndex = 185;
            // 
            // btPesquisar2
            // 
            this.btPesquisar2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btPesquisar2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btPesquisar2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btPesquisar2.Location = new System.Drawing.Point(367, 42);
            this.btPesquisar2.Name = "btPesquisar2";
            this.btPesquisar2.Size = new System.Drawing.Size(71, 21);
            this.btPesquisar2.TabIndex = 184;
            this.btPesquisar2.Text = "Pesquisar";
            this.btPesquisar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar2.UseVisualStyleBackColor = true;
            this.btPesquisar2.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(106, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 183;
            this.label4.Text = "Procura por nome";
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btInserir.Image = global::ProjetoRelatorio.Properties.Resources.adicionar;
            this.btInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInserir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btInserir.Location = new System.Drawing.Point(381, 505);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(140, 32);
            this.btInserir.TabIndex = 182;
            this.btInserir.Text = "Inserir Registro\r\n";
            this.btInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btnAlterarRegistro
            // 
            this.btnAlterarRegistro.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnAlterarRegistro.Image = global::ProjetoRelatorio.Properties.Resources.alterar;
            this.btnAlterarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarRegistro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterarRegistro.Location = new System.Drawing.Point(527, 505);
            this.btnAlterarRegistro.Name = "btnAlterarRegistro";
            this.btnAlterarRegistro.Size = new System.Drawing.Size(140, 32);
            this.btnAlterarRegistro.TabIndex = 177;
            this.btnAlterarRegistro.Text = "Alterar Registro\r\n";
            this.btnAlterarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarRegistro.UseVisualStyleBackColor = true;
            this.btnAlterarRegistro.Click += new System.EventHandler(this.btnAlterarRegistro_Click);
            // 
            // btnExcluirRegistro
            // 
            this.btnExcluirRegistro.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnExcluirRegistro.Image = global::ProjetoRelatorio.Properties.Resources.trash;
            this.btnExcluirRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirRegistro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirRegistro.Location = new System.Drawing.Point(673, 505);
            this.btnExcluirRegistro.Name = "btnExcluirRegistro";
            this.btnExcluirRegistro.Size = new System.Drawing.Size(134, 32);
            this.btnExcluirRegistro.TabIndex = 176;
            this.btnExcluirRegistro.Text = "Excluir Registro";
            this.btnExcluirRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirRegistro.UseVisualStyleBackColor = true;
            this.btnExcluirRegistro.Click += new System.EventHandler(this.btnExcluirRegistro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnVoltar.Image = global::ProjetoRelatorio.Properties.Resources.fechar;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVoltar.Location = new System.Drawing.Point(93, 505);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(102, 32);
            this.btnVoltar.TabIndex = 175;
            this.btnVoltar.Text = "Fechar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvAgendamento
            // 
            this.dgvAgendamento.AllowUserToAddRows = false;
            this.dgvAgendamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamento.Location = new System.Drawing.Point(93, 82);
            this.dgvAgendamento.MultiSelect = false;
            this.dgvAgendamento.Name = "dgvAgendamento";
            this.dgvAgendamento.ReadOnly = true;
            this.dgvAgendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgendamento.Size = new System.Drawing.Size(714, 399);
            this.dgvAgendamento.TabIndex = 171;
            // 
            // ConsultaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConsultaAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.ConsultaAgenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAlterarRegistro;
        private System.Windows.Forms.Button btnExcluirRegistro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvAgendamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btPesquisar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btGerar;
    }
}

