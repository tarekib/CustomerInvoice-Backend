using AutoMapper;
using CustomerInvoicesApp.Data;
using CustomerInvoicesApp.DTOs;
using CustomerInvoicesApp.Managers;
using Microsoft.AspNetCore.Mvc;

namespace CustomerInvoicesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly InvoiceManager _invoiceManager;

        public InvoiceController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _invoiceManager = new InvoiceManager(_unitOfWork, _mapper);
        }

        [HttpPost]
        public IActionResult CreateInvoiceForCustomer(int customerId, InvoiceDto invoiceModel)
        {
            _invoiceManager.CreateInvoiceForCustomer(customerId, invoiceModel);
            return NoContent();
        }

        [HttpGet]
        public IActionResult GetInvoices()
        {
            return Ok(_invoiceManager.GetInvoices());
        }
    }
}