using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Schedule
{
    public class TimeTableDay
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        private ObjectId _id { get; set; }
        public ObjectId Id { get { return _id; } }
        public string DayName { get; set; }
        public List<Subject> Subjects { get; set; }

    }
}
