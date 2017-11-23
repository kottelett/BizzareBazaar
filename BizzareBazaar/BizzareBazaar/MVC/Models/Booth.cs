using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace BizzareBazaar
{
	class Booth : IManipulateInventory
	{

	    public int DailyQuota { get; set; }

	    public int InventoryMaxSize = 5;

		public List<IItem> Inventory { get; set; } = new List<IItem>();

		public int BoothNumber { get; set; }

		private static readonly Timer Timer = new Timer { Interval = 300}; // Muligens ok for global



		public Booth(int quota, int boothNumber)
		{
			DailyQuota = quota;
			BoothNumber = boothNumber;
		}


		public IItem GetFirstItem()
		{
			return Inventory.FirstOrDefault();
		}
		public void AddOneItemToInventory(IItem item)
		{
			Inventory.Add(item);
		}

		public void AddItemsToInventory(List<IItem> itemList)
		{
			Inventory.AddRange(itemList);
		}

		public void RemoveFirstItemFromInventory() // Finnes egen metoder for det i list
		{
			Inventory.RemoveAt(0);
		}

		public void SetTimerAndFetchItems()
		{
			Timer.Elapsed += OnTimedEvent;
			Timer.AutoReset = true;
			Timer.Enabled = true;

		}

		public void FetchFirstItem()
		{

            if (ItemProduction.Storage.Count != 0 && Inventory.Count < InventoryMaxSize)
            {
		        IItem item = ItemProduction.Storage.First();
		        Inventory.Add(item);
		        ItemProduction.Storage.Remove(item);
		       // PrintItem(item);
                DailyQuota--;
              // Console.WriteLine(DailyQuota);
            }
            
		    if (DailyQuota == 0)
		    {
		        Timer.Stop();

             //   Console.WriteLine(Inventory.Count);
		    }
		}


		

		public void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			if (ItemProduction.Storage.Count != 0)
			{
				FetchFirstItem();
			}
		}

        //tråd 
	    public IItem ItemUpForSale()
	    {
	        IItem item = Inventory.First();

	        return item;
	    }


		// Fjernes fra Interface?
		public void PrintBoothNumber()
		{
			Console.Write("Boothnumber " + BoothNumber);
		}


        //La stå
	    public void PrintItem(IItem item)
	    {
	        Console.WriteLine("Item# " + item.GetItemNumber() + " " + item.GetDescription() + "Price is: " + item.GetPrice());
	    }
	}
}
