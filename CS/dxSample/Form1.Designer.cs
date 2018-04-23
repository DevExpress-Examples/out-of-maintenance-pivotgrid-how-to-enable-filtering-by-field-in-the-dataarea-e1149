namespace dxSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.nwindDataSet = new dxSample.nwindDataSet();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesPersonTableAdapter = new dxSample.nwindDataSetTableAdapters.SalesPersonTableAdapter();
            this.myPivotGridControl1 = new DXSample.MyPivotGridControl();
            this.fieldOrderDate = new DXSample.MyPivotGridField();
            this.fieldUnitPrice = new DXSample.MyPivotGridField();
            this.fieldSalesPerson = new DXSample.MyPivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataMember = "SalesPerson";
            this.salesPersonBindingSource.DataSource = this.nwindDataSet;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // myPivotGridControl1
            // 
            this.myPivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myPivotGridControl1.DataSource = this.salesPersonBindingSource;
            this.myPivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOrderDate,
            this.fieldUnitPrice,
            this.fieldSalesPerson});
            this.myPivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myPivotGridControl1.Name = "myPivotGridControl1";
            this.myPivotGridControl1.Size = new System.Drawing.Size(691, 460);
            this.myPivotGridControl1.TabIndex = 0;
            // 
            // fieldOrderDate
            // 
            this.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate.AreaIndex = 0;
            this.fieldOrderDate.FieldName = "OrderDate";
            this.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldOrderDate.Name = "fieldOrderDate";
            // 
            // fieldUnitPrice
            // 
            this.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitPrice.AreaIndex = 0;
            this.fieldUnitPrice.FieldName = "UnitPrice";
            this.fieldUnitPrice.Name = "fieldUnitPrice";
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson.AreaIndex = 0;
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 460);
            this.Controls.Add(this.myPivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DXSample.MyPivotGridControl myPivotGridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private dxSample.nwindDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private DXSample.MyPivotGridField fieldOrderDate;
        private DXSample.MyPivotGridField fieldUnitPrice;
        private DXSample.MyPivotGridField fieldSalesPerson;
    }
}

