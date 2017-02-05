using MongoDB.Bson.Serialization.Attributes;

namespace com.wendysa.apidemo.Models
{
    public class PowerSupply : SparePart
    {
        [BsonElement("wattage")]
        public int Wattage{ set; get; }
    }
}