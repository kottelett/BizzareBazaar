using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;


namespace BizzareBazaar
{
    class Program
    {
        public static void Main(string[] args)
        {
			//PRODUCES ITEM IN ITEMPRODUCTION EVERY SECOND | Stores ALL items in ItemProduction until fetched by booth
			ItemProduction.ProduceItems();
	        ItemProduction.SetTimerAndProduceItems();
                        
            // Creates customer from CustomerFactory (Customers are waking up)
            Customer wizardCustomer = CustomerFactory.CreateCustomer(CustomerClass.Wizard, "WizardCustomer");
            Customer peasantCustomer = CustomerFactory.CreateCustomer(CustomerClass.Peasant, "PeasantCustomer");
            Customer warriorCustomer = CustomerFactory.CreateCustomer(CustomerClass.Warrior, "WarriorCustomer");

	        // Booths at Bazaar preparing for a new day
            Booth booth1 = new Booth(5 , 0);
            Booth booth2 = new Booth(5, 1);
			List<Booth> boothList = new List<Booth> { booth1, booth2 };
	        
			// The customers arrives at the Bazaar
			List<Person> customers = new List<Person> { wizardCustomer, peasantCustomer, warriorCustomer };
			
	        // Fetches items from list in ItemProduction 
			// ...same as : booth.SetTimerAndFetchItems(); Contains Console.WriteLine(item)


			Controller controller = new Controller(customers, boothList);
	        controller.InitiateBoothFetch();

            Thread[] transactionThreads = new Thread[10];
	        for (int i = 0; i < 10; i++)
	        {
		        // Lamda 
		        Thread t = new Thread(() => controller.MakeTransactionsOnList(boothList, customers));
		        transactionThreads[i] = t;
	        }
            Console.WriteLine("The Bazaar Of The Bizaare is now OPEN!");
			
			Console.ReadKey();
            int counter = 0;
			while ( counter < 10) //!BoothClosed(boothList) &&
            {
                
                Console.WriteLine("Before");
                controller.PutItemUpForSale(booth1);
				controller.PutItemUpForSale(booth2);
				transactionThreads[counter].Start();
				////threads[counter].Start();
    //            //controller.MakeTransaction();
	   //         controller.MakeTransaction(booth1, (Customer)customers.ElementAt(0));
				//controller.MakeTransaction(booth1, (Customer)customers.ElementAt(1));
	   //         controller.MakeTransaction(booth2, (Customer)customers.ElementAt(0));
	   //         controller.MakeTransaction(booth2, (Customer)customers.ElementAt(1));
	            //controller.MakeTransactionsOnList(boothList, customers);
				Console.WriteLine("After");

                counter++;


            }

	        Console.WriteLine("The Bazaare is now closed. Please come again tomorrow!");
            Console.ReadKey();

        }

        public static bool BoothClosed(List<Booth> booth)
        {
            for (int i = 0; i < booth.Count; i++)
            {
                if (booth.ElementAt(i).SoldQuota == false)
                {
                    return false;
                }
            }
            return true;


        }


    }
}
