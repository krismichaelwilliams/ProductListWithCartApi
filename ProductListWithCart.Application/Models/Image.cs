using MongoDB.Bson.Serialization.Attributes;

namespace ProductListWithCart.Application.Models
{
    public class Image
    {
        [BsonElement("thumbnail")]
        public string? Thumbnail { get; set; }

        [BsonElement("mobile")]
        public string? Mobile { get; set; }

        [BsonElement("tablet")]
        public string? Tablet { get; set; }

        [BsonElement("desktop")]
        public string? Desktop { get; set; }
    }
}