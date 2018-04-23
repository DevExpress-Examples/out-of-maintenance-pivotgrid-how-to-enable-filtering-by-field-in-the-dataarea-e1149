Imports Microsoft.VisualBasic
Imports System
Namespace dxSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.nwindDataSet = New dxSample.nwindDataSet()
			Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.salesPersonTableAdapter = New dxSample.nwindDataSetTableAdapters.SalesPersonTableAdapter()
			Me.myPivotGridControl1 = New DXSample.MyPivotGridControl()
			Me.fieldOrderDate = New DXSample.MyPivotGridField()
			Me.fieldUnitPrice = New DXSample.MyPivotGridField()
			Me.fieldSalesPerson = New DXSample.MyPivotGridField()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myPivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' salesPersonBindingSource
			' 
			Me.salesPersonBindingSource.DataMember = "SalesPerson"
			Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
			' 
			' salesPersonTableAdapter
			' 
			Me.salesPersonTableAdapter.ClearBeforeFill = True
			' 
			' myPivotGridControl1
			' 
			Me.myPivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.myPivotGridControl1.DataSource = Me.salesPersonBindingSource
			Me.myPivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myPivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldOrderDate, Me.fieldUnitPrice, Me.fieldSalesPerson})
			Me.myPivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myPivotGridControl1.Name = "myPivotGridControl1"
			Me.myPivotGridControl1.Size = New System.Drawing.Size(691, 460)
			Me.myPivotGridControl1.TabIndex = 0
			' 
			' fieldOrderDate
			' 
			Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate.AreaIndex = 0
			Me.fieldOrderDate.FieldName = "OrderDate"
			Me.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldOrderDate.Name = "fieldOrderDate"
			' 
			' fieldUnitPrice
			' 
			Me.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldUnitPrice.AreaIndex = 0
			Me.fieldUnitPrice.FieldName = "UnitPrice"
			Me.fieldUnitPrice.Name = "fieldUnitPrice"
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 0
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(691, 460)
			Me.Controls.Add(Me.myPivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myPivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myPivotGridControl1 As DXSample.MyPivotGridControl
		Private nwindDataSet As nwindDataSet
		Private salesPersonBindingSource As System.Windows.Forms.BindingSource
		Private salesPersonTableAdapter As dxSample.nwindDataSetTableAdapters.SalesPersonTableAdapter
		Private fieldOrderDate As DXSample.MyPivotGridField
		Private fieldUnitPrice As DXSample.MyPivotGridField
		Private fieldSalesPerson As DXSample.MyPivotGridField
	End Class
End Namespace

