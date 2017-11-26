using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace BizzareBazaar
{
	class Booth : IManipulateInventory
	{
		public int DailyQuota { get; set; }

		public List<IItem> Inventory { get; set; } = new List<IItem>();


		public int BoothNumber { get; set; }

		private readonly Timer _timer = new Timer {Interval = 500};

		public bool SoldQuota = false;


		public Booth(int quota, int boothNumber)
		{
			DailyQuota = quota;
			BoothNumber = boothNumber;
		}


		public IItem GetFirstItem()
		{
			return Inventory.First();
		}

		public void AddOneItemToInventory(IItem item)
		{
			Inventory.Add(item);
		}

		public void AddItemsToInventory(List<IItem> itemList)
		{
			Inventory.AddRange(itemList);
		}

		public void RemoveFirstItemFromInventory()
		{
			Inventory.RemoveAt(0);
		}

		public void SetTimerAndFetchItems()
		{
			_timer.Elapsed += OnTimedEvent;
			_timer.AutoReset = true;
			_timer.Enabled = true;
		}

		public void FetchFirstItem()
		{
			if (Singleton.Inventory.Count != 0)
			{
				Inventory.Add(Singleton.Inventory.First());
				Singleton.Inventory.Remove(Singleton.Inventory.First());
			}

			if (DailyQuota <= 0)
			{
				_timer.Stop();
				_timer.Dispose();
			}
		}

		public void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			if (Singleton.Inventory.Count != 0 && DailyQuota > 0)
			{
				FetchFirstItem();
			}
		}

		public IItem ItemUpForSale()
		{
			return Inventory.First();
		}

		public string GetDescription()
		{
			return "Booth#" + BoothNumber;
		}


		//La stå
		public void PrintItem(IItem item)
		{
			Console.WriteLine("Item# " + item.GetItemNumber() + " " + item.GetDescription() + "Price is: " + item.GetPrice());
		}
	}
}