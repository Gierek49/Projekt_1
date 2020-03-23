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
        static void InsertToKanaly(Kanaly toKanaly)
        {

            MongoCRUD db = new MongoCRUD("RRS");

            db.InsertRecord("Kanaly ",toKanaly);

            Console.ReadLine();
        }
    }
}
