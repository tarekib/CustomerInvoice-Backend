using CustomerInvoicesApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CustomerInvoicesApp.Data
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DataContext context) : base(context)
        {
            
        }

        public DataContext DataContext => Context as DataContext;

        public IEnumerable<Customer> GetAllCustomers()
        {
            var customers = DataContext.Customers.Include(c => c.Invoices).ToList();
            return customers;
        }
    }
}
