using AutoMapper;
using CustomerInvoicesApp.Data;
using CustomerInvoicesApp.DTOs;
using CustomerInvoicesApp.Models;
using System.Collections.Generic;

namespace CustomerInvoicesApp.Managers
{
    public class CustomerManger
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerManger(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<CustomerModel> GetCustomers()
        {
            var customers = _unitOfWork.CustomerRepository.GetAllCustomers();
            var customersToReturn = _mapper.Map<IEnumerable<CustomerModel>>(customers);
            return customersToReturn;
        }

        public CustomerModel GetSingleCustomer(int customerId)
        {
            var customer = _unitOfWork.CustomerRepository.Get(customerId);
            return _mapper.Map<CustomerModel>(customer);
        }

        public void AddCustomer(CustomerModel customerModel)
        {
            var customer = _mapper.Map<Customer>(customerModel);
            _unitOfWork.CustomerRepository.Add(customer);
            _unitOfWork.Save();
        }

    }
}
