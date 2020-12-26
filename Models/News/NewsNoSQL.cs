using MongoDB.Driver;
using System.Collections.Generic;
using System.Security.Authentication;

namespace web.Models.News
{
    public class NewsNoSQL
    {
        public List<News> imgData;

        public void StartNewsNoSQL()
        {
            /*
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
            */
        }
    }
}