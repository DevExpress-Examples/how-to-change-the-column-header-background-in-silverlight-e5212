Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Collections.Generic
Imports System.Windows.Controls

Namespace ColumnsSeparator
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			DXVisualizer.DXVisualTreeVisualizer.Show()
		End Sub
	End Class

	Public Class DataContainer
		Private _data As List(Of DataRow)


		Public Sub New()
			_data = New List(Of DataRow)()

			For i As Integer = 0 To 9
				 _data.Add(New DataRow() With {.Name = "String " & i})
			Next i
		End Sub

		Public ReadOnly Property Data() As IList
			Get
				Return _data
			End Get
		End Property
	End Class

	Public Class DataRow
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class
End Namespace
