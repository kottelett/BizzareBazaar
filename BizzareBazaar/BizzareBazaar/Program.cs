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

            IItem Datitem = item.CreateRndItem();
            PrintItemInformation(Datitem);
            Console.ReadKey();

            /*List<IItem> items = new List<IItem>();

            items.Add(item.CreateRndItem());
            Console.WriteLine(items.Count);
            for(int i = 0; i < items.Count; i++)
            {
                PrintItemInformation(items[i]);
            }*/
        }

        public static void PrintItemInformation(IItem item)
        {
            Console.WriteLine(item.GetDescription() + " Price: " + item.GetPrice());
            
        }
    }
}
