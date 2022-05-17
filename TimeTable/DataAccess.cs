using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;


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
        public static List<string> GetDays()
        {
            return GetTimeTable().Select(x => x.DayName).ToList();
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
        public static TimeTableDay GetTimeTableDay(string day)
        {
            return GetTimeTable().FirstOrDefault(x => x.DayName == day);
        }
    }
}
