using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TimeTable
{
    public class TimeTableDay
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        private ObjectId _id { get; set; }
        public ObjectId Id { get { return _id; } }
        public string DayName { get; set; }
        public List<Subject> Subjects { get; set; }
        public TimeTableDay()
        {
            DayName = "";
            Subjects = new List<Subject>();

        }
    }
}
