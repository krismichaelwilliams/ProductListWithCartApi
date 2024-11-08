using MongoDB.Driver;
using ProductListWithCart.Application.Interfaces;

namespace ProductListWithCart.DataAccess.Context
{
    public class MenuContext : IMenuContext
    {
        private readonly IMongoDatabase db;
        public MenuContext(string dbName, string connectionString)
        {
            var client = new MongoClient();
            db = client.GetDatabase(dbName);
        }

        public async Task<List<T>> GetDesserts<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            var result = await collection.Find(_ => true).ToListAsync();
            return result;
        }
    }
}
