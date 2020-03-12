using ISP;
using LCP;
using System;
using System.Collections.Generic;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Journal> journals = new List<Journal>();
            //journals.Add(new WayBillInvoice());
            //foreach (Journal jour in journals)
            //{
            //    jour.EnterBasedTaxInvoice(15);
            //}


            //Liskov
            Car cars = new SportCar();
            TestSpeed(cars);
            //cars.MaxSpeedMile = 300;

        }

        public static void TestSpeed(Car cars) 
        {
            cars.MaxSpeedMile = 300;
            if (cars.SpeedKM() != 480)
                throw new Exception("Invalid max speed!");
        }
    }
}
