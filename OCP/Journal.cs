using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Journal
    {
            public int Id { get; set; }
            public string Name { get; set; }

            public void Add(Journal journal)
            {
                //add record into magazine
            }
        }

        public class JournalReport
    {
            public string TypeReport { get; set; }
            public void Report(Journal journal)
            {
                if (TypeReport=="pdf") 
                {
                    //create report about magazine in pdf format
                }
                if (TypeReport == "txt")
                {
                    //create report about magazine in txt format
                }
            //create report about magazine in xml format
        }
    }
}
