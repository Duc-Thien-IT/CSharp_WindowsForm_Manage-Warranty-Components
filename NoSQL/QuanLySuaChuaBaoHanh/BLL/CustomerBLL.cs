using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using MongoDB.Driver;

namespace BLL
{
	public class CustomerBLL
	{
		private CustomerDAL _customerDAL;
		private CustomerDTO _customerDTO = new CustomerDTO();



		public CustomerBLL()
		{
			_customerDAL = new CustomerDAL();
		}
		private readonly IMongoCollection<CustomerDTO> _customers;

		public CustomerBLL(IMongoCollection<CustomerDTO> customers)
		{
			_customers = customers;
		}
		public List<CustomerDTO> GetAllCustomers()
		{
			return _customerDAL.GetAllCustomers();
		}

		public CustomerDTO GetCustomerByPhoneNumber(string phoneNumber)
		{
			return _customerDAL.GetCustomerByPhoneNumber(phoneNumber);
		}
		public CustomerDTO GetCustomerById(string customerId)
		{
			return _customerDAL.GetCustomerById(customerId);
		}
		public void AddCustomer(CustomerDTO customer)
		{
			_customerDAL.AddCustomer(customer);

		}

		public void UpdateCustomer(CustomerDTO customer)
		{
			_customerDAL.UpdateCustomer(customer);
		}

		public bool DeleteCustomer(string customerId)
		{
			return _customerDAL.DeleteCustomer(customerId);
		}
        public List<string> GetAllPhoneNumbers()
        {
            var customers = _customerDAL.GetAllCustomers(); // Giả sử bạn có phương thức này trong DAL để lấy tất cả khách hàng
            return customers.Select(c => c.SDT).ToList();
        }
    }
}
