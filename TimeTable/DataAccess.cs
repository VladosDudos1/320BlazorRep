using MongoDB.Driver;
using System.Linq;
using System.Collections.Generic;

namespace TimeTable
{
    public class DataAccess
    {
        public static MongoClient client = new MongoClient("mongodb://localhost");
        public static MongoDatabaseBase database = (MongoDatabaseBase)client.GetDatabase("TimeTable");

        public static List<TimeTableDay> GetTimeTable()
        {
            var timeTable = (MongoCollectionBase<TimeTableDay>)database.GetCollection<TimeTableDay>("TimeTable");
            return timeTable.Find(x => true).ToList();
        }

        public static void SaveTimeTableDay(TimeTableDay day)
        {
            var timeTable = (MongoCollectionBase<TimeTableDay>)database.GetCollection<TimeTableDay>("TimeTable");
            if (GetTimeTable().FirstOrDefault(x => x.Id == day.Id) != null)
            {
                var filter = Builders<TimeTableDay>.Filter.Eq(s => s.Id, day.Id);
                timeTable.ReplaceOneAsync(filter, day);
            }
            else
                timeTable.InsertOneAsync(day);
        }
    }
}
