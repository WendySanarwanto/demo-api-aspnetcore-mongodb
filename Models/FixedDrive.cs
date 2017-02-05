using MongoDB.Bson.Serialization.Attributes;

namespace com.wendysa.apidemo.Models
{
    public class FixedDrive : SparePart
    {
        [BsonElement("type")]
        public string Type{ set; get; }

        [BsonElement("subtype")]
        public string SubType{ set; get; }  

        [BsonElement("capacity")]
        public string Capacity{ set; get; }      
    }
}