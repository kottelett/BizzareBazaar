using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BizzareBazaar
{
    class Booth 
    {
        static Timer _timer;
        public static List<IItem> BoothInventory = new List<IItem>();

        public Booth()
        {


        }
		public static IItem FetchFirstItem()
		{
			BoothInventory.Add(ItemProduction.Storage.First<IItem>());

			ItemProduction.Storage.Remove(ItemProduction.Storage.First<IItem>());

			return BoothInventory.First<IItem>();

		}

		public static void PrintInventory()
        {
            for (int i = 0; i < BoothInventory.Count; i++)
            {

                Console.Write("item #" + i.ToString() + " ");
                PrintItem(BoothInventory[i]);
            }
        }

        public static void PrintItem(IItem item)
        {
            Console.WriteLine(item.GetDescription() + " | Price: " + item.GetPrice());

        }

		public static void SetTimerAndFetchItems()
		{
			_timer = new Timer { Interval = 2000 };
			_timer.Elapsed += OnTimedEvent;
			_timer.AutoReset = true;
			_timer.Enabled = true;

		}

		public static void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			if (BoothInventory.Count < 5)
			{
				FetchFirstItem();
				//PrintInventory();
				//Console.WriteLine("\n");
			}
			else
			{
				//Console.WriteLine("Booth1`s inventory is full");
			}
			//  Console.WriteLine("Elapsed event at {0}", e.SignalTime);
		}



	}
}
