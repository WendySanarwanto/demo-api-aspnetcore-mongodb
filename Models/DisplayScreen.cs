using MongoDB.Bson.Serialization.Attributes;

namespace com.wendysa.apidemo.Models
{
    public class DisplayScreen : SparePart { 
        [BsonElement("screenSize")]
        public string ScreenSize{ set; get; }
    }
}