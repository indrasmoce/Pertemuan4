using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Taxi
    {
        public string Drivername { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}  ", Drivername);
            Console.WriteLine("On Duty  : {0}  ", OnDuty);
            Console.WriteLine("Number Of Pasengger  : {0}  ", NumPassenger);
            Console.WriteLine();
        }

        public void PickupPasengger()
        {
            Console.WriteLine("{0} Sedang menjemput penumpang ", Drivername);
        }
        public void DropOffPasengger()
        {
            Console.WriteLine("{0} Selesai mengantar penumpang ", OnDuty);
        }
   

    }
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();
            taxi.Drivername = "Jono ";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;


            taxi.TaxiInfo();
            taxi.PickupPasengger();
            taxi.DropOffPasengger();

            Console.ReadKey();

        }
    }

}
