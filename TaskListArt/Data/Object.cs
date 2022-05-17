using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TaskListArt.Data
{
	public class Object
	{
		[BsonId]
		[BsonIgnoreIfDefault]
		private ObjectId id { get; set; }
		public ObjectId Id { get { return id; } }
		public string Name { get; set; }
		public string Teacher { get; set; }
	}
}
