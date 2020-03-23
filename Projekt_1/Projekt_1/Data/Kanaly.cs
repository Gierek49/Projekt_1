using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_1.Data
{
    class Kanaly
    {
        public int _id;
        public string Kanal;
        public string link;
       public List<XmlItems> item;

        public Kanaly(int id, string kanal, string link, List<XmlItems> item)
        {
            _id = id;
            Kanal = kanal;
            this.link = link;
            this.item = item;
        }
    }
}
