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

		public static Customers CreateCustomer(CustomerClass customerClass, float[] stats)
	    {
		    Customers customer = null;
		    switch (customerClass)
		    {
				case CustomerClass.Peasant:
					customer = new PeasantCustomer(stats[0], stats[1], stats[2]);
					break;
				case CustomerClass.Wizard:
                    customer = new WizardCustomer(stats[0], stats[1], stats[2]);
					break;
		    }

		    return customer;

	    }
    }
}
