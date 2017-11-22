using System;


namespace BizzareBazaar
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Produces item in ItemProduction every second | Stores items in ItemProduction until fetched by booth
            ItemProduction.SetTimerAndProduceItems();

            // Creates customer of type peasant in CustomerFactory
            Customer peasant = CustomerFactory.CreateCustomer(CustomerClass.Peasant, "Peasant1");

            // Creates 1 booth with BoothNumber 1 and daily quota of 10
            Booth booth = new Booth(10 , 1);

            // Fetches items from list in ItemProduction 
            booth.SetTimerAndFetchItems();

            Controller controller = new Controller(peasant, booth);
			controller.InitiateShopping();
			
			// Debug
			
	        for (int i = 0;  i < 10; i++)
	        {
	            Console.WriteLine(i);
                controller.MakeTransaction();
	           
	        }

			Console.ReadKey();


        }

    }
}
