using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class Program
    {

        public static void Main(string[] args)
        {
            ItemCreator item = new ItemCreator();

           
            List<IItem> inventory = new List<IItem>();

            for (int i = 0; i < 10; i++)
            {
                inventory.Add(item.CreateRndItem());

            }

            Console.WriteLine("Number of items: " + inventory.Count);
            for(int i = 0; i < inventory.Count; i++)
            {
                PrintItemInformation(inventory[i]);
                Console.ReadKey();
            }
        }

        public static void PrintItemInformation(IItem item)
        {
             Console.WriteLine(item.GetDescription() + " Price: " + item.GetPrice());
            
        }
    }
}
