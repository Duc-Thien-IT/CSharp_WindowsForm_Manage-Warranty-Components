using DAL;
using DTO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class ConponentBLL
	{
		private ConponentDAL _conponentDAL;
		private ConponentDTO _conponentDTO = new ConponentDTO();

		public ConponentBLL()
		{
			_conponentDAL = new ConponentDAL();
		}

		private readonly IMongoCollection<ConponentDTO> _products;

		public ConponentBLL(IMongoCollection<ConponentDTO> products)
		{
			_products = products;
		}

		public List<ConponentDTO> GetAllProducts()
		{
			return _conponentDAL.GetAllProducts();
		}

		public ConponentDTO GetProductById(string productId)
		{
			return _conponentDAL.GetProductById(productId);
		}

		public void AddProduct(ConponentDTO product)
		{
			_conponentDAL.AddProduct(product);
		}

		public void UpdateProduct(ConponentDTO product)
		{
			_conponentDAL.UpdateProduct(product);
		}

		public bool DeleteProduct(string productId)
		{
			return _conponentDAL.DeleteProduct(productId);
		}

		public List<string> GetAllProductNames()
		{
			return _conponentDAL.GetAllProductNames();
		}

		public List<ConponentDTO> GetProductsByName(string productName)
		{
			return _conponentDAL.GetProductsByName(productName);
		}
	}
}
