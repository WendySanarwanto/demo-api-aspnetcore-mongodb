using MongoDB.Bson.Serialization.Attributes;

namespace com.wendysa.apidemo.Models
{
    public class Motherboard : SparePart
    {
        [BsonElement("chipset")]
        public string Chipset{ set; get; }        
    }
}