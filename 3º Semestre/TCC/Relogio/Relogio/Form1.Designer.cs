namespace Relogio
{
    partial class Form1
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
            this.txtRelogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRelogio
            // 
            this.txtRelogio.AutoSize = true;
            this.txtRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelogio.Location = new System.Drawing.Point(111, 114);
            this.txtRelogio.Name = "txtRelogio";
            this.txtRelogio.Size = new System.Drawing.Size(191, 63);
            this.txtRelogio.TabIndex = 0;
            this.txtRelogio.Text = "relogio";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtData
            // 
            this.txtData.AutoSize = true;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(111, 186);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(132, 63);
            this.txtData.TabIndex = 1;
            this.txtData.Text = "data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 377);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtRelogio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtRelogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtData;
    }
}

