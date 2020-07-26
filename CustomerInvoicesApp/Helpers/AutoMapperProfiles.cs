using AutoMapper;
using CustomerInvoicesApp.DTOs;
using CustomerInvoicesApp.Models;

namespace CustomerInvoicesApp.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<Invoice, InvoiceDto>();
            CreateMap<InvoiceDto, Invoice>();
        }
    }
}
