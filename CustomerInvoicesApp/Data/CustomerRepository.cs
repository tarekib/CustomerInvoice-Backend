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

        public IEnumerable<Customer> GetAllCustomers()
        {
            var query = GetAll(new string[] { "Invoices" });
            return query.ToList();
        }
    }

}
