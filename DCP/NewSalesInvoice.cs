using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP
{
    public interface IPrinter
    {
        void Print();
    }

    public class SalesInvoicePrinter: IPrinter
    {
        public void Print()
        {
        }
    }

    public class SalesInvoiceFail : IPrinter
    {
        public void Print()
        {
        }
    }

    public class Printerer
    {
        private readonly IPrinter _printerer;
        public Printerer()
        {
            _printerer = new SalesInvoicePrinter();
        }
        public void DoPrint()
        {
            _printerer.Print();
        }
    }
}
