using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class ItemProduction
    {

        public static List<IItem> storage { get; set; } = new List<IItem>();
        ItemCreator item = new ItemCreator();


        public ItemProduction()
        {

            ItemCreator item = new ItemCreator();


            for (int i = 0; i < 10; i++)
            {
                storage.Add(item.CreateRndItem(i));
                System.Threading.Thread.Sleep(100);
            }

            Console.WriteLine("Number of items: " + storage.Count + "\n");
        }

        public void PrintStorage()
        {
            for (int i = 0; i < storage.Count; i++)
            {
                PrintItem(storage[i]);
            }
        }

	    public List<IItem> GetInventory()
	    {
		    return storage;
	    }

        public void PrintItem(IItem item)
        {
            Console.WriteLine("item #" + item.GetItemNumber() + " " +
                item.GetDescription() + " | Price: " + item.GetPrice());

        }

    }

}

