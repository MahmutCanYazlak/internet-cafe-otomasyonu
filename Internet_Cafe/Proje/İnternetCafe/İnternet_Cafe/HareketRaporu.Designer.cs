
namespace İnternet_Cafe
{
    partial class HareketRaporu
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
            this.tbl_hareketlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_hareketlerTableAdapter = new İnternet_Cafe.InternetCafeDataSetTableAdapters.tbl_hareketlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InternetCafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_hareketlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_hareketlerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "İnternet_Cafe.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1126, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // InternetCafeDataSet
            // 
            this.InternetCafeDataSet.DataSetName = "InternetCafeDataSet";
            this.InternetCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_hareketlerBindingSource
            // 
            this.tbl_hareketlerBindingSource.DataMember = "tbl_hareketler";
            this.tbl_hareketlerBindingSource.DataSource = this.InternetCafeDataSet;
            // 
            // tbl_hareketlerTableAdapter
            // 
            this.tbl_hareketlerTableAdapter.ClearBeforeFill = true;
            // 
            // HareketRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 508);
            this.Controls.Add(this.reportViewer1);
            this.Name = "HareketRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hareket Raporu";
            this.Load += new System.EventHandler(this.HareketRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InternetCafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_hareketlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_hareketlerBindingSource;
        private InternetCafeDataSet InternetCafeDataSet;
        private InternetCafeDataSetTableAdapters.tbl_hareketlerTableAdapter tbl_hareketlerTableAdapter;
    }
}