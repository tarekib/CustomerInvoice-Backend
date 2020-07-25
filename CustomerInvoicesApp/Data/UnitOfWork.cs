namespace CustomerInvoicesApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            CustomerRepository = new CustomerRepository(_context);
            InvoiceRepository = new InvoiceRepository(_context); 
        }

        public ICustomerRepository CustomerRepository { get; private set; }
      
        public IInvoiceRepository InvoiceRepository { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
