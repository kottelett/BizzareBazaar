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
            Booth booth1 = new Booth(5 , 0);
            Booth booth2 = new Booth(5, 1);

            List<Booth> boothList = new List<Booth>();
            boothList.Add(booth1);
            boothList.Add(booth2);



            // Fetches items from list in ItemProduction 
            // ...same as : booth.SetTimerAndFetchItems(); Contains Console.WriteLine(item)
            Controller controller = new Controller(customers, boothList);
	        //DEBUG: Det er her ting går i surr 
            controller.InitiateBoothFetch();

            
            Console.WriteLine("yep");

            Console.ReadKey();

            int counter = 0;
            while (!BoothClosed(boothList) && counter < 10)
            {
                
                Console.WriteLine("Before");
                controller.ItemUpForSale();
                controller.MakeTransaction();
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
