namespace ProjetoRelatorio
{
    partial class GerarRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new ProjetoRelatorio.DataSet1();
            this.uspConsultaAgendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspConsultaAgendaTableAdapter = new ProjetoRelatorio.DataSet1TableAdapters.uspConsultaAgendaTableAdapter();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btPesquisar2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspConsultaAgendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSetAgenda";
            reportDataSource3.Value = this.uspConsultaAgendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoRelatorio.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(832, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspConsultaAgendaBindingSource
            // 
            this.uspConsultaAgendaBindingSource.DataMember = "uspConsultaAgenda";
            this.uspConsultaAgendaBindingSource.DataSource = this.DataSet1;
            // 
            // uspConsultaAgendaTableAdapter
            // 
            this.uspConsultaAgendaTableAdapter.ClearBeforeFill = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnVoltar.Image = global::ProjetoRelatorio.Properties.Resources.fechar;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVoltar.Location = new System.Drawing.Point(12, 517);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(102, 32);
            this.btnVoltar.TabIndex = 176;
            this.btnVoltar.Text = "Fechar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(252, 20);
            this.txtNome.TabIndex = 188;
            // 
            // btPesquisar2
            // 
            this.btPesquisar2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btPesquisar2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btPesquisar2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btPesquisar2.Location = new System.Drawing.Point(394, 10);
            this.btPesquisar2.Name = "btPesquisar2";
            this.btPesquisar2.Size = new System.Drawing.Size(71, 21);
            this.btPesquisar2.TabIndex = 187;
            this.btPesquisar2.Text = "Pesquisar";
            this.btPesquisar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar2.UseVisualStyleBackColor = true;
            this.btPesquisar2.Click += new System.EventHandler(this.GerarRelatorio_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(20, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 186;
            this.label4.Text = "Procura por nome";
            // 
            // GerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoRelatorio.Properties.Resources.blur_wallpaper_HD_Download1;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btPesquisar2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GerarRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerarRelatorio";
            this.Load += new System.EventHandler(this.GerarRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspConsultaAgendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspConsultaAgendaBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.uspConsultaAgendaTableAdapter uspConsultaAgendaTableAdapter;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btPesquisar2;
        private System.Windows.Forms.Label label4;
    }
}