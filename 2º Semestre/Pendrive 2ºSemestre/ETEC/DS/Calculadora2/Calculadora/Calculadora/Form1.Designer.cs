namespace Calculadora
{
    partial class FrmCalculadora
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
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMultiplicação = new System.Windows.Forms.Button();
            this.btnDivisão = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSubtração = new System.Windows.Forms.Button();
            this.btnAdição = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.Color.DarkOrange;
            this.txtVisor.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(12, 12);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(374, 56);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Image = global::Calculadora.Properties.Resources.zero;
            this.btn0.Location = new System.Drawing.Point(107, 344);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(89, 83);
            this.btn0.TabIndex = 16;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnMultiplicação
            // 
            this.btnMultiplicação.AutoSize = true;
            this.btnMultiplicação.FlatAppearance.BorderSize = 0;
            this.btnMultiplicação.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicação.Image = global::Calculadora.Properties.Resources.multiplicaçao;
            this.btnMultiplicação.Location = new System.Drawing.Point(297, 255);
            this.btnMultiplicação.Name = "btnMultiplicação";
            this.btnMultiplicação.Size = new System.Drawing.Size(89, 83);
            this.btnMultiplicação.TabIndex = 15;
            this.btnMultiplicação.UseVisualStyleBackColor = true;
            this.btnMultiplicação.Click += new System.EventHandler(this.btnMultiplicação_Click);
            // 
            // btnDivisão
            // 
            this.btnDivisão.AutoSize = true;
            this.btnDivisão.FlatAppearance.BorderSize = 0;
            this.btnDivisão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivisão.Image = global::Calculadora.Properties.Resources.divisão;
            this.btnDivisão.Location = new System.Drawing.Point(297, 344);
            this.btnDivisão.Name = "btnDivisão";
            this.btnDivisão.Size = new System.Drawing.Size(89, 83);
            this.btnDivisão.TabIndex = 14;
            this.btnDivisão.UseVisualStyleBackColor = true;
            this.btnDivisão.Click += new System.EventHandler(this.btnDivisão_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = global::Calculadora.Properties.Resources.limpaTela;
            this.btnLimpar.Location = new System.Drawing.Point(12, 341);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(89, 83);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.AutoSize = true;
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Image = global::Calculadora.Properties.Resources.igualdade;
            this.btnIgual.Location = new System.Drawing.Point(202, 344);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(89, 83);
            this.btnIgual.TabIndex = 12;
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSubtração
            // 
            this.btnSubtração.AutoSize = true;
            this.btnSubtração.FlatAppearance.BorderSize = 0;
            this.btnSubtração.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtração.Image = global::Calculadora.Properties.Resources.subtração;
            this.btnSubtração.Location = new System.Drawing.Point(297, 166);
            this.btnSubtração.Name = "btnSubtração";
            this.btnSubtração.Size = new System.Drawing.Size(89, 83);
            this.btnSubtração.TabIndex = 11;
            this.btnSubtração.UseVisualStyleBackColor = true;
            this.btnSubtração.Click += new System.EventHandler(this.btnSubtração_Click);
            // 
            // btnAdição
            // 
            this.btnAdição.AutoSize = true;
            this.btnAdição.FlatAppearance.BorderSize = 0;
            this.btnAdição.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdição.Image = global::Calculadora.Properties.Resources.soma;
            this.btnAdição.Location = new System.Drawing.Point(297, 77);
            this.btnAdição.Name = "btnAdição";
            this.btnAdição.Size = new System.Drawing.Size(89, 83);
            this.btnAdição.TabIndex = 10;
            this.btnAdição.UseVisualStyleBackColor = true;
            this.btnAdição.Click += new System.EventHandler(this.btnAdição_Click);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Image = global::Calculadora.Properties.Resources._9;
            this.btn9.Location = new System.Drawing.Point(202, 255);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(89, 83);
            this.btn9.TabIndex = 9;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Image = global::Calculadora.Properties.Resources._8;
            this.btn8.Location = new System.Drawing.Point(107, 252);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(89, 83);
            this.btn8.TabIndex = 8;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Image = global::Calculadora.Properties.Resources._7;
            this.btn7.Location = new System.Drawing.Point(12, 252);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(89, 83);
            this.btn7.TabIndex = 7;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Image = global::Calculadora.Properties.Resources._6;
            this.btn6.Location = new System.Drawing.Point(202, 166);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(89, 83);
            this.btn6.TabIndex = 6;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Image = global::Calculadora.Properties.Resources._5;
            this.btn5.Location = new System.Drawing.Point(107, 163);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(89, 83);
            this.btn5.TabIndex = 5;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Image = global::Calculadora.Properties.Resources._4;
            this.btn4.Location = new System.Drawing.Point(12, 163);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(89, 83);
            this.btn4.TabIndex = 4;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Image = global::Calculadora.Properties.Resources._3;
            this.btn3.Location = new System.Drawing.Point(202, 77);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(89, 83);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Image = global::Calculadora.Properties.Resources._2;
            this.btn2.Location = new System.Drawing.Point(107, 77);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(89, 83);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Image = global::Calculadora.Properties.Resources._1;
            this.btn1.Location = new System.Drawing.Point(12, 77);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(89, 83);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 434);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMultiplicação);
            this.Controls.Add(this.btnDivisão);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSubtração);
            this.Controls.Add(this.btnAdição);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtVisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EtecCALC";
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnAdição;
        private System.Windows.Forms.Button btnSubtração;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDivisão;
        private System.Windows.Forms.Button btnMultiplicação;
        private System.Windows.Forms.Button btn0;
    }
}

