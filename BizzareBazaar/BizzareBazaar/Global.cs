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
		public const int BOOTH_DAILY_QUOTA = 10;
		private static Timer _timer = new Timer { Interval = 2000 };
		public static Timer Timer { get; set; }
		public static List<IItem> ItemsForSale = new List<IItem>();
		public static int GlobalItemNumber = 0;
	
		public static void SetTimerAndFetchItems()
		{
			//_timer = new Timer { Interval = 2000 };
			_timer.Elapsed += OnTimedEvent;
			_timer.AutoReset = true;
			_timer.Enabled = true;

		}

		public static void FetchFirstItem()
		{
			IItem item = ItemProduction.Storage.First<IItem>();
			ItemsForSale.Add(item);
			ItemProduction.Storage.Remove(item);
			
		}

		public static void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			if (ItemProduction.Storage.Count != 0)
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
