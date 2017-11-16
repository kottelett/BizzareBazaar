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

        public static List<IItem> storage { get; set; } = new List<IItem>();
        ItemCreator item = new ItemCreator();
        private static Timer timer;

        public ItemProduction()
        {

            //  ItemCreator item = new ItemCreator();




            /*  for (int i = 0; i < 10; i++)
              {
                  storage.Add(item.CreateRndItem(i));
                  System.Threading.Thread.Sleep(100);
              } */

           // Console.WriteLine("Number of items: " + storage.Count + "\n");
        }

        public void PrintStorage()
        {
            for (int i = 0; i < storage.Count; i++)
            {
                PrintItem(storage[i]);
            }
        }

        public void PrintItem(IItem item)
        {
            Console.WriteLine("item #" + item.GetItemNumber() + " " +
                item.GetDescription() + " | Price: " + item.GetPrice());

        }
        // Triggers OnTimedEvent every 1000 ms
        public static void SetTimerAndProduceItems()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;

        }

        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            ItemCreator item = new ItemCreator();
            int i = 0;
            storage.Add(item.CreateRndItem(i));
            i++;

            Console.WriteLine("\n");


        }

    }
}

