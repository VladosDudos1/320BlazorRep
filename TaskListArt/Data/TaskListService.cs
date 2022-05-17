using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace TaskListArt.Data
{
	public class TaskListService
	{
		public static List<string> GetDay()
		{
			var client = new MongoClient("mongodb://localhost");
			var db = client.GetDatabase("TimeTable");
			return db.ListCollectionNames().ToList();
		}
		public static async Task<List<Tasklist>> GetItem(string searchDay)
		{
			var client = new MongoClient("mongodb://localhost");
			var db = client.GetDatabase("TimeTable");
			if (db.ListCollectionNames().ToList().Exists(x => x == searchDay))
			{
				if (string.IsNullOrEmpty(searchDay))
				{
					return null;
				}
				else
				{
					var collection = db.GetCollection<Tasklist>(searchDay);
					return await collection.Find(x => true).ToListAsync();
				}
			}
			else 
			{
				return null;
			}


		}
	}
}
