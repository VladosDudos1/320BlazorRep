using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RaspisanieZilya.Data
{
    public class Raspisanie
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public string Subject { get; set; }
        public string Teacher { get; set; }
        public string Classroom { get; set; }
    }
}
