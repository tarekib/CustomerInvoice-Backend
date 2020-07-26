using CustomerInvoicesApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace CustomerInvoicesApp.Data
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DataContext context) : base(context)
        {

        }

        public List<Customer> GetAllCustomers()
        {
           return GetAll(new string[] { "Invoices" }).Where(c => !c.IsRemoved).ToList();
        }
    }

}
