using System;
using System.Collections.Generic;
using System.Linq;

namespace PropertyGrid_Sorting
{
    public class ViewModel
    {
        public Person Data { get; set; }
        public ViewModel() {
            Data = new Person{
                ID = 0,
                FirstName = "Anna",
                LastName = "Trujilo",
                Address = new SimpleAddress() { State = "California", City = "Oakland", ZIP = "94601" },
                Orders = new List<Order> {
                    new Order() { ID = 0, ContactName = "Jack Plank", OrderDate = new DateTime(2018, 2, 15) },
                    new Order() { ID = 1, ContactName = "Elsa Lynch", OrderDate = new DateTime(2018, 3, 4) }
                }
            };
        }
    }
}
