using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Journal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Add(Journal magazine)
        {
            //add record into magazine
        }

        public void Report(Journal journal)
        {
            //create report about magazine
        }
    }
}
