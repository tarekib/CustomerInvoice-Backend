using System;

namespace CustomerInvoicesApp.DTOs
{
    public class InvoiceModel
    {
        public int Id { get; set; }

        public string InvoiceNumber { get; set; }

        public decimal Total { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CustomerId { get; set; }

        public InvoiceModel()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
