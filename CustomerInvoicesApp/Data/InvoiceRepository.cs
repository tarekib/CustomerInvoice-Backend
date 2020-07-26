using CustomerInvoicesApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace CustomerInvoicesApp.Data
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DataContext context) : base(context)
        {

        }

        public DataContext DataContext => Context as DataContext;

        public List<Invoice> GetAllInvoices()
        {
            return GetAll().Where(i => i.Customer != null &&!i.Customer.IsRemoved).ToList();
        }
    }
}
