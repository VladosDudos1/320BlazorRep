﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorProject.Data
{
    public class Timetable
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        public string NameTeacher { get; set; }
        public string Subject { get; set; }
        public string Classroom { get; set; }
    }
}
