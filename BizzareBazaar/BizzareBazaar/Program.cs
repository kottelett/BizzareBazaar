using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace BizzareBazaar
{
	class Program
	{
		public static void Main(string[] args)
		{
			//PRODUCES ITEM IN ITEMPRODUCTION EVERY SECOND | Stores ALL items in ItemProduction until fetched by booth
			ItemProduction.ProduceItem();
			ItemProduction.SetTimerAndProduceItems();

			// Creates customer from CustomerFactory (Customers are waking up from a good night sleep)
			Customer wizardCustomer = CustomerFactory.CreateCustomer(CustomerClass.Wizard, "WizardCustomer");
			Customer peasantCustomer = CustomerFactory.CreateCustomer(CustomerClass.Peasant, "PeasantCustomer");
			Customer warriorCustomer = CustomerFactory.CreateCustomer(CustomerClass.Warrior, "WarriorCustomer");

			// Booths at Bazaar preparing for a new day
			Booth booth1 = new Booth(10, 0);
			Booth booth2 = new Booth(5, 1);
			List<Booth> boothList = new List<Booth> {booth1, booth2};

			// The customers arrives at the Bazaar
			List<Person> customers = new List<Person> {wizardCustomer, peasantCustomer, warriorCustomer};

			Controller controller = new Controller();
			// The Booths at the Bazaar begins to get items from the supplier
			controller.InitiateBoothFetch(boothList);

			Thread[] itemForSaleThread = new Thread[boothList.Count];


			Console.WriteLine("The Bazaar Of The Bizaare is now OPEN!");
			Console.WriteLine("Press any key to start shopping");
			Console.ReadKey();

			while (!BoothClosed(boothList))
			{
				for (int i = 0; i < itemForSaleThread.Length; i++)
				{
					Thread th = new Thread(() => new Thread(() => controller.PutItemUpForSale(boothList.ElementAt(i))));
					itemForSaleThread[i] = th;
					th.Start();
				}
				//foreach (var booth in boothList)
				//{
				//	controller.PutItemUpForSale(booth);
				//}
				Thread t = new Thread(() => controller.MakeTransactionsOnList(boothList, customers));
				t.Start();


				t.Join();
			}

			Console.WriteLine("The Bazaare is now closed. Please come again tomorrow!");
			Console.ReadKey();
		}

		public static bool BoothClosed(List<Booth> boothList)
		{
			for (int i = 0; i < boothList.Count; i++)
			{
				if (boothList.ElementAt(i).DailyQuota > 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}