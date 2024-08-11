using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DTO
{
	public class CustomerDTO
	{

		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

		[BsonElement("MaKH"), BsonRepresentation(BsonType.String)]
		public string MaKhachHang { get; set; }

		[BsonElement("TenKH"), BsonRepresentation(BsonType.String)]
		public string TenKhachHang { get; set; }

		[BsonElement("DiaChi"), BsonRepresentation(BsonType.String)]
		public string DiaChi { get; set; }

		[BsonElement("Phai"), BsonRepresentation(BsonType.String)]
		public string GioiTinh { get; set; }

		[BsonElement("SDT"), BsonRepresentation(BsonType.String)]
		public string SDT { get; set; }
        [BsonElement("PBH")]
        public List<WarrantyDTO> PBH { get; set; } = new List<WarrantyDTO>();
        public void GenerateMaKhachHang()
		{
			if (!string.IsNullOrEmpty(Id))
			{
				// Lấy 3 ký tự cuối của ID
				string lastThreeIdChars = Id.Substring(Id.Length - 3);
				// Tạo mã khách hàng
				MaKhachHang = $"KH{lastThreeIdChars}";
			}
		}
    }
}
