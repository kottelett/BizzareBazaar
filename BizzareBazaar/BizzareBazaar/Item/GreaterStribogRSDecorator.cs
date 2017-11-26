namespace BizzareBazaar
{
	class GreaterStribogRsDecorator : ItemDecorator
	{
		public GreaterStribogRsDecorator(IItem item) : base(item)
		{
		}

		public override string GetDescription()
		{
			return base.GetDescription() + " with Greater Stribog runestone";
		}

		public override double GetPrice()
		{
			return base.GetPrice() + 10;
		}
	}
}