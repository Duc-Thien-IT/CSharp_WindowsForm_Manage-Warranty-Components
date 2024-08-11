using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class ConponentDTO
	{
		[BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

		[BsonElement("MaLK"), BsonRepresentation(BsonType.String)]
		public string MaLK { get; set; }

		[BsonElement("TenLK"), BsonRepresentation(BsonType.String)]
		public string TenLK { get; set; }

		[BsonElement("Hang"), BsonRepresentation(BsonType.String)]
		public string Hang { get; set; }

		[BsonElement("Gia"), BsonRepresentation(BsonType.String)]
		public string Gia { get; set; }

	}
}
