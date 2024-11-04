using MongoDB.Bson;
using MongoDB.Driver;
using ProductListWithCart.Application.Interfaces;

namespace ProductListWithCart.DataAccess.Context
{
    internal class MenuContext : IMenuContext
    {
        private readonly IMongoDatabase db;
        public MenuContext(string dbName, string connectionString)
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
