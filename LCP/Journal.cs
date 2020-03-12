using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP
{
    //public class Journal
    //{
    //    public string Text { get; set; }
    //    public Journal  (string Text) 
    //    {
    //        Text = this.Text;
    //    }
    //}

    //public class PurchaseInvoice : Journal
    //{
    //    public string Name { get; set; }
    //    public PurchaseInvoice (string Name, string Text): base(Text) 
    //    {
    //        Name = this.Name;
    //    }
    //}

    //public class SalesInvoice : PurchaseInvoice
    //{
    //    public int Number { get; set; }
    //    public SalesInvoice (string Text, string Name, int Number): base(Name, Text)
    //    {
    //        Number = this.Number;
    //    }
    //    public string Name 
    //    {
    //        set { Name = Name; }
    //        get { return Name; }
    //    }

    //}
    public class Car 
    {
        public virtual double MaxSpeedMile { get; set; }
        public double SpeedKM ()
        {
            return MaxSpeedMile * 1.6;
        }
    }

    public class SportCar : Car
    {
        public override double MaxSpeedMile 
        {
            get => base.MaxSpeedMile; 
            set => base.MaxSpeedMile = value;
        }
    }
}
