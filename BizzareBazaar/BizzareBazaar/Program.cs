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
			Booth b = new Booth();
	        b.SetTimerAndFetchItems();
	        

			Console.WriteLine("Start shopping:");

            Customer peasant = CustomerFactory.CreateCustomer(CustomerClass.Peasant, "Peasant1");
            Booth salesman = new Booth(5);
            Controller controller = new Controller(peasant, salesman);
			controller.InitiateShopping();
			
			// Debug
			
	        int it = 10;
	        while (it > 0)
	        {
		        
				controller.MakeTransaction();
		        Console.ReadLine();
				Console.WriteLine(it);
		        it--;
	        }

			
			Console.WriteLine("End shopping");

			Console.ReadKey();
		}

    }
}
