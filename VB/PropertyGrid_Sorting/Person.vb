Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq

Namespace PropertyGrid_Sorting
	Public Class Person
		<Category("Info")>
		Public Property ID() As Integer
		<Category("Info")>
		Public Property FirstName() As String
		<Category("Info")>
		Public Property LastName() As String
		<Category("Contact"), TypeConverter(GetType(ExpandableObjectConverter))>
		Public Property Address() As SimpleAddress
		<Category("Contact")>
		Public Property Email() As String
		<Category("Info")>
		Public Property Orders() As List(Of Order)
	End Class

	Public Class SimpleAddress
		Public Property State() As String
		Public Property City() As String
		Public Property ZIP() As String
	End Class

	Public Class Order
		Public Property ID() As Integer
		Public Property ContactName() As String
		Public Property OrderDate() As Date
	End Class
End Namespace
