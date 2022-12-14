namespace ProjetoBdMuriloGimenez
{
    partial class FrmRelForn
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BdCadastroDataSet = new ProjetoBdMuriloGimenez.BdCadastroDataSet();
            this.tbFonecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFonecedorTableAdapter = new ProjetoBdMuriloGimenez.BdCadastroDataSetTableAdapters.tbFonecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BdCadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFonecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tbFonecedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoBdMuriloGimenez.ReportForn.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(660, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // BdCadastroDataSet
            // 
            this.BdCadastroDataSet.DataSetName = "BdCadastroDataSet";
            this.BdCadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFonecedorBindingSource
            // 
            this.tbFonecedorBindingSource.DataMember = "tbFonecedor";
            this.tbFonecedorBindingSource.DataSource = this.BdCadastroDataSet;
            // 
            // tbFonecedorTableAdapter
            // 
            this.tbFonecedorTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelForn";
            this.Text = "Relatório de Fornecedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelForn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BdCadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFonecedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbFonecedorBindingSource;
        private BdCadastroDataSet BdCadastroDataSet;
        private BdCadastroDataSetTableAdapters.tbFonecedorTableAdapter tbFonecedorTableAdapter;
    }
}