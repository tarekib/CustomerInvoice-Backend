using AutoMapper;
using CustomerInvoicesApp.Data;
using CustomerInvoicesApp.DTOs;
using CustomerInvoicesApp.Models;
using System.Collections.Generic;

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

        public void CreateInvoiceForCustomer(int customerId, InvoiceModel invoiceModel)
        {
            var invoice = _mapper.Map<Invoice>(invoiceModel);
            invoice.Customer = _unitOfWork.CustomerRepository.Get(customerId);
            _unitOfWork.InvoiceRepository.Add(invoice);
            _unitOfWork.Save();
        }

        public IEnumerable<InvoiceModel> GetInvoices()
        {
            var invoices = _unitOfWork.InvoiceRepository.GetAll();
            return _mapper.Map<IEnumerable<InvoiceModel>>(invoices);
        }
    }
}
