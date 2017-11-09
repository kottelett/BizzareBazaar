using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	
    abstract class Customer
    {
	    protected List<IItem> Inventory { get; set; } = new List<IItem>();

	    public virtual void ShowInventory()
	    {
		    Console.WriteLine(Inventory.ToString());
	    }
    }
}
