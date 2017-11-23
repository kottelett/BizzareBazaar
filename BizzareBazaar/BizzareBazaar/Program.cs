using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace BizzareBazaar
{
    class Program
    {
        public static void Main(string[] args)
        {
            View view = new View();

            //PRODUCES ITEM IN ITEMPRODUCTION EVERY SECOND | Stores ALL items in ItemProduction until fetched by booth
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
            Booth booth1 = new Booth(20 , 1);
            Booth booth2 = new Booth(20, 2);

            List<Booth> boothList = new List<Booth>();
            boothList.Add(booth1);
            boothList.Add(booth2);



            // Fetches items from list in ItemProduction 
            // ...same as : booth.SetTimerAndFetchItems(); Contains Console.WriteLine(item)
            Controller controller = new Controller(customers, boothList);
            controller.InitiateBoothFetch();

            
            Console.WriteLine("yep");

            Console.ReadKey();

            controller.ItemUpForSale();
            controller.MakeTransaction();



            Console.ReadKey();

















            /* for (int i = 0; i < booth.Inventory.Count; i++)
             {
                 Console.WriteLine(booth.Inventory[i]);
             } */


            /*
	        for (int i = 0;  i < 10; i++)
	        {
	            Console.WriteLine(i);
                controller.MakeTransaction();
	           
	        }*/



        }

    }
}
