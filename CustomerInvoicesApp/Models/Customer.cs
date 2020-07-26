using System;
using System.Collections.Generic;

namespace CustomerInvoicesApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedDate { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public bool IsRemoved { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
