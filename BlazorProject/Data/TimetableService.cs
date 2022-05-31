using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace BlazorProject.Data
{
    public class TimetableService
    {
        public static List<string> GetDay()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Timetable");
            return database.ListCollectionNames().ToList();
        }

        public static async Task<List<Timetable>> GetItemAsync(string searchDay)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Timetable");
            if (database.ListCollectionNames().ToList().Exists(x => x == searchDay))
            {
                if (string.IsNullOrEmpty(searchDay))
                    return null;
                else
                {
                    var collection = database.GetCollection<Timetable>(searchDay);
                    return await collection.Find(x => true).ToListAsync();
                }
            }
            else
                return null;
        }

        public static List<Timetable> GetItem(string searchDay)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Timetable");
            if (database.ListCollectionNames().ToList().Exists(x => x == searchDay))
            {
                if (string.IsNullOrEmpty(searchDay))
                    return null;
                else
                {
                    var collection = database.GetCollection<Timetable>(searchDay);
                    return collection.Find(x => true).ToList();
                }
            }
            else
                return null;
        }

        public static void AddItem(Timetable item, string day)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Timetable");
            var collection = database.GetCollection<Timetable>(day);
            if (database.ListCollectionNames().ToList().Exists(x => x == day))
            {
                collection.InsertOne(item);
            }
        }

        public static void RemoveItem(Timetable item, string day)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Timetable");
            var collection = database.GetCollection<Timetable>(day);
            if (database.ListCollectionNames().ToList().Exists(x => x == day))
            {
                collection.DeleteOne(a => a.Id == item.Id);
            }
        }
    }
}
