using CustomerInvoicesApp.Models;

namespace CustomerInvoicesApp.Data
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DataContext context) : base(context)
        {

        }

        public DataContext DataContext => Context as DataContext;
    }
}
