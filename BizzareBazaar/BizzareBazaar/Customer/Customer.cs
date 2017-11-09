using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	
    abstract class Customer
    {
	    public virtual void ShowInventory()
	    {
		    Console.WriteLine("Inventory is empty");
	    }
    }
}
