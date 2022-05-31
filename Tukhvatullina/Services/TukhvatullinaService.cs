using MongoDB.Driver;
using Tukhvatullina.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tukhvatullina.Services
{
    public class TukhvatullinaService
    {
        public static MongoClient client = new MongoClient("mongodb://localhost");
        public static MongoDatabaseBase database = (MongoDatabaseBase)client.GetDatabase("Schedule");

        public List<TukhvatullinaDay> GetSchedule()
        {
            var schedule = (MongoCollectionBase<TukhvatullinaDay>)database.GetCollection<TukhvatullinaDay>("Schedule");
            return schedule.Find(x => true).ToList();
        }

        public List<string> GetDays()
        {
            return Enumerable.Range(0, 7).Select(i => ((DayOfWeek)i).ToString()).ToList();
        }

        public void SaveTukhvatullinaDay(TukhvatullinaDay day)
        {
            var schedule = (MongoCollectionBase<TukhvatullinaDay>)database.GetCollection<TukhvatullinaDay>("Schedule");
            if (GetSchedule().FirstOrDefault(x => x.Id == day.Id) != null)
            {
                var filter = Builders<TukhvatullinaDay>.Filter.Eq(s => s.Id, day.Id);
                schedule.ReplaceOneAsync(filter, day);
            }
            else
                schedule.InsertOneAsync(day);
        }

        public void DeleteSubject(TukhvatullinaDay day, Subject subject)
        {
            day.Subjects.Remove(subject);
            SaveTukhvatullinaDay(day);
        }

        public TukhvatullinaDay GetTukhvatullinaDay(string day)
        {
            return GetTukhvatullinaDay().FirstOrDefault(x => x.DayName == day);
        }

        public Subject AddNewSubject(TukhvatullinaDay day)
        {
            Subject subject = new Subject();

            day.Subjects.Add(subject);
            SaveTukhvatullinaDay(day);

            return subject;
        }
    }
}
