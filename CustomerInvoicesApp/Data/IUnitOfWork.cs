using System;

namespace CustomerInvoicesApp.Data
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }

        IInvoiceRepository Invoices { get; }

        int Complete();
    }
}
