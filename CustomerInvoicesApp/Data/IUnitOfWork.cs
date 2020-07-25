using System;

namespace CustomerInvoicesApp.Data
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository CustomerRepository { get; }

        IInvoiceRepository InvoiceRepository { get; }

        int Save();
    }
}
