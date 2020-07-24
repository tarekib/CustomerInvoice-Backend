using AutoMapper;
using CustomerInvoicesApp.DTOs;
using CustomerInvoicesApp.Models;

namespace CustomerInvoicesApp.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Customer, CustomerModel>();
            CreateMap<Invoice, InvoiceModel>();
            CreateMap<InvoiceModel, Invoice>();
        }
    }
}
