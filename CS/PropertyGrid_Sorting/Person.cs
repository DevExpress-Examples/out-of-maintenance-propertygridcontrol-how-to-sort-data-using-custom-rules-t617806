using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PropertyGrid_Sorting
{
    public class Person
    {
        [Category("Info")]
        public int ID { get; set; }
        [Category("Info")]
        public string FirstName { get; set; }
        [Category("Info")]
        public string LastName { get; set; }
        [Category("Contact")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public SimpleAddress Address { get; set; }
        [Category("Contact")]
        public string Email { get; set; }
        [Category("Info")]
        public List<Order> Orders { get; set; }
    }

    public class SimpleAddress
    {
        public string State { get; set; }
        public string City { get; set; }
        public string ZIP { get; set; }
    }

    public class Order
    {
        public int ID { get; set; }
        public string ContactName{ get; set; }
        public DateTime OrderDate { get; set; }
    }
}
