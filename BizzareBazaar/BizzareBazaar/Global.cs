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
		private static Timer _timer;
		public static Timer Timer { get; set; }

	
		public static void SetTimerAndFetchItems()
		{
			_timer = new Timer { Interval = 2000 };
			_timer.Elapsed += OnTimedEvent;
			_timer.AutoReset = true;
			_timer.Enabled = true;

		}

		public static void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			//if (BoothInventory.Count < 5)
			//{
			//	FetchFirstItem();
			//	PrintInventory();
			//	Console.WriteLine("\n");
			//}
			//else
			//{
			//	Console.WriteLine("Booth1`s inventory is full");
			//}
			////  Console.WriteLine("Elapsed event at {0}", e.SignalTime);
		}
	}

}
