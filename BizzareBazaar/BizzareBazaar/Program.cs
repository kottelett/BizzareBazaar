using System;
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
            Customer peasant = CustomerFactory.CreateCustomer(CustomerClass.Peasant, "Peasant1");
            // Creates 1 booth with BoothNumber 1 and daily quota of 10
            Booth booth = new Booth(20 , 1);
            


            // Fetches items from list in ItemProduction 
            // ...same as : booth.SetTimerAndFetchItems(); Contains Console.WriteLine(item)
            Controller controller = new Controller(peasant, booth);
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
