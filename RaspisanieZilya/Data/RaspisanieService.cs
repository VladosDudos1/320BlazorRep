using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace RaspisanieZilya.Data
{
    public class RaspisanieService
    {
        public static List<string> GetDay()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Raspisanie");
            return database.ListCollectionNames().ToList();
        }

        public static List<Raspisanie> GetItem(string searchDay)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Raspisanie");
            if (database.ListCollectionNames().ToList().Exists(x => x == searchDay))
            {
                if (string.IsNullOrEmpty(searchDay))
                    return null;
                else
                {
                    var collection = database.GetCollection<Raspisanie>(searchDay);
                    return collection.Find(x => true).ToList();
                }
            }
            else
                return null;
        }
    }
}
