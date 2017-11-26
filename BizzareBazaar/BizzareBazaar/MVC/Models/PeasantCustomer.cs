using System;

namespace BizzareBazaar
{
	class PeasantCustomer : Customer
	{
		public PeasantCustomer(string customerCustomerGroup)
		{
			CustomerGroup = customerCustomerGroup;
		}

		public override void PrintBoothNumber()
		{
			Console.Write(CustomerGroup);
		}
	}
}