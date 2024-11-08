using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProductListWithCart.Application.Models
{
    public class DessertItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("image")]
        public Image? Image { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("category")]
        public string? Category { get; set; }

        [BsonElement("price")]
        public decimal? Price { get; set; }
    }
}
