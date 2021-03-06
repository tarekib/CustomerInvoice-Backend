﻿using AutoMapper;
using CustomerInvoicesApp.Data;
using CustomerInvoicesApp.DTOs;
using CustomerInvoicesApp.Managers;
using Microsoft.AspNetCore.Mvc;

namespace CustomerInvoicesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly CustomerManger _customerManager;

        public CustomerController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _customerManager = new CustomerManger(_unitOfWork, _mapper);
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(_customerManager.GetCustomers());
        }

        [HttpGet("{id}")]
        public IActionResult GetSingleCustomer(int id)
        {
            return Ok(_customerManager.GetSingleCustomer(id));
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerDto customerModel)
        {
            _customerManager.AddCustomer(customerModel);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteCustomer(int customerId)
        {
            _customerManager.DeleteCustomer(customerId);
            return NoContent();
        }
    }
}