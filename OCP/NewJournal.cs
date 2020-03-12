using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class NewJournal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Add(Journal journal)
        {
            //add record into magazine
        }
    }

    public class INewJournalReport
    {
        public virtual void CreateReport(Journal journal)
        {
        }
    }

    //create report about magazine in pdf format
    public class PDFReport : INewJournalReport
    {
        public override void CreateReport(Journal journal)
        {
            base.CreateReport(journal);
        }
    }

    //create report about magazine in txt format
    public class TXTReport : INewJournalReport
    {
        public override void CreateReport(Journal journal)
        {
            base.CreateReport(journal);
        }
    }

    //create report about magazine in xml format
    public class XMLReport : INewJournalReport
    {
        public override void CreateReport(Journal journal)
        {
            base.CreateReport(journal);
        }
    }
}
