using DAL;
using DTO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DTO.ChiTietPBHDTO;

namespace BLL
{
	public class WarrantyBLL
	{
		private WarrantyDAL _warrantyDAL;
		private UserBLL _userBLL;

		public WarrantyBLL()
		{
			_warrantyDAL = new WarrantyDAL();
			_userBLL = new UserBLL();
		}

		public List<CustomerDTO> GetCustomerByPhoneNumber(string phoneNumber)
		{
			return _warrantyDAL.GetCustomerByPhoneNumber(phoneNumber);
		}

		public void AddWarranty(WarrantyDTO warranty, string customerId)
		{
			_warrantyDAL.AddWarranty(warranty, customerId);
		}

		public void AddCustomerToUser(string userId, string customerId)
		{
			_warrantyDAL.AddCustomerToUser(userId, customerId);
		}

        public void AddWarrantyToCustomer(string customerId, WarrantyDTO warranty)
        {
            if (string.IsNullOrEmpty(customerId))
                throw new ArgumentException("Customer ID cannot be null or empty.", nameof(customerId));

            if (warranty == null)
                throw new ArgumentNullException(nameof(warranty));

            _warrantyDAL.AddWarrantyToCustomer(customerId, warranty); // Truyền đối tượng warranty
        }
        public WarrantyDTO GetWarrantyByCode(string warrantyCode, string customerId)
        {
            var filter = Builders<WarrantyDTO>.Filter.Eq(w => w.MaPBH, warrantyCode);
            var warranty = _warrantyDAL.GetWarrantyByCustomer(customerId).FirstOrDefault(w => w.MaPBH == warrantyCode);
            return warranty;
        }
        public List<string> GetWarrantyCodesByPhoneNumber(string phoneNumber)
        {
            var customers = _warrantyDAL.GetCustomerByPhoneNumber(phoneNumber);
            var warrantyCodes = customers.SelectMany(c => c.PBH.Select(w => w.MaPBH)).ToList();
            return warrantyCodes;
        }
        public void AddChiTietPBH(string customerId, string maPBH, ChiTietPBH chiTiet)
        {
            if (string.IsNullOrEmpty(customerId))
                throw new ArgumentException("Customer ID cannot be null or empty.", nameof(customerId));

            if (chiTiet == null)
                throw new ArgumentNullException(nameof(chiTiet));

            _warrantyDAL.AddChiTietPBH(customerId, maPBH, chiTiet); // Gọi phương thức DAL tương ứng
        }

    }

}
