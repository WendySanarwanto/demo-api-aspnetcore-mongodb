using MongoDB.Bson.Serialization.Attributes;

namespace com.wendysa.apidemo.Models
{
    public class CpuHeatsink : SparePart
    {
        [BsonElement("type")]
        public string Type{ set; get; }
    }
}