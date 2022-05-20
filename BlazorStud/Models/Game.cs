using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStud.Models
{
    public class Game
    {
       
        public Game(string name, string genre, DateTime releaseDate)
        {
            Name = name;
            Genre = genre;
            ReleaseDate = releaseDate;
        }

        public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

        public static async void UpdateOne()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("qqq");
            var collection = database.GetCollection<Game>("rrr");
            await collection.UpdateOneAsync(x => x.Name == "qq", Builders<Game>.Update.Set(x=>x.Genre, "RTS"));

        }
        public static List<Game> SimpleList()
        {
            return new List<Game>()
            {
                new Game("farm","strategy", new DateTime(2019, 12, 15)),
                 new Game("piupiy","strategy", new DateTime(2019, 12, 15)),
                  new Game("crudge","strategy", new DateTime(2019, 12, 15))
            };
        }
    }
}
