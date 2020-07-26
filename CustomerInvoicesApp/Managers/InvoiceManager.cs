using AutoMapper;
using CustomerInvoicesApp.Data;
using CustomerInvoicesApp.DTOs;
using CustomerInvoicesApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace CustomerInvoicesApp.Managers
{
    public class InvoiceManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InvoiceManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void CreateInvoiceForCustomer(InvoiceDto invoiceModel)
        {
            var invoice = _mapper.Map<Invoice>(invoiceModel);
            var customer = _unitOfWork.CustomerRepository.Get(invoiceModel.CustomerId);
            if (customer != null)
            {
                invoice.Customer = customer;
                _unitOfWork.InvoiceRepository.Add(invoice);
                _unitOfWork.Save();
            }
        }

        public List<InvoiceDto> GetInvoices()
        {
            var invoices = _unitOfWork.InvoiceRepository.GetAllInvoices();
            if (invoices == null || !invoices.Any()) return null;
            var invoicesDtos = new List<InvoiceDto>();

            foreach (var invoice in invoices)
            {
                var invoiceDto = _mapper.Map<InvoiceDto>(invoice);
                invoiceDto.FirstName = invoice.Customer.FirstName;
                invoiceDto.LastName = invoice.Customer.LastName;
                invoicesDtos.Add(invoiceDto);
            }

            return invoicesDtos;
        }
    }
}
