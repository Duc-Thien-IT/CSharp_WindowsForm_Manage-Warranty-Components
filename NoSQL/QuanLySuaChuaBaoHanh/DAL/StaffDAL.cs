using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
	public class StaffDAL
	{
		public MongoConnection _connection;
		public UserDTO _userDTO;
		IMongoCollection<UserDTO> _usersCollection;

		public StaffDAL()
		{
			_connection = new MongoConnection();
			var database = _connection.GetMongoClient().GetDatabase("QLBH");
			_usersCollection = database.GetCollection<UserDTO>("User");
		}

		// Hiển thị
		public List<UserDTO> GetAllStaff()
		{
			return _usersCollection.Find(_ => true).ToList();
		}

		// Sửa
		public bool UpdateStaff(UserDTO updatedUser)
		{
			var filter = Builders<UserDTO>.Filter.Eq(u => u.Id, updatedUser.Id);
			var update = Builders<UserDTO>.Update
				.Set(u => u.Account, updatedUser.Account)
				.Set(u => u.PassWord, updatedUser.PassWord)
				.Set(u => u.DiaChi, updatedUser.DiaChi)
				.Set(u => u.HoTen, updatedUser.HoTen)
				.Set(u => u.NgaySinh, updatedUser.NgaySinh)
				.Set(u => u.Phai, updatedUser.Phai);

			var result = _usersCollection.UpdateOne(filter, update);
			return result.ModifiedCount > 0;
		}


		// Xóa
		public bool DeleteStaff(string userId)
		{
			if (userId == UserDAL.LoggedInUserId)
			{
				throw new InvalidOperationException("Bạn không thể xóa tài khoản của chính mình.");
			}

			var filter = Builders<UserDTO>.Filter.Eq(u => u.Id, userId);
			var result = _usersCollection.DeleteOne(filter);
			return result.DeletedCount > 0;
		}


		// Tìm kiếm
		public List<UserDTO> SearchStaff(string accountName)
		{
			var filter = Builders<UserDTO>.Filter.Regex("Account", new MongoDB.Bson.BsonRegularExpression(accountName, "i"));
			return _usersCollection.Find(filter).ToList();
		}
	}
}
