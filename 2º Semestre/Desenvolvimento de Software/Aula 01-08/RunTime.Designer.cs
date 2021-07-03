namespace RunTime
{
    partial class rdbTarde
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
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnVermelho = new System.Windows.Forms.Button();
            this.groupPeriodo = new System.Windows.Forms.GroupBox();
            this.rdbNoite = new System.Windows.Forms.RadioButton();
            this.rdbTarde1 = new System.Windows.Forms.RadioButton();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.groupCursos = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.chbHabilita = new System.Windows.Forms.CheckBox();
            this.groupPeriodo.SuspendLayout();
            this.groupCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAzul
            // 
            this.btnAzul.Location = new System.Drawing.Point(12, 25);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(75, 23);
            this.btnAzul.TabIndex = 0;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnVermelho
            // 
            this.btnVermelho.Location = new System.Drawing.Point(12, 54);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(75, 23);
            this.btnVermelho.TabIndex = 1;
            this.btnVermelho.Text = "Vermelho";
            this.btnVermelho.UseVisualStyleBackColor = true;
            this.btnVermelho.Click += new System.EventHandler(this.btnVermelho_Click);
            // 
            // groupPeriodo
            // 
            this.groupPeriodo.Controls.Add(this.rdbNoite);
            this.groupPeriodo.Controls.Add(this.rdbTarde1);
            this.groupPeriodo.Controls.Add(this.rdbManha);
            this.groupPeriodo.Location = new System.Drawing.Point(247, 23);
            this.groupPeriodo.Name = "groupPeriodo";
            this.groupPeriodo.Size = new System.Drawing.Size(170, 92);
            this.groupPeriodo.TabIndex = 7;
            this.groupPeriodo.TabStop = false;
            this.groupPeriodo.Text = "Período";
            this.groupPeriodo.Enter += new System.EventHandler(this.groupPeriodo_Enter);
            // 
            // rdbNoite
            // 
            this.rdbNoite.AutoSize = true;
            this.rdbNoite.Location = new System.Drawing.Point(6, 65);
            this.rdbNoite.Name = "rdbNoite";
            this.rdbNoite.Size = new System.Drawing.Size(50, 17);
            this.rdbNoite.TabIndex = 7;
            this.rdbNoite.Text = "Noite";
            this.rdbNoite.UseVisualStyleBackColor = true;
            this.rdbNoite.CheckedChanged += new System.EventHandler(this.rdbNoite_CheckedChanged);
            // 
            // rdbTarde1
            // 
            this.rdbTarde1.AutoSize = true;
            this.rdbTarde1.Location = new System.Drawing.Point(6, 42);
            this.rdbTarde1.Name = "rdbTarde1";
            this.rdbTarde1.Size = new System.Drawing.Size(53, 17);
            this.rdbTarde1.TabIndex = 6;
            this.rdbTarde1.Text = "Tarde";
            this.rdbTarde1.UseVisualStyleBackColor = true;
            this.rdbTarde1.CheckedChanged += new System.EventHandler(this.rdbTarde1_CheckedChanged);
            // 
            // rdbManha
            // 
            this.rdbManha.AutoSize = true;
            this.rdbManha.Checked = true;
            this.rdbManha.Location = new System.Drawing.Point(6, 19);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(58, 17);
            this.rdbManha.TabIndex = 5;
            this.rdbManha.TabStop = true;
            this.rdbManha.Text = "Manhã";
            this.rdbManha.UseVisualStyleBackColor = true;
            this.rdbManha.CheckedChanged += new System.EventHandler(this.rdbManha_CheckedChanged);
            // 
            // groupCursos
            // 
            this.groupCursos.Controls.Add(this.radioButton1);
            this.groupCursos.Controls.Add(this.radioButton2);
            this.groupCursos.Location = new System.Drawing.Point(247, 121);
            this.groupCursos.Name = "groupCursos";
            this.groupCursos.Size = new System.Drawing.Size(172, 100);
            this.groupCursos.TabIndex = 8;
            this.groupCursos.TabStop = false;
            this.groupCursos.Text = "Opção de Curso";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Administração";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Informática";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // chbHabilita
            // 
            this.chbHabilita.AutoSize = true;
            this.chbHabilita.Checked = true;
            this.chbHabilita.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbHabilita.Location = new System.Drawing.Point(12, 121);
            this.chbHabilita.Name = "chbHabilita";
            this.chbHabilita.Size = new System.Drawing.Size(64, 17);
            this.chbHabilita.TabIndex = 9;
            this.chbHabilita.Text = "Habilitar";
            this.chbHabilita.UseVisualStyleBackColor = true;
            this.chbHabilita.CheckedChanged += new System.EventHandler(this.chbHabilita_CheckedChanged);
            // 
            // rdbTarde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 357);
            this.Controls.Add(this.chbHabilita);
            this.Controls.Add(this.groupCursos);
            this.Controls.Add(this.groupPeriodo);
            this.Controls.Add(this.btnVermelho);
            this.Controls.Add(this.btnAzul);
            this.Name = "rdbTarde";
            this.Text = "Tarde";
            this.Load += new System.EventHandler(this.rdbTarde_Load);
            this.groupPeriodo.ResumeLayout(false);
            this.groupPeriodo.PerformLayout();
            this.groupCursos.ResumeLayout(false);
            this.groupCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.GroupBox groupPeriodo;
        private System.Windows.Forms.RadioButton rdbNoite;
        private System.Windows.Forms.RadioButton rdbTarde1;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.GroupBox groupCursos;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox chbHabilita;
    }
}

