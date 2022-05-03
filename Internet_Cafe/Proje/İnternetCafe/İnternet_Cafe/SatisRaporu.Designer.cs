
namespace İnternet_Cafe
{
    partial class SatisRaporu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InternetCafeDataSet = new İnternet_Cafe.InternetCafeDataSet();
            this.tbl_satisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_satisTableAdapter = new İnternet_Cafe.InternetCafeDataSetTableAdapters.tbl_satisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InternetCafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_satisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_satisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "İnternet_Cafe.pImage1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1134, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // InternetCafeDataSet
            // 
            this.InternetCafeDataSet.DataSetName = "InternetCafeDataSet";
            this.InternetCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_satisBindingSource
            // 
            this.tbl_satisBindingSource.DataMember = "tbl_satis";
            this.tbl_satisBindingSource.DataSource = this.InternetCafeDataSet;
            // 
            // tbl_satisTableAdapter
            // 
            this.tbl_satisTableAdapter.ClearBeforeFill = true;
            // 
            // SatisRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 508);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SatisRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Raporu";
            this.Load += new System.EventHandler(this.SatisRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InternetCafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_satisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_satisBindingSource;
        private InternetCafeDataSet InternetCafeDataSet;
        private InternetCafeDataSetTableAdapters.tbl_satisTableAdapter tbl_satisTableAdapter;
    }
}