using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Linq;
using System;

namespace web.Models.News
{
    public class NewsNoSQL
    {
        public List<News> imgData;

        public void StartNewsNoSQL()
        {
            try
            {
                string connectionString =
                    @"mongodb://museum-of-telepuzyr-no-sql:qtdTplvAWoIuGz4ho4pPoBAQ9oB5HtyoNZ6JIuwFRzpaDGNncWgpAeReFaU7MiFOOF8a3oUoLeN1miL9ddr2bA==@museum-of-telepuzyr-no-sql.mongo.cosmos.azure.com:10255/?ssl=true&replicaSet=globaldb&maxIdleTimeMS=120000&appName=@museum-of-telepuzyr-no-sql@";
                MongoClientSettings settings = MongoClientSettings.FromUrl
                (
                  new MongoUrl(connectionString)
                );

                settings.SslSettings = new SslSettings()
                {
                    EnabledSslProtocols = SslProtocols.Tls12
                };
                var mongoClient = new MongoClient(settings);
                var mongoCollection = mongoClient.GetDatabase("museum-of-telepuzyr-db").GetCollection<BsonDocument>("museum-of-telepuzyr-collection");
                imgData = new List<News>();
                foreach (BsonDocument doc in mongoCollection.AsQueryable().Select(x => x).ToList())
                {
                    imgData.Add(new News()
                    {
                        Id = doc.GetValue("_id").ToString(),
                        NameOfNews = doc.GetValue("Name").ToString(),
                        DescriptionOfNews = doc.GetValue("Decription").ToString(),
                        LinkOfNews = doc.GetValue("Link").ToString(),
                        DateCreationOfNews = doc.GetValue("Date").ToString()
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n-----------------\n Error to connect with NoSQL DB");
                Console.WriteLine(e.ToString());
                Console.WriteLine("\n-----------------\n");
            }
        }
    }
}