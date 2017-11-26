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
        private static Timer _timer;
	    //public static List<IItem> Storage { get; set; } = new List<IItem>();
	    public static Singleton Storage = Singleton.Instance;
	    //public static volatile List<IItem> Storage = Singleton.Inventory;
        private static volatile int _itemNumber;
	    private static readonly Object Lock = new Object();


		public void PrintStorage()
		{
			foreach (IItem item in Singleton.Inventory)
			{
				PrintItem(item);
			}
		}

	    public List<IItem> GetInventory()
	    {
		    return Singleton.Inventory;
	    }

        public void PrintItem(IItem item)
        {
            Console.WriteLine("item #" + item.GetItemNumber() + " " +
                item.GetDescription() + " | Price: " + item.GetPrice());

        }
        
	    
	    public static void SetTimerAndProduceItems()
        {
	        _timer = new Timer {Interval = 200};
	        _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;

        }

        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
	        if (!StopProduction())
	        {
		        ProduceItem();
			}
	        else
	        {
		        _timer.Stop();
		        _timer.Dispose();
	        }

        }

	    public static void ProduceItem()
	    {
		    lock (Lock)
		    {
			    ItemCreator item = new ItemCreator();
			    Singleton.Inventory.Add(item.CreateRndItem(_itemNumber));
			    _itemNumber++;
		    }
		}
	    private static bool StopProduction()
	    {
		    return _itemNumber > 100;
	    }

    }
}

