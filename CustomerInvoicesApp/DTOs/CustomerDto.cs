using CustomerInvoicesApp.Models;
using System;
using System.Collections.Generic;

namespace CustomerInvoicesApp.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public DateTime CreatedDate { get; set; }


        public ICollection<InvoiceDto> Invoices { get; set; }

        public CustomerDto()
        {
            CreatedDate = DateTime.UtcNow;
        }
    }
}
