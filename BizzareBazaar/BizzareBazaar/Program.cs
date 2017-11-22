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
        


            ItemProduction.SetTimerAndProduceItems();
			Global.SetTimerAndFetchItems();

			Console.WriteLine("Start shopping:");

           
            
			Console.WriteLine("End shopping");

			Console.ReadKey();












            /*Customer peasant = CustomerFactory.CreateCustomer(CustomerClass.Peasant, "Peasant1");
          Salesman salesman = new Salesman("Salesman1", 10);
          Controller controller = new Controller(peasant, salesman);
          controller.InitiateShopping();

          // Debug
          Global.ItemsForSale.Add(new BasicItem(10, "Basic Item", 1));
          int it = 10;
          while (it > 0)
          {
              controller.MakeTransaction();
              Console.ReadLine();
              Console.WriteLine(it);
              it--;
          } */
        }

    }
}
