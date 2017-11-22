using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BizzareBazaar
{
	class Booth : IManipulateInventory
	{

	    public int DailyQuota { get; set; } 

		public List<IItem> Inventory { get; set; } = new List<IItem>();

		public int BoothNumber { get; set; }

		private static readonly Timer Timer = new Timer { Interval = 2000 }; // Muligens ok for global



		public Booth(int quota = 10, int boothNumber = 0)
		{
			DailyQuota = quota;
			BoothNumber = boothNumber;
		}

		//public void CheckStorageForItems()
		//{
		//	if (ItemProduction.Storage.Count != 0)
		//	{
		//		//tråd! 
		//		Inventory.Add(ItemProduction.Storage.First());
		//		ItemProduction.Storage.RemoveAt(0);

		//	}
		//}

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
			//_timer = new Timer { Interval = 2000 };
			Timer.Elapsed += OnTimedEvent;
			Timer.AutoReset = true;
			Timer.Enabled = true;

		}

		public void FetchFirstItem()
		{
			IItem item = ItemProduction.Storage.First<IItem>();
			Inventory.Add(item);
			ItemProduction.Storage.Remove(item);

		}

		public void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			if (ItemProduction.Storage.Count != 0)
			{
				FetchFirstItem();
			}
		}


		// Fjernes fra Interface?
		public void PrintInformation()
		{
			Console.Write("Boothnumber " + BoothNumber);
		}
	}
}
