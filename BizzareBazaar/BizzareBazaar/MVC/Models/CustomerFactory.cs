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
	}
}