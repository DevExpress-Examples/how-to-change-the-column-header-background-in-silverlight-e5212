Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Windows.Controls

Namespace ColumnsSeparator
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			Dim customers As New ObservableCollection(Of Customer)()
			For i As Integer = 1 To 29
				customers.Add(New Customer() With {.ID = i, .Name = "Name" & i})
			Next i
			grid.ItemsSource = customers
		End Sub
	End Class

	Public Class Customer
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property

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
