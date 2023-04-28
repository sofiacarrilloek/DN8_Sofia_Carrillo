using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesCollections
{
    public class Customer : IEquatable<Customer>
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerLastName { get; set; }

        public DateTime CustomerDateTime { get; set; }

        public override string ToString()
        {
            return "Name: " + CustomerName + "  Last name: " + CustomerLastName+ "  Date of reistration: " + CustomerDateTime;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Customer objAsCustomer = obj as Customer;
            if (objAsCustomer == null) return false;
            else return Equals(objAsCustomer);
        }

        public override int GetHashCode()
        {
            return CustomerId;
        }

        public bool Equals(Customer other)
        {
            if (other == null) return false;
            return (this.CustomerId.Equals(other.CustomerId));
        }
    }
}
