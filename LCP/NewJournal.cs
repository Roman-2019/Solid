using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP
{
    //public class NewJournal
    //{
    //    public string Text { get; set; }
    //    public NewJournal(string Text)
    //    {
    //        Text = this.Text;
    //    }
    //}

    //public class NewPurchaseInvoice : NewJournal
    //{
    //    public string Name { get; set; }
    //    public NewPurchaseInvoice(string Name, string Text) : base(Text)
    //    {
    //        Name = this.Name;
    //    }
    //}

    //public class NewSalesInvoice : NewJournal
    //{
    //    public int Number { get; set; }
    //    public string Name { get; set; }
    //    public NewSalesInvoice(string Text, int Number, string Name) : base(Text)
    //    {
    //        Number = this.Number;
    //        Name = this.Name;
    //    }


    //}
    public class Cars
    {
        public  double MaxSpeedMileCar { get; set; }
        public double SpeedKM()
        {
            return MaxSpeedMileCar * 1.6;
        }
    }

    public class SportCars
    {
        public double MaxSpeedMileSCar { get; set; }
        public double SpeedKM()
        {
            return MaxSpeedMileSCar * 2.1;
        }
    }
}
