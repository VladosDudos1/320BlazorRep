﻿using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Data
{
    public class GridFSService
    {
        FileInfo file;
        const string conectionString = "mongodb://localhost";

        public void UploadImageToDB()
        {
            MongoClient client = new MongoClient(conectionString);
            IMongoDatabase database = client.GetDatabase("Images");
            IGridFSBucket gridFs = new GridFSBucket(database);

            using (FileStream fs = new FileStream("E:/repos/BlazorProject/BlazorProject/wwwroot/boot.jpg", FileMode.Open))
            {
                gridFs.UploadFromStream("qqq.jpg", fs);
            }
        }

        public async Task UploadImageToDBAsync(Stream stream)
        {
            MongoClient client = new MongoClient(conectionString);
            IMongoDatabase database = client.GetDatabase("Images");
            IGridFSBucket gridFs = new GridFSBucket(database);
            await gridFs.UploadFromStreamAsync("sss.jpg", stream);
        }

        public void DownloadImageToWWWRoot(string filename)
        {
            MongoClient client = new MongoClient(conectionString);
            IMongoDatabase database = client.GetDatabase("Images");
            IGridFSBucket gridFs = new GridFSBucket(database);

            using (Stream fs = new FileStream($"E:/repos/ITParkBlazorApp/BlazorApp4/wwwroot/{filename}.jpg", FileMode.CreateNew))
            {
                gridFs.DownloadToStreamByName("qqq.jpg", fs);
                file = new FileInfo("boot.jpg");
                Console.WriteLine(file.DirectoryName);
                //*пример с получением id файла и выгрузка из БД по id*
                //var filter = Builders<GridFSFileInfo>.Filter.Eq(x => x.Filename, "qqq.jpg");
                //var gridFileInfo = gridFs.Find(filter).FirstOrDefault();
                //gridFs.DownloadToStream(gridFileInfo.Id, fs);

                //*получение всех имен файлов из GridFS привязанных к базе Images*
                //var ff= gridFs.Find(Builders<GridFSFileInfo>.Filter.Empty).ToList();
                // foreach(var item in ff)
                // {
                //     Console.WriteLine(item.Filename);
                // }
            }
        }
    }
}
