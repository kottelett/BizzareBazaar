namespace BizzareBazaar
{
	class WizardCustomer : Customer
	{
		public WizardCustomer(string customerCustomerGroup)
		{
			CustomerGroup = customerCustomerGroup;
		}


		public override void PrintBoothNumber()
		{
			PrintInformation(GetCustomerGroup());
		}
	}
}