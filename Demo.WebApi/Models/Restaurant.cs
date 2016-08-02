using MongoDB.Bson.Serialization.Attributes;

namespace Demo.WebApi.Models
{
    [BsonIgnoreExtraElements]
    public class Restaurant
    {
        [BsonElement("address")]
        public Address Address;
        [BsonElement("name")]
        public string Name;
        [BsonElement("restaurant_id")]
        public string RestaurantId;
    }

    [BsonIgnoreExtraElements]
    public class Address
    {
        [BsonElement("building")]
        public string Building;
        [BsonElement("street")]
        public string Street;
        [BsonElement("zipcode")]
        public string ZipCode;
    }
}