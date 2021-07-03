namespace Aula_3_8
{
    partial class FrmDecisao
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
            this.btnCores = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCores
            // 
            this.btnCores.Location = new System.Drawing.Point(353, 12);
            this.btnCores.Name = "btnCores";
            this.btnCores.Size = new System.Drawing.Size(75, 23);
            this.btnCores.TabIndex = 0;
            this.btnCores.Text = "Vermelho";
            this.btnCores.UseVisualStyleBackColor = true;
            this.btnCores.Click += new System.EventHandler(this.btnCores_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDecisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 358);
            this.Controls.Add(this.btnCores);
            this.Name = "FrmDecisao";
            this.Text = "FrmDecisao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCores;
        private System.Windows.Forms.Timer timer1;
    }
}