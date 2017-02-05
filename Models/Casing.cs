using MongoDB.Bson.Serialization.Attributes;

namespace com.wendysa.apidemo.Models
{
    public class Casing : SparePart
    {
        [BsonElement("formFactor")]
        public string FormFactor{ set; get; }
    }
}