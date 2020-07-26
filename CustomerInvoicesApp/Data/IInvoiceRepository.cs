using CustomerInvoicesApp.Models;
using System.Collections.Generic;

namespace CustomerInvoicesApp.Data
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        List<Invoice> GetAllInvoices();
    }
}
