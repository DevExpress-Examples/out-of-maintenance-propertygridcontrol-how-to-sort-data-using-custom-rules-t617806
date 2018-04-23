Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace PropertyGrid_Sorting
	Public Class ViewModel
		Public Property Data() As Person
		Public Sub New()
			Data = New Person With {
				.ID = 0,
				.FirstName = "Anna",
				.LastName = "Trujilo",
				.Address = New SimpleAddress() With {
					.State = "California",
					.City = "Oakland",
					.ZIP = "94601"
				},
				.Orders = New List(Of Order) From {
					New Order() With {
						.ID = 0,
						.ContactName = "Jack Plank",
						.OrderDate = New Date(2018, 2, 15)
					},
					New Order() With {
						.ID = 1,
						.ContactName = "Elsa Lynch",
						.OrderDate = New Date(2018, 3, 4)
					}
				}
			}
		End Sub
	End Class
End Namespace
