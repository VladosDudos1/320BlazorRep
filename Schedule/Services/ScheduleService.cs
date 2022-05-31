using MongoDB.Driver;
using Schedule.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Schedule.Services
{
    public class ScheduleService
    {
        public static MongoClient client = new MongoClient("mongodb://localhost");
        public static MongoDatabaseBase database = (MongoDatabaseBase)client.GetDatabase("Schedule");

        public List<ScheduleDay> GetSchedule()
        {
            var schedule = (MongoCollectionBase<ScheduleDay>)database.GetCollection<ScheduleDay>("Schedule");
            return schedule.Find(x => true).ToList();
        }

        public List<string> GetDays()
        {
            return Enumerable.Range(0, 7).Select(i => ((DayOfWeek)i).ToString()).ToList();
        }

        public void SaveScheduleDay(ScheduleDay day)
        {
            var schedule = (MongoCollectionBase<ScheduleDay>)database.GetCollection<ScheduleDay>("Schedule");
            if (GetSchedule().FirstOrDefault(x => x.Id == day.Id) != null)
            {
                var filter = Builders<ScheduleDay>.Filter.Eq(s => s.Id, day.Id);
                schedule.ReplaceOneAsync(filter, day);
            }
            else
                schedule.InsertOneAsync(day);
        }

        public void DeleteSubject(ScheduleDay day, Subject subject)
        {
            day.Subjects.Remove(subject);
            SaveScheduleDay(day);
        }

        public ScheduleDay GetScheduleDay(string day)
        {
            return GetSchedule().FirstOrDefault(x => x.DayName == day);
        }

        public Subject AddNewSubject(ScheduleDay day)
        {
            Subject subject = new Subject();

            day.Subjects.Add(subject);
            SaveScheduleDay(day);

            return subject;
        }
    }
}
