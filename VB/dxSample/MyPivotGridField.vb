Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraPivotGrid.ViewInfo

Namespace DXSample
	Public Class MyPivotGridField
		Inherits PivotGridField
		Public Sub New(ByVal fieldName As String, ByVal area As PivotArea)
			MyBase.New(fieldName, area)
		End Sub
		Public Sub New()
			Me.New(String.Empty, PivotArea.FilterArea)
		End Sub
		Public Sub New(ByVal data As PivotGridData)
			MyBase.New(data)
		End Sub
		Public Overrides ReadOnly Property CanFilter() As Boolean
			Get
				If Data Is Nothing OrElse (Not Visible) Then
					Return False
				End If
				If Area = PivotArea.DataArea Then
					Return True
				End If
				Return MyBase.CanFilter
			End Get
		End Property
	End Class

	Public Class MyPivotGridFieldCollection
		Inherits PivotGridFieldCollection
		Public Sub New(ByVal data As PivotGridData)
			MyBase.New(data)
		End Sub
		Protected Overrides Function CreateFieldCore(ByVal fieldName As String, ByVal area As PivotArea) As PivotGridField
			Return New MyPivotGridField(fieldName, area)
		End Function
	End Class

	Public Class MyPivotGridViewInfoData
		Inherits PivotGridViewInfoData
		Public Sub New(ByVal control As IViewInfoControl)
			MyBase.New(control)
		End Sub
		Public Sub New()
			Me.New(Nothing)
		End Sub
		Protected Overrides Function CreateFieldCollection() As PivotGridFieldCollectionBase
			Return New MyPivotGridFieldCollection(Me)
		End Function
	End Class
End Namespace