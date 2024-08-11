using DAL;
using DTO;
using MongoDB.Driver;
using System.Collections.Generic;
using System;
using static DTO.ChiTietPBHDTO;

public class WarrantyDAL
{
	private MongoConnection _connection;
	private IMongoCollection<WarrantyDTO> _warrantyCollection;
	private IMongoCollection<CustomerDTO> _customerCollection;
	private IMongoCollection<UserDTO> _userCollection;

	public WarrantyDAL()
	{
		_connection = new MongoConnection();
		var database = _connection.GetMongoClient().GetDatabase("QLBH");
		_warrantyCollection = database.GetCollection<WarrantyDTO>("Warranty");
		_customerCollection = database.GetCollection<CustomerDTO>("Customer");
        _userCollection = database.GetCollection<UserDTO>("User"); 
    }

	public List<CustomerDTO> GetCustomerByPhoneNumber(string phoneNumber)
	{
		var filter = Builders<CustomerDTO>.Filter.Eq("SDT", phoneNumber);
		return _customerCollection.Find(filter).ToList();
	}

    public void AddWarranty(WarrantyDTO warranty, string customerId)
    {
        if (warranty == null)
            throw new ArgumentNullException(nameof(warranty));

        if (string.IsNullOrEmpty(customerId))
            throw new ArgumentException("Customer ID cannot be null or empty.", nameof(customerId));

        // Insert the warranty
        //_warrantyCollection.InsertOne(warranty);

        // Update the customer with the new warranty object
        var filter = Builders<CustomerDTO>.Filter.Eq(c => c.Id, customerId);
        var update = Builders<CustomerDTO>.Update.Push(c => c.PBH, warranty); // Thêm đối tượng WarrantyDTO vào mảng PBH
        _customerCollection.UpdateOne(filter, update);
    }
    public void AddChiTietPBH(string customerId, string maPBH, ChiTietPBH chiTiet)
    {
        if (string.IsNullOrEmpty(customerId))
            throw new ArgumentException("Customer ID cannot be null or empty.", nameof(customerId));

        if (string.IsNullOrEmpty(maPBH))
            throw new ArgumentException("Warranty ID cannot be null or empty.", nameof(maPBH));

        if (chiTiet == null)
            throw new ArgumentNullException(nameof(chiTiet));

        var filter = Builders<CustomerDTO>.Filter.And(
            Builders<CustomerDTO>.Filter.Eq(c => c.Id, customerId),
            Builders<CustomerDTO>.Filter.ElemMatch(c => c.PBH, p => p.MaPBH == maPBH)
        );

        var update = Builders<CustomerDTO>.Update.Push("PBH.$.ChiTietPBH", chiTiet);
        _customerCollection.UpdateOne(filter, update);
    }
    public void AddCustomerToUser(string userId, string customerId)
    {
        if (string.IsNullOrEmpty(userId))
            throw new ArgumentException("User ID cannot be null or empty.", nameof(userId));

        if (string.IsNullOrEmpty(customerId))
            throw new ArgumentException("Customer ID cannot be null or empty.", nameof(customerId));

        var filter = Builders<UserDTO>.Filter.Eq(u => u.Id, userId);
        var update = Builders<UserDTO>.Update.AddToSet(u => u.KhachHang, customerId);
        _userCollection.UpdateOne(filter, update);
    }

    public void AddWarrantyToCustomer(string customerId, WarrantyDTO warranty)
    {
        if (string.IsNullOrEmpty(customerId))
            throw new ArgumentException("Customer ID cannot be null or empty.", nameof(customerId));

        if (warranty == null)
            throw new ArgumentNullException(nameof(warranty));

        var filter = Builders<CustomerDTO>.Filter.Eq(c => c.Id, customerId);
        var update = Builders<CustomerDTO>.Update.Push(c => c.PBH, warranty); // Sử dụng Push để thêm warranty vào mảng
        _customerCollection.UpdateOne(filter, update);
    }
    public List<WarrantyDTO> GetWarrantyByCustomer(string customerId)
    {
        var filter = Builders<CustomerDTO>.Filter.Eq(c => c.Id, customerId);
        var customer = _customerCollection.Find(filter).FirstOrDefault();
        return customer?.PBH ?? new List<WarrantyDTO>();
    }

}
