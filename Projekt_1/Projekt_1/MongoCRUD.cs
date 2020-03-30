using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Projekt_1.Data;

namespace Projekt_1
{
    class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }
        public List<T> LoadRecord<T>(string table, string kanal)
        {
            var collection = db.GetCollection<T>(table);

            var filter = Builders<T>.Filter.Eq("Kanal",kanal);

            return collection.Find(filter).ToList();
        }

        public void UpdateItem(string table, Kanaly record, Kanaly fillter)
        {
            var collection = db.GetCollection<Kanaly>(table);

            var filter = Builders<Kanaly>.Filter.Eq("Kanal", fillter.Kanal);

            var uprecord = Builders<Kanaly>.Update.Set("item", record.item);

            var result = collection.UpdateOne(filter, uprecord);
        }




    }
}
