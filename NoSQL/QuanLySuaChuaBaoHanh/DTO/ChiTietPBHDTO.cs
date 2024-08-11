using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPBHDTO
    {
        public class ChiTietPBH
        {
            [BsonElement("MaCTPBH")]
            public string MaCTPBH { get; set; }

            [BsonElement("MaLK")]
            public string MaLK { get; set; }

            [BsonElement("ThoiGianBH")]
            public string ThoiGianBH { get; set; }

            [BsonElement("GiaTien")]
            public string GiaTien { get; set; } 

            [BsonElement("TrangThai")]
            public string TrangThai { get; set; }
        }

    }
}
