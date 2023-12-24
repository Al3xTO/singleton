using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLib
{
    public class Document
    {
        public int DocId { get; set; }
        public string DocName { get; set; }
        public string DocDescr { get; set; }

        public Document (int Id, string Name, String Descr) 
        { 
            DocId = Id;
            DocName = Name;
            DocDescr = Descr;
        }
    }
}
