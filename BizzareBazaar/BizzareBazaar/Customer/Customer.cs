using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	
    abstract class Customer
    {
		List<BasicItem> inventory = new List<BasicItem>();

		protected List<BasicItem> Inventory { get => inventory; set => inventory = value; }

		public virtual void ShowInventory()
	    {
		    Console.WriteLine(Inventory.ToString());
	    }
    }
}
