using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace com.wendysa.apidemo.Models {
    public class Pc {
        [BsonElement("cpu")]
        public Cpu Cpu{ set; get; }

        [BsonElement("motherboard")]
        public Motherboard Motherboard{ set; get; }

        [BsonElement("memory")]
        public Ram Memory{ set; get; }

        [BsonElement("storages")]
        public IEnumerable<FixedDrive> Storage{ set; get; }

        [BsonElement("gpu")]
        public DisplayAdapter Gpu{ set; get; }

        [BsonElement("casing")]
        public Casing Casing{ set; get; }

        [BsonElement("PSU")]
        public PowerSupply Psu{ set; get; }

        [BsonElement("keyboard")]
        public Keyboard Keyboard{ set; get; }

        [BsonElement("mouse")]
        public Mouse Mouse{ set; get; }

        [BsonElement("display")]
        public DisplayScreen Display{ set; get; }
    }
}
