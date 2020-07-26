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

        public List<CustomerDto> GetCustomers()
        {
            var customers = _unitOfWork.CustomerRepository.GetAllCustomers();
            if (null == customers) return null;
            var customersToReturn = _mapper.Map<List<CustomerDto>>(customers);
            return customersToReturn;
        }

        public CustomerDto GetSingleCustomer(int customerId)
        {
            var customer = _unitOfWork.CustomerRepository.Get(customerId);
            if (null == customer) return null;
            return _mapper.Map<CustomerDto>(customer);
        }

        public void AddCustomer(CustomerDto customerModel)
        {
            var customer = _mapper.Map<Customer>(customerModel);
            _unitOfWork.CustomerRepository.Add(customer);
            _unitOfWork.Save();
        }

        public void DeleteCustomer(int customerId)
        {
            var customerEntity = _unitOfWork.CustomerRepository.Get(customerId);
            customerEntity.IsRemoved = true;
            _unitOfWork.CustomerRepository.Update(customerEntity);
            _unitOfWork.Save();

        }
    }
}
