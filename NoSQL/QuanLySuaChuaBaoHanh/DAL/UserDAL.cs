using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace DAL
{
	public class UserDAL
	{
		private MongoConnection _connection;
		private UserDTO _userDTO;
		public static string LoggedInUserId { get; private set; }


		public string UserID { get; set; }
		IMongoCollection<UserDTO> _usersCollection;

		public UserDAL()
		{
			_connection = new MongoConnection();
			var database = _connection.GetMongoClient().GetDatabase("QLBH");
			_usersCollection = database.GetCollection<UserDTO>("User");

		}


		public string checkLogin(string Account, string Pass)
		{
			var filter = Builders<UserDTO>.Filter.Eq(u => u.Account, Account);

			//kiểm tra tài khoản tồn tại
			var userExists = _usersCollection.Find(filter).FirstOrDefault();
			if (userExists == null)
				return "-1";

			var projection = Builders<UserDTO>.Projection
				.Include(u => u.Id)
				.Include(u => u.PassWord);

			var chkLoginBson = _usersCollection.Find(filter).Project(projection).FirstOrDefault();

			if (chkLoginBson != null)
			{

				var chkLogin = BsonSerializer.Deserialize<UserDTO>(chkLoginBson);
				UserID = chkLogin.Id;
				string pass = chkLogin.PassWord;

				if (pass != Pass)
					return "1";

				// Lưu ID của người dùng đang đăng nhập
				LoggedInUserId = chkLogin.Id;
				return LoggedInUserId;
			}
			return UserID;
		}

		public int checkSignup(string Account, string SDT)
		{
			var filter = Builders<UserDTO>.Filter.Or(
				Builders<UserDTO>.Filter.Eq(u => u.Account, Account),
				Builders<UserDTO>.Filter.Eq(u => u.SDT, SDT)
			);

			var projection = Builders<UserDTO>.Projection
				.Include(u => u.Account)
				.Include(u => u.SDT);

			var chkSignupBson = _usersCollection.Find(filter).Project(projection).FirstOrDefault();

			if (chkSignupBson != null)
			{
				var checkSignup = BsonSerializer.Deserialize<UserDTO>(chkSignupBson);

				string account = checkSignup.Account;
				string sdt = checkSignup.SDT;
				if (account == Account)
					return 1;
				if (sdt == SDT)
					return 2;
			}

			return 0;
		}

		public UserDTO getUser(string userID)
		{
			_userDTO = new UserDTO();
			var filter = Builders<UserDTO>.Filter.Eq(u => u.Id, userID);

			var getUser = _usersCollection.Find(filter).FirstOrDefault();
			if (getUser != null)
			{
				_userDTO = getUser;
			}
			return _userDTO;
		}

		public string createUser(string Account, string Pass, string Hoten, string NgaySinh, string Role, string DiaChi, string Phai, string SDT)
		{
			UserDTO userDTO = new UserDTO()
			{
				Account = Account,
				PassWord = Pass,
				Role = Role,
				DiaChi = DiaChi,
				HoTen = Hoten,
				NgaySinh = NgaySinh,
				Phai = Phai,
				SDT = SDT,
				KhachHang = new List<string>()
			};
			try
			{
				_usersCollection.InsertOne(userDTO);
				return "1";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

		public string forgotPWord(string Account, string Password)
		{
			var filter = Builders<UserDTO>.Filter.Eq(u => u.Account, Account);

			//kiểm tra tài khoản tồn tại
			var userExists = _usersCollection.Find(filter).FirstOrDefault();
			if (userExists == null)
				return "-1";

			var update = Builders<UserDTO>.Update.Set(u => u.PassWord, Password);

			try
			{
				_usersCollection.UpdateOne(filter, update);
				return "1";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}

		}

		public void AddCustomerToUser(string userId, string customerId)
		{
			if (string.IsNullOrEmpty(userId))
				throw new ArgumentException("User ID cannot be null or empty.", nameof(userId));

			if (string.IsNullOrEmpty(customerId))
				throw new ArgumentException("Customer ID cannot be null or empty.", nameof(customerId));

			var filter = Builders<UserDTO>.Filter.Eq(u => u.Id, userId);
			var update = Builders<UserDTO>.Update.AddToSet(u => u.KhachHang, customerId);
			_usersCollection.UpdateOne(filter, update);
		}
	}


}
