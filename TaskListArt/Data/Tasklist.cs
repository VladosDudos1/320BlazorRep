using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TaskListArt.Data
{
	public class Tasklist
	{
		[BsonId]
		[BsonIgnoreIfDefault]
		public ObjectId Id { get; set; }
		public string Teacher { get; set; }
		public string Object { get; set; }
		public string Classroom { get; set; }
	}
}
