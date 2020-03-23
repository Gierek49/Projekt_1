using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Projekt_1.Data;
using Projekt_1.Downloading;


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
