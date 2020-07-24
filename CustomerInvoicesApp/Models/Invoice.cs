using System;

namespace CustomerInvoicesApp.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public decimal Total { get; set; }

        public Customer Customer { get; set; }
    }
}
