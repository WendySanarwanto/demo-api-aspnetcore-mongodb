using MongoDB.Bson.Serialization.Attributes;

namespace com.wendysa.apidemo.Models{
    public class SparePart {
        [BsonElement("model")]
        public string Model{ set; get; }

        [BsonElement("manufacturer")]
        public string manufacturer{ set; get; }        
    }
}