using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class Program
    {
        public static void Main(string[] args)
        {
			
            ItemProduction produce =  new ItemProduction();
            Booth booth = new Booth();

            Console.WriteLine("STORAGE BEFORE FETCH: \n");
            produce.PrintStorage();
           

            Console.WriteLine("INVENTORY BEFORE FETCH: \n");
            booth.PrintInventory();

            for (int i = 0; i < 3; i++)
            {
                booth.FetchFirstItem();
            }

            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("STORAGE AFTER FETCH: \n");
            produce.PrintStorage();

            Console.WriteLine("INVENTORY AFTER FETCH: \n");
            booth.PrintInventory();
            
            

	        Customer peasantCustomer = CustomerFactory.CreateCustomer(CustomerClass.Peasant, "Peasant");
	        Customer warriCustomer = CustomerFactory.CreateCustomer(CustomerClass.Warrior, "Big strong Warrior");
	        Customer wizardCustomer= CustomerFactory.CreateCustomer(CustomerClass.Wizard, "Scary Wizard");
			ItemProduction prod = new ItemProduction();

			peasantCustomer.AddItemsToInventory(prod.GetInventory());
			Console.WriteLine("Peasant inventory:\n");
			peasantCustomer.ShowInventory();

			warriCustomer.PrintInformation();
			wizardCustomer.PrintInformation();


			// Hack to stop program from terminating
	        Console.ReadKey();
		}

    }
}
