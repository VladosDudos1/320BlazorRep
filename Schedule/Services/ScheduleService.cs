using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Schedule.Services
{
    public class ScheduleService
    {
        public static MongoClient client = new MongoClient("mongodb://localhost");
        public static MongoDatabaseBase database = (MongoDatabaseBase)client.GetDatabase("TimeTable");

        public List<TimeTableDay> GetSchedule()
        {
            var schedule = (MongoCollectionBase<TimeTableDay>)database.GetCollection<TimeTableDay>("TimeTable");
            return schedule.Find(x => true).ToList();
        }

        public List<string> GetDays()
        {
            return Enumerable.Range(0, 7).Select(i => ((DayOfWeek)i).ToString()).ToList();
        }

        public void SaveScheduleDay(TimeTableDay day)
        {
            var schedule = (MongoCollectionBase<TimeTableDay>)database.GetCollection<TimeTableDay>("TimeTable");
            if (GetSchedule().FirstOrDefault(x => x.Id == day.Id) != null)
            {
                var filter = Builders<TimeTableDay>.Filter.Eq(s => s.Id, day.Id);
                schedule.ReplaceOneAsync(filter, day);
            }
            else
                schedule.InsertOneAsync(day);
        }

        public void DeleteSubject(TimeTableDay day, Subject subject)
        {
            day.Subjects.Remove(subject);
            SaveScheduleDay(day);
        }

        public TimeTableDay GetScheduleDay(string day)
        {
            return GetSchedule().FirstOrDefault(x => x.DayName == day);
        }

        public Subject AddNewSubject(TimeTableDay day)
        {
            Subject subject = new Subject();

            day.Subjects.Add(subject);
            SaveScheduleDay(day);

            return subject;
        }
    }
}
