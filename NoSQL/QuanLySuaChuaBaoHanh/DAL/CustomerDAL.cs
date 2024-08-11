using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.CustomerDAL;
using DTO;
using MongoDB.Bson;

namespace DAL
{
	public class CustomerDAL
	{
		private MongoConnection _connection;
		private CustomerDTO _customerDTO;
		public string CustomerID { get; set; }
		IMongoCollection<CustomerDTO> _customersCollection;

		public CustomerDAL()
		{
			_connection = new MongoConnection();
			var database = _connection.GetMongoClient().GetDatabase("QLBH");
			_customersCollection = database.GetCollection<CustomerDTO>("Customer");
		}
		public CustomerDTO GetCustomerByPhoneNumber(string phoneNumber)
		{
			return _customersCollection.Find(c => c.SDT == phoneNumber).FirstOrDefault();
		}
		public CustomerDTO GetCustomerById(string customerId)
		{
			var filter = Builders<CustomerDTO>.Filter.Eq(c => c.Id, customerId);
			return _customersCollection.Find(filter).FirstOrDefault();
		}
		public void AddCustomer(CustomerDTO customer)
		{
			_customersCollection.InsertOne(customer);
		}

		public void UpdateCustomer(CustomerDTO customer)
		{
			var filter = Builders<CustomerDTO>.Filter.Eq(c => c.Id, customer.Id);
			_customersCollection.ReplaceOne(filter, customer);
		}

		public bool DeleteCustomer(string customerId)
		{
			var result = _customersCollection.DeleteOne(c => c.Id == customerId);
			return result.DeletedCount > 0;
		}
		
        public List<CustomerDTO> GetAllCustomers()
        {
            return _customersCollection.Find(_ => true).ToList(); // Lấy tất cả khách hàng từ collection
        }

    }
}
