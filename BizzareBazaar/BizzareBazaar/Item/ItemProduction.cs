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
	    public static List<IItem> Storage = Singleton.Inventory;
        private static int _itemNumber;
		
		

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
	        _timer = new Timer {Interval = 200};
	        _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;

        }

        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
	        if (_itemNumber < 100)
	        {
		        ProduceItems();
		        //ItemCreator item = new ItemCreator();
		        //Storage.Add(item.CreateRndItem(_itemNumber));
		        //_itemNumber++;
			}
	        else
	        {
		        _timer.Stop();
		        _timer.Dispose();
	        }

        }

	    public static void ProduceItems()
	    {
			ItemCreator item = new ItemCreator();
		    Storage.Add(item.CreateRndItem(_itemNumber));
		    _itemNumber++;
		}
	    private bool stopProduction()
	    {
		    if (_itemNumber > 100)
				return true;
		    
		    return false;
	    }

    }
}

