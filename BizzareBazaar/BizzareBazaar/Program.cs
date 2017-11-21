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
            //Customer peasantCustomer = CustomerFactory.CreateCustomer(CustomerClass.Peasant, "Peasant");
            //      Customer warriCustomer = CustomerFactory.CreateCustomer(CustomerClass.Warrior, "Big strong Warrior");
            //      Customer wizardCustomer = CustomerFactory.CreateCustomer(CustomerClass.Wizard, "Scary Wizard");
            //      ItemProduction prod = new ItemProduction();

            //      peasantCustomer.AddItemsToInventory(prod.GetInventory());
            //      Console.WriteLine("Peasant inventory:\n");
            //      peasantCustomer.ShowInventory();

            //      warriCustomer.PrintInformation();
            //      wizardCustomer.PrintInformation();

            //      Booth.SetTimerAndFetchItems();


            ItemProduction.SetTimerAndProduceItems();
			Global.SetTimerAndFetchItems();

			Console.WriteLine("Start shopping:");

            Customer peasant = CustomerFactory.CreateCustomer(CustomerClass.Peasant, "Peasant1");
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
	        }

			
			Console.WriteLine("End shopping");

			Console.ReadKey();
		}

    }
}
