using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace DTO
{
	public class UserDTO
	{
		[BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

		[BsonElement("Account"), BsonRepresentation(BsonType.String)]
		public string Account { get; set; }

		[BsonElement("Pass"), BsonRepresentation(BsonType.String)]
		public string PassWord { get; set; }

		[BsonElement("Role"), BsonRepresentation(BsonType.String)]
		public string Role { get; set; }

		[BsonElement("DiaChi"), BsonRepresentation(BsonType.String)]
		public string DiaChi { get; set; }

		[BsonElement("HoTen"), BsonRepresentation(BsonType.String)]
		public string HoTen { get; set; }

		[BsonElement("NgaySinh"), BsonRepresentation(BsonType.String)]
		public string NgaySinh { get; set; }

		[BsonElement("Phai"), BsonRepresentation(BsonType.String)]
		public string Phai { get; set; }

		[BsonElement("SDT"), BsonRepresentation(BsonType.String)]
		public string SDT { get; set; }

		[BsonElement("KhachHang")]
		public List<string> KhachHang { get; set; } = new List<string>();
	}
}
