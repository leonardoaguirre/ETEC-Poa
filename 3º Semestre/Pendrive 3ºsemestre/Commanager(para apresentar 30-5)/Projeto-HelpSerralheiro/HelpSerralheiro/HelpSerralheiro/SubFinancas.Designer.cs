namespace HelpSerralheiro
{
    partial class SubFinancas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFinancas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDespesas = new System.Windows.Forms.Button();
            this.btDespesasFuncionarios = new System.Windows.Forms.Button();
            this.btFinancasVendas = new System.Windows.Forms.Button();
            this.btFinancasGeral = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::HelpSerralheiro.Properties.Resources.form;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lbldata);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btDespesas);
            this.panel1.Controls.Add(this.btDespesasFuncionarios);
            this.panel1.Controls.Add(this.btFinancasVendas);
            this.panel1.Controls.Add(this.btFinancasGeral);
            this.panel1.Location = new System.Drawing.Point(-37, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 586);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::HelpSerralheiro.Properties.Resources.commanager_icone;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(427, 515);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(68, 26);
            this.panel4.TabIndex = 54;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(69, 527);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(0, 14);
            this.lbldata.TabIndex = 53;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(70, 506);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 14);
            this.lblHora.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Finanças";
            // 
            // btDespesas
            // 
            this.btDespesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDespesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDespesas.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDespesas.Image = global::HelpSerralheiro.Properties.Resources.material_icons_3_0_1_attach_money_106_0_063f65_none;
            this.btDespesas.Location = new System.Drawing.Point(90, 216);
            this.btDespesas.Name = "btDespesas";
            this.btDespesas.Size = new System.Drawing.Size(165, 150);
            this.btDespesas.TabIndex = 51;
            this.btDespesas.Text = "Despesas";
            this.btDespesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDespesas.UseVisualStyleBackColor = true;
            this.btDespesas.Click += new System.EventHandler(this.btDespesas_Click);
            // 
            // btDespesasFuncionarios
            // 
            this.btDespesasFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDespesasFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDespesasFuncionarios.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDespesasFuncionarios.Image = global::HelpSerralheiro.Properties.Resources.font_awesome_4_7_0_user_o_106_0_063f65_none;
            this.btDespesasFuncionarios.Location = new System.Drawing.Point(283, 216);
            this.btDespesasFuncionarios.Name = "btDespesasFuncionarios";
            this.btDespesasFuncionarios.Size = new System.Drawing.Size(165, 150);
            this.btDespesasFuncionarios.TabIndex = 50;
            this.btDespesasFuncionarios.Text = "Funcionários";
            this.btDespesasFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDespesasFuncionarios.UseVisualStyleBackColor = true;
            this.btDespesasFuncionarios.Click += new System.EventHandler(this.btDespesasFuncionarios_Click);
            // 
            // btFinancasVendas
            // 
            this.btFinancasVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFinancasVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinancasVendas.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinancasVendas.Image = global::HelpSerralheiro.Properties.Resources.font_awesome_4_7_0_handshake_o_106_0_063f65_none;
            this.btFinancasVendas.Location = new System.Drawing.Point(476, 216);
            this.btFinancasVendas.Name = "btFinancasVendas";
            this.btFinancasVendas.Size = new System.Drawing.Size(165, 150);
            this.btFinancasVendas.TabIndex = 48;
            this.btFinancasVendas.Text = "Vendas";
            this.btFinancasVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btFinancasVendas.UseVisualStyleBackColor = true;
            this.btFinancasVendas.Click += new System.EventHandler(this.btFinancasVendas_Click);
            // 
            // btFinancasGeral
            // 
            this.btFinancasGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFinancasGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinancasGeral.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinancasGeral.Image = global::HelpSerralheiro.Properties.Resources.font_awesome_4_7_0_calculator_106_0_063f65_none;
            this.btFinancasGeral.Location = new System.Drawing.Point(669, 216);
            this.btFinancasGeral.Name = "btFinancasGeral";
            this.btFinancasGeral.Size = new System.Drawing.Size(165, 150);
            this.btFinancasGeral.TabIndex = 47;
            this.btFinancasGeral.Text = "Geral";
            this.btFinancasGeral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btFinancasGeral.UseVisualStyleBackColor = true;
            this.btFinancasGeral.Click += new System.EventHandler(this.btFinancasGeral_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Image = global::HelpSerralheiro.Properties.Resources.voltar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(731, 496);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(103, 45);
            this.btnFechar.TabIndex = 55;
            this.btnFechar.Text = "Voltar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // SubFinancas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HelpSerralheiro.Properties.Resources.blur_wallpaper_HD_Download1;
            this.ClientSize = new System.Drawing.Size(834, 562);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubFinancas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commanager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btFinancasVendas;
        private System.Windows.Forms.Button btFinancasGeral;
        private System.Windows.Forms.Button btDespesas;
        private System.Windows.Forms.Button btDespesasFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFechar;
    }
}