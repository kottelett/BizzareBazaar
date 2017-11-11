using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class Booth
    {
        public List<IItem> BoothInventory = new List<IItem>();



        public Booth()
        {


        }
        public IItem FetchFirstItem()
        {

            BoothInventory.Add(ItemProduction.storage.First<IItem>());

            ItemProduction.storage.Remove(ItemProduction.storage.First<IItem>());

            return BoothInventory.First<IItem>();

        }

        public void PrintInventory()
        {
            for (int i = 0; i < BoothInventory.Count; i++)
            {

                Console.Write("item #" + i.ToString() + " ");
                PrintItem(BoothInventory[i]);
            }
        }


        

        public void PrintItem(IItem item)
        {
            Console.WriteLine(item.GetDescription() + " | Price: " + item.GetPrice());

        }
    }
}
