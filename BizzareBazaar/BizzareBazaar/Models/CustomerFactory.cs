using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
		/*
		public static Customer CustomerCreateCustomer(CustomerClass customerClass, float[] stats)
		{
			Customer customer = null;
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
		}*/
		public static Customer CreateCustomer(CustomerClass customerClass, string customerName)
		{
			Customer customer = null;
			switch (customerClass)
			{
				case CustomerClass.Peasant:
					customer = new PeasantCustomer(customerName);
					break;
				case CustomerClass.Warrior:
					customer = new WarriorCustomer(customerName);
					break;
				case CustomerClass.Wizard:
					customer = new WizardCustomer(customerName);
					break;
			}
			return customer;

		}

		//public static Customer CreateRandomCustomer(string customerName)
		//{
		//	return CreateCustomer(RandomCustomerClass, customerName);
			
		//}

		//public static CustomerClass RandomCustomerClass
		//{
		//	get
		//	{
		//		var random = new Random();try
		//		var values = Enum.GetValues(enumType: typeof(string));
		//		return (CustomerClass)values.GetValue(random.Next(values.Length));
		//	}
		//}
	}

	
}