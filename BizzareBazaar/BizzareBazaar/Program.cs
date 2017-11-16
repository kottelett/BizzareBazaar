using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BizzareBazaar
{
    class Program
    {
        public static void Main(string[] args)
        {

            /*  Console.WriteLine("STORAGE BEFORE FETCH: \n");
              produce.PrintStorage();


              Console.WriteLine("INVENTORY BEFORE FETCH: \n");
              booth.PrintInventory();



              Console.WriteLine("___________________________________________________________________________");
              Console.WriteLine("STORAGE AFTER FETCH: \n");
              produce.PrintStorage();

              Console.WriteLine("INVENTORY AFTER FETCH: \n");
              booth.PrintInventory();

              */
            // Booth begins to fetch items from storage
            ItemProduction.SetTimerAndProduceItems();
            Booth.SetTimerAndFetchItems();

           
            Console.ReadKey();
            
        }

    }
}
