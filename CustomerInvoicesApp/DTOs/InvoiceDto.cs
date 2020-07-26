using System;

namespace CustomerInvoicesApp.DTOs
{
    public class InvoiceDto
    {
        public int Id { get; set; }

        public string InvoiceNumber { get; set; }

        public decimal Total { get; set; }

        public string TotalToDisplay => GetTotal();

        public DateTime CreatedDate { get; set; }

        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => FullNameExpression();

        public InvoiceDto()
        {
            CreatedDate = DateTime.Now;
        }

        private string FullNameExpression()
        {
            return $"{FirstName} {LastName}";
        }

        private string GetTotal()
        {
            return $"{Total} USD";
        }
    }
}
