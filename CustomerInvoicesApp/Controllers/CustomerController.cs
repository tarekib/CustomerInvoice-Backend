using System;
using System.Collections.Generic;
using AutoMapper;
using CustomerInvoicesApp.Data;
using CustomerInvoicesApp.DTOs;
using CustomerInvoicesApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerInvoicesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public CustomerController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customers = _unitOfWork.Customers.GetAllCustomers();
            var customersToReturn = _mapper.Map<IEnumerable<CustomerModel>>(customers);
            return Ok(customersToReturn);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var customer = _unitOfWork.Customers.Get(id);
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult AddCustomer()
        {
            _unitOfWork.Customers.Add(new Customer
            {
                FirstName = "Customer",
                LastName = "A",
                CreatedDate = DateTime.UtcNow,
                City = "Beirut",
                Country = "Lebanon"
            });

            _unitOfWork.Complete();
            return NoContent();
        }
    }
}