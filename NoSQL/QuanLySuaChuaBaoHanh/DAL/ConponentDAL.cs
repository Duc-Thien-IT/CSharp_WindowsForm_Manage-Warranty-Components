using DTO;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class ConponentDAL
	{
		private MongoConnection _connection;
		private IMongoCollection<ConponentDTO> _productsCollection;

		public ConponentDAL()
		{
			_connection = new MongoConnection();
			var database = _connection.GetMongoClient().GetDatabase("QLBH");
			_productsCollection = database.GetCollection<ConponentDTO>("Components");
		}

		public List<ConponentDTO> GetAllProducts()
		{
			return _productsCollection.Find(new BsonDocument()).ToList();
		}

		public ConponentDTO GetProductById(string productId)
		{
			var filter = Builders<ConponentDTO>.Filter.Eq(p => p.Id, productId);
			return _productsCollection.Find(filter).FirstOrDefault();
		}

		public void AddProduct(ConponentDTO product)
		{
			_productsCollection.InsertOne(product);
		}

		public void UpdateProduct(ConponentDTO product)
		{
			var filter = Builders<ConponentDTO>.Filter.Eq(p => p.Id, product.Id);
			_productsCollection.ReplaceOne(filter, product);
		}

		public bool DeleteProduct(string productId)
		{
			var result = _productsCollection.DeleteOne(p => p.Id == productId);
			return result.DeletedCount > 0;
		}

		public List<string> GetAllProductNames()
		{
			return _productsCollection.Find(new BsonDocument())
									  .Project(p => p.TenLK)
									  .ToList();
		}

		// Thêm hàm tìm kiếm linh kiện theo tên
		public List<ConponentDTO> GetProductsByName(string productName)
		{
			var filter = Builders<ConponentDTO>.Filter.Regex(p => p.TenLK, new BsonRegularExpression(productName, "i"));
			return _productsCollection.Find(filter).ToList();
		}
	}
}
