namespace CustomerInvoicesApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            Customers = new CustomerRepository(_context);
            Invoices = new InvoiceRepository(_context); 
        }

        public ICustomerRepository Customers { get; private set; }
      
        public IInvoiceRepository Invoices { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
