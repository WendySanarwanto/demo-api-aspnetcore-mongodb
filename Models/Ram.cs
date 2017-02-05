using MongoDB.Bson.Serialization.Attributes;

namespace com.wendysa.apidemo.Models
{
    public class Ram : SparePart
    {
        [BsonElement("DDR")]
        public int DDR{ set; get; }

        [BsonElement("PC")]
        public int PC{ set; get; }

        [BsonElement("capacity")]
        public string Capacity{ set; get; }
    }
}