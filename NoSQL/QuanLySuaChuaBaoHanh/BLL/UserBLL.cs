using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
	public class UserBLL
	{
		private UserDAL _userDAL;
		private UserDTO _userDTO = new UserDTO();
		public UserBLL()
		{
			_userDAL = new UserDAL();
		}

		public string checkLogin(string Account, string Password)
		{
			return _userDAL.checkLogin(Account, Password);
		}
		public UserDTO getUser(string userID)
		{
			return _userDAL.getUser(userID);
		}
		public int checkSingup(string Account, string SDT)
		{
			return _userDAL.checkSignup(Account, SDT);
		}

		public string createUser(string Account, string Pass, string Hoten, string NgaySinh, string Role, string DiaChi, string Phai, string SDT)
		{
			return _userDAL.createUser(Account, Pass, Hoten, NgaySinh, Role, DiaChi, Phai, SDT);
		}

		public string forgotPWord(string Account, string Password)
		{
			return _userDAL.forgotPWord(Account, Password); ;
		}

		public void AddCustomerToUser(string userId, string customerId)
		{
			_userDAL.AddCustomerToUser(userId, customerId);
		}
	}
}
