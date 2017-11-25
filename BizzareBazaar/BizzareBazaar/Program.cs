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

            List<Person> customers = new List<Person>();
            customers.Add(wizardCustomer);
            customers.Add(peasantCustomer);
            customers.Add(warriorCustomer);

            // Creates 1 booth with BoothNumber 1 and daily quota of 10
            Booth booth1 = new Booth(5 , 0);
            //Booth booth2 = new Booth(5, 1);

            List<Booth> boothList = new List<Booth>();
            boothList.Add(booth1);
			//boothList.Add(booth2);



			// Fetches items from list in ItemProduction 
			// ...same as : booth.SetTimerAndFetchItems(); Contains Console.WriteLine(item)


			Controller controller = new Controller(customers, boothList);
	        //DEBUG: Det er her ting går i surr 
            controller.InitiateBoothFetch();

            
            Console.WriteLine("yep");

	        //Thread[] threads = new Thread[5];
	        
			Console.ReadKey();
            int counter = 0;
			//for (int i = 0; i < 5; i++)
			//{
			//	// This is how we create new "Main" methods for each thread. 
			//	// Here, these "Mains" are instances of the method "acc.DoTransactions"
			//	Thread t = new Thread(new ThreadStart(controller.MakeTransaction));
			//	threads[i] = t;
			//}
			while ( counter < 5) //!BoothClosed(boothList) &&
            {
                
                Console.WriteLine("Before");
                controller.PutItemUpForSale(booth1);
				//controller.PutItemUpForSale(booth2);

				//threads[counter].Start();
                //controller.MakeTransaction();
	            controller.MakeTransaction(booth1, (Customer)customers.ElementAt(0));
				controller.MakeTransaction(booth1, (Customer)customers.ElementAt(1));
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
