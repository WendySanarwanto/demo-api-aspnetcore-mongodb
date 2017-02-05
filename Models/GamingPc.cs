using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace com.wendysa.apidemo.Models{
    public class GamingPc {
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { set; get; }

        [BsonElement("price")]
        public decimal Price { set; get;}

        [BsonElement("inStock")]
        public bool InStock { set; get; }

        [BsonElement("specs")]
        public Pc Specs { set; get; }
    }    
}