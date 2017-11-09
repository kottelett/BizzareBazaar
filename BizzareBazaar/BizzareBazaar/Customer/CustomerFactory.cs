using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	enum CustomerClass
	{
		Peasant,
		Wizard,
		Warrior
	}
    class CustomerFactory
    {
	    private CustomerFactory()
	    {
		    
	    }

		public static Customer CreateCustomer(CustomerClass customerClass, String[] inventory)
	    {
		    Customer customer = null;
		    switch (customerClass)
		    {
				case CustomerClass.Peasant:
					customer = new PeasantCustomer();
					break;
				case CustomerClass.Warrior:
					break;
				case CustomerClass.Wizard:
					break;
		    }



		    return customer;

	    }
    }
}
