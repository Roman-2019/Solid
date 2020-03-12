using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IJournalAdd
    {
        bool Append(int id);
    }

    public interface IJournalEnterBasedTaxInvoice
    {
        bool EnterBasedTaxInvoice(int id);
    }

    public class NewSalesInvoice : IJournalAdd, IJournalEnterBasedTaxInvoice
    {
        public bool Append(int id)
        {
            return true;
        }

        public bool EnterBasedTaxInvoice(int id)
        {
            return true;
        }
    }

    public class NewWayBillInvoice : IJournalAdd
    {
        public bool Append(int id)
        {
            return true;
        }
    }
}
