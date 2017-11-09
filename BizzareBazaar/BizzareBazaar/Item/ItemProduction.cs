using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class ItemProduction
    {
       List<IItem> inventory;


        public void ProduceItem()
        {
            ItemCreator item = new ItemCreator();

             inventory = new List<IItem>();


            for (int i = 0; i < 10; i++)
            {
                inventory.Add(item.CreateRndItem());
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("Number of items: " + inventory.Count + "\n");

            for (int i = 0; i < inventory.Count; i++)
            {
                PrintItemInformation(inventory[i]);

            }
            Console.ReadKey();
        }

        public static void PrintItemInformation(IItem item)
        {
            Console.WriteLine(item.GetDescription() + " | Price: " + item.GetPrice());

        }
    }
}

