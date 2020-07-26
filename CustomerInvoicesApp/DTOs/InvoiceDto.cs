using System;

namespace CustomerInvoicesApp.DTOs
{
    public class InvoiceDto
    {
        public int Id { get; set; }

        public string InvoiceNumber { get; set; }

        public decimal Total { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public InvoiceDto()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
