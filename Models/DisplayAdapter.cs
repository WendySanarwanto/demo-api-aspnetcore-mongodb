using MongoDB.Bson.Serialization.Attributes;

namespace com.wendysa.apidemo.Models
{
    public class DisplayAdapter : SparePart
    {
        [BsonElement("chipset")]
        public string Chipset{ set; get; }

        [BsonElement("memorySize")]
        public string MemorySize{ set; get; }
    }
}