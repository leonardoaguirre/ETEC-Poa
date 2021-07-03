namespace Aula_17_08
{
    partial class Form2
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
            this.btnExibirValores = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDivisão = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicação = new System.Windows.Forms.RadioButton();
            this.rdbSubtrair = new System.Windows.Forms.RadioButton();
            this.rdbSomar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExibirValores
            // 
            this.btnExibirValores.Location = new System.Drawing.Point(306, 297);
            this.btnExibirValores.Name = "btnExibirValores";
            this.btnExibirValores.Size = new System.Drawing.Size(96, 23);
            this.btnExibirValores.TabIndex = 0;
            this.btnExibirValores.Text = "Exibir Valores";
            this.btnExibirValores.UseVisualStyleBackColor = true;
            this.btnExibirValores.Click += new System.EventHandler(this.btnExibirValores_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDivisão);
            this.groupBox1.Controls.Add(this.rdbMultiplicação);
            this.groupBox1.Controls.Add(this.rdbSubtrair);
            this.groupBox1.Controls.Add(this.rdbSomar);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // rdbDivisão
            // 
            this.rdbDivisão.AutoSize = true;
            this.rdbDivisão.Location = new System.Drawing.Point(97, 51);
            this.rdbDivisão.Name = "rdbDivisão";
            this.rdbDivisão.Size = new System.Drawing.Size(54, 17);
            this.rdbDivisão.TabIndex = 3;
            this.rdbDivisão.TabStop = true;
            this.rdbDivisão.Text = "Dividir";
            this.rdbDivisão.UseVisualStyleBackColor = true;
            this.rdbDivisão.CheckedChanged += new System.EventHandler(this.rdbDivisão_CheckedChanged);
            // 
            // rdbMultiplicação
            // 
            this.rdbMultiplicação.AutoSize = true;
            this.rdbMultiplicação.Location = new System.Drawing.Point(97, 19);
            this.rdbMultiplicação.Name = "rdbMultiplicação";
            this.rdbMultiplicação.Size = new System.Drawing.Size(72, 17);
            this.rdbMultiplicação.TabIndex = 2;
            this.rdbMultiplicação.TabStop = true;
            this.rdbMultiplicação.Text = "Multiplicar";
            this.rdbMultiplicação.UseVisualStyleBackColor = true;
            this.rdbMultiplicação.CheckedChanged += new System.EventHandler(this.rdbMultiplicação_CheckedChanged);
            // 
            // rdbSubtrair
            // 
            this.rdbSubtrair.AutoSize = true;
            this.rdbSubtrair.Location = new System.Drawing.Point(6, 51);
            this.rdbSubtrair.Name = "rdbSubtrair";
            this.rdbSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rdbSubtrair.TabIndex = 1;
            this.rdbSubtrair.TabStop = true;
            this.rdbSubtrair.Text = "Subtrair";
            this.rdbSubtrair.UseVisualStyleBackColor = true;
            this.rdbSubtrair.CheckedChanged += new System.EventHandler(this.rdbSubtrair_CheckedChanged);
            // 
            // rdbSomar
            // 
            this.rdbSomar.AutoSize = true;
            this.rdbSomar.Location = new System.Drawing.Point(6, 19);
            this.rdbSomar.Name = "rdbSomar";
            this.rdbSomar.Size = new System.Drawing.Size(55, 17);
            this.rdbSomar.TabIndex = 0;
            this.rdbSomar.TabStop = true;
            this.rdbSomar.Text = "Somar";
            this.rdbSomar.UseVisualStyleBackColor = true;
            this.rdbSomar.CheckedChanged += new System.EventHandler(this.rdbSomar_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 332);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExibirValores);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExibirValores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDivisão;
        private System.Windows.Forms.RadioButton rdbMultiplicação;
        private System.Windows.Forms.RadioButton rdbSubtrair;
        private System.Windows.Forms.RadioButton rdbSomar;
    }
}