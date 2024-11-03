using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductListWithCart.Domain;

namespace ProductListWithCart.DataAccess.Wrappers
{
    internal class MongoDriverWrapper : IMongoDriverWrapper
    {
        private IMongoDatabase db;

        public MongoDriverWrapper(string dbName, string connectionString)
        {
            var client = new MongoClient(connectionString);
            db = client.GetDatabase(dbName);
        }

        public List<T> GetDesserts<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }
    }
}
