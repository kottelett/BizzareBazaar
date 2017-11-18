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


	  //      ItemProduction.SetTimerAndProduceItems();
	  //      Booth.SetTimerAndFetchItems();

	        Controller controller = new Controller();

			// Hack to stop program from terminating
			Console.ReadKey();
		}

    }
}
