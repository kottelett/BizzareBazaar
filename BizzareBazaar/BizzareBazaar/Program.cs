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
<<<<<<< HEAD
        


=======
   
>>>>>>> 69044a8f518815936d562902b6bfc52af6e6fd51
            ItemProduction.SetTimerAndProduceItems();
			Booth b = new Booth();
	        b.SetTimerAndFetchItems();
	        

			Console.WriteLine("Start shopping:");

<<<<<<< HEAD
           
            
=======
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

			
>>>>>>> 69044a8f518815936d562902b6bfc52af6e6fd51
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
