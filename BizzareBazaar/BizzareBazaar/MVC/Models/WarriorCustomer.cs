namespace BizzareBazaar
{
	class WarriorCustomer : Customer
	{
		public WarriorCustomer(string customerCustomerGroup)
		{
			CustomerGroup = customerCustomerGroup;
		}

		public override void PrintBoothNumber()
		{
			PrintInformation(GetCustomerGroup());
		}
	}
}