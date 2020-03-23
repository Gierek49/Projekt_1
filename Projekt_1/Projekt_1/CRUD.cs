using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Atributes;
using MongoDB.Driver;
using Data;
using Downloading;


namespace Projekt_1
{
    class CRUD
    {
        static void Main(string[] args)
        {

            MongoCRUD db = new MongoCRUD("RRS");

            ChannelModel chanel = new ChannelModel

            {
                kanal = "",
                link = "",
                channelinfo = new Channelinfo
                {
                    title = "",
                    link = "",
                    description = "",
                    guid = "",
                    text = ""
                }
            };
            db.InsertRecord("Kanaly ", chanel);
            Console.ReadLine();
        }
    }

    public class ChannelModel
    {
        [BsonId]

        public Guid Id { get; set; }

        public string kanal { get; set; }

        public string link { get; set; }

        public List item { get; set; }

        public Channelinfo channelinfo { get; set; }
    }
    public class Channelinfo
    {
        public string title { get; set; }

        public string link { get; set; }

        public string description { get; set; }

        public string guid { get; set; }

        public string text { get; set; }
    }

    public class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T recprd)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }
    }
}
