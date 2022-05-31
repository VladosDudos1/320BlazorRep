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
        public ObjectId Id { get => _id; }
        public string DayName { get; set; }
        public List<Subject> Subjects { get; set; }

        public TimeTableDay()
        {
            Subjects = new List<Subject>();
        }

    }
}
