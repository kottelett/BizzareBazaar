namespace BizzareBazaar
{
	class SanneshRsDecorator : ItemDecorator
	{
		public SanneshRsDecorator(IItem item) : base(item)
		{
		}

		public override string GetDescription()
		{
			return base.GetDescription() + " with Sannnesh Runestone(Ragnaros quest item)";
		}

		public override double GetPrice()
		{
			return base.GetPrice() + 10;
		}
	}
}