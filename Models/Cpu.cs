using MongoDB.Bson.Serialization.Attributes;

namespace com.wendysa.apidemo.Models {
    public class Cpu : SparePart{
        [BsonElement("clock")]
        public string Clock{ set; get; }

        [BsonElement("socket")]
        public string Socket{ set; get; }

        [BsonElement("heatsink")]
        public CpuHeatsink Heatsink{ set; get; }        
    }
}