Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data

Namespace dxSample
	Public Class MyPivotGridControl
		Inherits PivotGridControl

		Public Sub New()
			MyBase.New()
		End Sub
		Protected Overrides Function CreateData() As PivotGridViewInfoData
			Return New MyPivotGridViewInfoData(Me)
		End Function
	End Class
End Namespace