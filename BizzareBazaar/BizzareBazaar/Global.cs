/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	static class Global
	{
		public const int BOOTH_DAILY_QUOTA = 10; // Overflødig/unødvendig

		private static Timer _timer = new Timer {Interval = 2000}; // Muligens ok for global
		public static List<IItem> ItemsForSale = new List<IItem>(); // Muligens ok for global
	   
		//public static void SetTimerAndFetchItems()
		//{
		//	//_timer = new Timer { Interval = 2000 };
		//	_timer.Elapsed += OnTimedEvent;
		//	_timer.AutoReset = true;
		//	_timer.Enabled = true;

		//}

		//public static void FetchFirstItem()
		//{
		//	IItem item = ItemProduction.Storage.First<IItem>();
		//	ItemsForSale.Add(item);
		//	ItemProduction.Storage.Remove(item);
			
		//}

	 //   public static void OnTimedEvent(Object source, ElapsedEventArgs e)
	 //   {
	 //       if (ItemProduction.Storage.Count != 0)
	 //       {
	 //           FetchFirstItem();
	 //       }
	 //   }

    
	}

}
*/