using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP
{
    public class SalesInvoice
    {
        public void Print() 
        {
        }
    }

    public class Printered 
    {
        private SalesInvoice salesInvoice;
        public Printered() 
        {
            salesInvoice = new SalesInvoice();
        }
        public void SalesInvoicePrint() 
        {
            salesInvoice.Print();
        }
    }
}
