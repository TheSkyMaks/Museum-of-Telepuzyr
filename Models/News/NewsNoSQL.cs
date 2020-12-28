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
                string connectionString = "";
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
                        NameOfNews = doc.GetValue("NameOfNews").ToString(),
                        DescriptionOfNews = doc.GetValue("Description").ToString(),
                        LinkOfArt = doc.GetValue("LinkOfArt").ToString(),
                        LinkOfNews = doc.GetValue("LinkOfNews").ToString(),
                        DateCreationOfNews = doc.GetValue("DateCreationOfNews").ToString()
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}