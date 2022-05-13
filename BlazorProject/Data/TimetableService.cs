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

        public static async Task<List<Timetable>> GetItem(string searchDay)
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
    }
}
