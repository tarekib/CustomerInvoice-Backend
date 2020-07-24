using AutoMapper;
using CustomerInvoicesApp.Data;
using CustomerInvoicesApp.DTOs;
using CustomerInvoicesApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomerInvoicesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public InvoiceController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateInvoiceForCustomer(int customerId, InvoiceModel invoiceModel)
        {
            var invoice = _mapper.Map<Invoice>(invoiceModel);
            invoice.Customer = _unitOfWork.Customers.Get(customerId);
            _unitOfWork.Invoices.Add(invoice);
            _unitOfWork.Complete();
            return NoContent();
        }

        [HttpGet]
        public IActionResult GetInvoices()
        {
            var invoices = _unitOfWork.Invoices.GetAll();
            var invoicesToReturn = _mapper.Map<IEnumerable<InvoiceModel>>(invoices);
            return Ok(invoicesToReturn);
        }
    }
}