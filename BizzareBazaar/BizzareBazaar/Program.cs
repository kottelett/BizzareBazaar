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
                        
            // Creates customer of type peasant in CustomerFactory
            Customer wizardCustomer = CustomerFactory.CreateCustomer(CustomerClass.Wizard, "WizardCustomer");
            Customer peasantCustomer = CustomerFactory.CreateCustomer(CustomerClass.Peasant, "PeasantCustomer");
            Customer warriorCustomer = CustomerFactory.CreateCustomer(CustomerClass.Warrior, "WarriorCustomer");

	        List<Person> customers = new List<Person> {wizardCustomer, peasantCustomer, warriorCustomer};

	        // Creates 1 booth with BoothNumber 1 and daily quota of 10
            Booth booth1 = new Booth(5 , 0);
            Booth booth2 = new Booth(5, 1);

	        List<Booth> boothList = new List<Booth> {booth1, booth2};



	        // Fetches items from list in ItemProduction 
			// ...same as : booth.SetTimerAndFetchItems(); Contains Console.WriteLine(item)


			Controller controller = new Controller(customers, boothList);
	        //DEBUG: Det er her ting går i surr 
            controller.InitiateBoothFetch();

            
            Console.WriteLine("yep");
			
			Console.ReadKey();
            int counter = 0;
			while ( counter < 5) //!BoothClosed(boothList) &&
            {
                
                Console.WriteLine("Before");
                controller.PutItemUpForSale(booth1);
				controller.PutItemUpForSale(booth2);

				////threads[counter].Start();
    //            //controller.MakeTransaction();
	   //         controller.MakeTransaction(booth1, (Customer)customers.ElementAt(0));
				//controller.MakeTransaction(booth1, (Customer)customers.ElementAt(1));
	   //         controller.MakeTransaction(booth2, (Customer)customers.ElementAt(0));
	   //         controller.MakeTransaction(booth2, (Customer)customers.ElementAt(1));
	            controller.MakeTransactionsOnList(boothList, customers);
				Console.WriteLine("After");

                counter++;


            }

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
