using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public abstract class Journal
    {
        public virtual bool Add(int id)
        {
            return false;
        }

        public virtual bool EnterBasedTaxInvoice(int id)
        {
            return false;
        }
    }

    public class SalesInvoice : Journal
    {
        public override bool Add(int id)
        {
            return true;
        }

        public override bool EnterBasedTaxInvoice(int id)
        {
            return true;
        }
    }

    public class WayBillInvoice : Journal
    {
        public override bool Add(int id)
        {
            return true;
        }

        //TaxInvoice do not create entered based on WayBillInvoce
        public override bool EnterBasedTaxInvoice(int id)
        {
            throw new NotImplementedException();
        }
    }
}
