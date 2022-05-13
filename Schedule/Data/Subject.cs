using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Schedule.Data
{
    public class Subject
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        private ObjectId _id { get; set; }
        public ObjectId Id { get { return _id; } }
        public string Name { get; set; }
        public string Teacher { get; set; }
    }
}