using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{ 
	public class WarrantyDTO
	{

		[BsonElement("MaPBH"), BsonRepresentation(BsonType.String)]
		public string MaPBH { get; set; }

		[BsonElement("NgayLapPhieu"), BsonRepresentation(BsonType.String)]
		public DateTime NgayLapPhieu { get; set; }

		[BsonElement("TongTien"), BsonRepresentation(BsonType.String)]
		public long TongTien { get; set; }
        [BsonElement("ChiTietPBH")]
        public List<ChiTietPBHDTO> ChiTietPBH { get; set; }
        

        public WarrantyDTO()
		{
			MaPBH = GenerateWarrantyCode();

		}
		
		private string GenerateWarrantyCode()
		{
			const string prefix = "BH";
			string objectId = ObjectId.GenerateNewId().ToString();
			string lastThreeIdChars = objectId.Substring(objectId.Length - 3);

			return prefix + lastThreeIdChars;
		}

	}
}
