using CustomerInvoicesApp.Models;
using System.Collections.Generic;

namespace CustomerInvoicesApp.DTOs
{
    public class CustomerModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
