using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
	public class StaffBLL
	{
		private StaffDAL _staffDAL;
		private UserDTO _userDTO = new UserDTO();

		public StaffBLL()
		{
			_staffDAL = new StaffDAL();
		}

		// Hiển thị
		public List<UserDTO> GetAllStaff()
		{
			return _staffDAL.GetAllStaff();
		}

		// Sửa
		public bool UpdateStaff(UserDTO updatedUser)
		{
			return _staffDAL.UpdateStaff(updatedUser);
		}

		// Xóa
		public bool DeleteStaff(string userId)
		{
			return _staffDAL.DeleteStaff(userId);
		}

		// Tìm kiếm
		public List<UserDTO> SearchStaff(string accountName)
		{
			return _staffDAL.SearchStaff(accountName);
		}
	}
}
