using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MongoConnection
    {
        private IMongoClient _client;
        private IMongoDatabase _database;

        public IMongoClient GetMongoClient()
        {
            try
            {
                _client = new MongoClient("mongodb://localhost:27017");
                Console.WriteLine("Kết nối thành công");
                return _client;
            }
            catch (MongoConnectionException ex)
            {
                Console.WriteLine("Kết nối thất bại"+ ex.Message);
                throw;
            }
        }

        public IMongoDatabase GetDatabase()
        {
            return _database;
        }

     
    }
}
