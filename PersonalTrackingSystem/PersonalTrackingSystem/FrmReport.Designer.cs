namespace PersonalTrackingSystem
{
    partial class FrmReport
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
            this.personelDbDataSet = new PersonalTrackingSystem.PersonelDbDataSet();
            this.personelDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PersonelTableAdapter = new PersonalTrackingSystem.PersonelDbDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.tblPersonelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblPersonelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personelDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tblPersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonalTrackingSystem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(735, 351);
            this.reportViewer1.TabIndex = 0;
            // 
            // personelDbDataSet
            // 
            this.personelDbDataSet.DataSetName = "PersonelDbDataSet";
            this.personelDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelDbDataSetBindingSource
            // 
            this.personelDbDataSetBindingSource.DataSource = this.personelDbDataSet;
            this.personelDbDataSetBindingSource.Position = 0;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelDbDataSetBindingSource;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // tblPersonelBindingSource1
            // 
            this.tblPersonelBindingSource1.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource1.DataSource = this.personelDbDataSetBindingSource;
            // 
            // tblPersonelBindingSource2
            // 
            this.tblPersonelBindingSource2.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource2.DataSource = this.personelDbDataSetBindingSource;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 351);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReport";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PersonelDbDataSet personelDbDataSet;
        private System.Windows.Forms.BindingSource personelDbDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelDbDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource1;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource2;
    }
}