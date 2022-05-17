using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Data
{
    public class ScheduleDay
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        private ObjectId _id { get; set; }
        public ObjectId Id { get => _id; }
        public string DayName { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
