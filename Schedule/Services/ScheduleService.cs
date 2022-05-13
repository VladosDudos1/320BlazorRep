using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Schedule.Data;

namespace Schedule.Services
{
    public class ScheduleService
    {
        public static MongoClient client = new MongoClient("mongodb://localhost");
        public static MongoDatabaseBase database = (MongoDatabaseBase)client.GetDatabase("Schedule");

        public static List<ScheduleDay> GetSchedule()
        {
            var schedule = (MongoCollectionBase<ScheduleDay>)database.GetCollection<ScheduleDay>("Schedule");
            return schedule.Find(x => true).ToList();
        }
        public static List<string> GetDays()
        {
            return GetSchedule().Select(x => x.DayName).ToList();
        }

        public static void SaveTimeTableDay(ScheduleDay day)
        {
            var timeTable = (MongoCollectionBase<ScheduleDay>)database.GetCollection<ScheduleDay>("Schedule");
            if (GetSchedule().FirstOrDefault(x => x.Id == day.Id) != null)
            {
                var filter = Builders<ScheduleDay>.Filter.Eq(s => s.Id, day.Id);
                timeTable.ReplaceOneAsync(filter, day);
            }
            else
                timeTable.InsertOneAsync(day);
        }
        public static ScheduleDay GetTimeTableDay(string day)
        {
            return GetSchedule().FirstOrDefault(x => x.DayName == day);
        }
    }
}
