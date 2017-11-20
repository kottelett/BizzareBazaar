using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	static class Global
	{
		public const int BOOTHDAILYQUOTA = 10;
		private static Timer _timer;
		public static Timer Timer { get; set; }
		public static List<IItem> ItemsForSale = new List<IItem>();
		public static int GlobalItemNumber = 0;
	
		public static void SetTimerAndFetchItems()
		{
			_timer = new Timer { Interval = 2000 };
			_timer.Elapsed += OnTimedEvent;
			_timer.AutoReset = true;
			_timer.Enabled = true;

		}

		public static IItem FetchFirstItem()
		{

			ItemsForSale.Add(ItemProduction.Storage.First<IItem>());
			IItem item = ItemProduction.Storage.First<IItem>();
			ItemProduction.Storage.Remove(ItemProduction.Storage.First<IItem>());

			return item;

		}

		public static void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			// fix magic number
			if (ItemsForSale.Count != 0)
			{
				FetchFirstItem();
			}
			//else
			//{
			//	Console.WriteLine("Booth1`s inventory is full");
			//}
			////  Console.WriteLine("Elapsed event at {0}", e.SignalTime);
		}

		
	}

}
