using CustomerInvoicesApp.Models;
using System.Collections.Generic;

namespace CustomerInvoicesApp.Data
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        List<Customer> GetAllCustomers();
    }
}
