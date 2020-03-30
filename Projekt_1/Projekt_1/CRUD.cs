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
        static void UpdateToKanaly(Kanaly toKanaly,Kanaly filter)
        {
            MongoCRUD db = new MongoCRUD("RSS");
            db.UpdateItem("Kanaly",toKanaly,filter);
        }

        static void InsertToKanaly(Kanaly insertToKanaly)
        {
            MongoCRUD db = new MongoCRUD("RSS"); 
            db.InsertRecord("Kanaly",insertToKanaly);
        }

        static List<Kanaly> LoadKanaly()
        {
            MongoCRUD db=new MongoCRUD("RSS");
           var loadkanaly= db.LoadRecords<Kanaly>("Kanaly");

           return loadkanaly;
        }

        static List<Kanaly> LoadOne(string kanal)
        {
            MongoCRUD db = new MongoCRUD("RSS");
            var load = db.LoadRecord<Kanaly>("Kanly", kanal);

            return load;
        }
    }
}
