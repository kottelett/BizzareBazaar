using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BizzareBazaar
{
    class ItemProduction
    {
	    private readonly ItemCreator _item = new ItemCreator();
        private static Timer _timer;
	    public static List<IItem> Storage { get; set; } = new List<IItem>();
        private int ItemNumber = 0;

		public ItemProduction()
        {
            
			Storage.Add(_item.CreateRndItem(ItemNumber));
	        ItemNumber++;
			SetTimerAndProduceItems();
	        /*  for (int i = 0; i < 10; i++)
              {
                  storage.Add(item.CreateRndItem(i));
                  System.Threading.Thread.Sleep(100);
              } */

	        // Console.WriteLine("Number of items: " + storage.Count + "\n");
        }

        public void PrintStorage()
        {
            for (int i = 0; i < Storage.Count; i++)
            {
                PrintItem(Storage[i]);
            }
        }

	    public List<IItem> GetInventory()
	    {
		    return Storage;
	    }

        public void PrintItem(IItem item)
        {
            Console.WriteLine("item #" + item.GetItemNumber() + " " +
                item.GetDescription() + " | Price: " + item.GetPrice());

        }
        // Triggers OnTimedEvent every 1000 ms
	    public static void SetTimerAndProduceItems()
        {
	        _timer = new Timer {Interval = 1000};
	        _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;

        }

        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            ItemCreator item = new ItemCreator();
            int i = 0;
            Storage.Add(item.CreateRndItem(i));
           // i++;

            Console.WriteLine("OnTimedEvent ItemProduction\n");


        }

    }
}

