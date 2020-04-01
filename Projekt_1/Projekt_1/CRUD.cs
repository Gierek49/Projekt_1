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
    public class CRUD
    {
        /// <summary>
        /// Wywołanie funcji Update to kanałyt UpdateToKanaly
        /// <param name="toKanaly"></param>
        /// <param name="filter"></param>
       public static void UpdateToKanaly(Kanaly toKanaly,Kanaly filter)
        {
            MongoCRUD db = new MongoCRUD("RSS");
            db.UpdateItem("Kanaly",toKanaly,filter);
        }
        /// <summary>
        /// Wywołanie funkcji InsertToKanaly
        /// </summary>
        /// <param name="insertToKanaly"></param>
        public static void InsertToKanaly(Kanaly insertToKanaly)
        {
            MongoCRUD db = new MongoCRUD("RSS"); 
            db.InsertRecord("Kanaly",insertToKanaly);
        }
        /// <summary>
        ///  Wywołanie funcji Update to kanałyt LoadKanaly
        /// </summary>
        /// <returns></returns>
        public static List<Kanaly> LoadKanaly()
        {
            MongoCRUD db=new MongoCRUD("RSS");
           var loadkanaly= db.LoadRecords<Kanaly>("Kanaly");

           return loadkanaly;
        }
        /// <summary>
        ///  Wywołanie funcji Update to kanałyt LoadOneKanal
        /// </summary>
        /// <param name="kanal"></param>/
        /// <returns></returns>
        public static List<Kanaly> LoadOneKanal(string kanal)
        {
            MongoCRUD db = new MongoCRUD("RSS");
            var load = db.LoadRecord<Kanaly>("Kanly", kanal);

            return load;
        }
    }
}
