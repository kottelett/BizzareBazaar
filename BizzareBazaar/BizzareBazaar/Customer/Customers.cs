using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{

        public abstract class Customers
        {
           //List<BasicItem> inventory = new List<BasicItem>();

        //protected List<BasicItem> Inventory { get => inventory; set => inventory = value; }
        /*public virtual void ShowInventory()
        {
            Console.WriteLine(Inventory.ToString());
        }*/
    
        public abstract string GetClass();
        public virtual void PrintInformation()
        {
            Console.WriteLine("Overrided text");
        }
		
    }
}
