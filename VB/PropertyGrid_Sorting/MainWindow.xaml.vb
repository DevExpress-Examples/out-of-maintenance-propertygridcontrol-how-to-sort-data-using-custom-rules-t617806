Imports DevExpress.Xpf.PropertyGrid
Imports System
Imports System.Linq

Namespace PropertyGrid_Sorting
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub PropertyGridControl_Sort(ByVal sender As Object, ByVal args As DevExpress.Xpf.PropertyGrid.PropertyGridSortingEventArgs)
			Dim list As List(Of RowInfo) = args.SourceCollection.ToList()
			If args.SourceCollection.All(Function(x) x.IsCategory) Then
				Return
			End If
			list = list.OrderByDescending(Function(x) x.Header).ToList()
			' move ID to top
			Dim idRow As RowInfo = list.Where(Function(r) r.Header = "ID").FirstOrDefault()
			If idRow IsNot Nothing Then
				list.Remove(idRow)
				list.Insert(0, idRow)
			End If
			args.ResultCollection = list
		End Sub

		Private Sub pGrid_CustomExpand(ByVal sender As Object, ByVal args As CustomExpandEventArgs)
			args.IsExpanded = True ' to expand all rows
		End Sub
	End Class
End Namespace
