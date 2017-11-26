namespace BizzareBazaar
{
	class GreaterDevanaRsDecorator : ItemDecorator
	{
		public GreaterDevanaRsDecorator(IItem item) : base(item)
		{
		}

		public override string GetDescription()
		{
			return base.GetDescription() + " with Greater Devana Runestone";
		}

		public override double GetPrice()
		{
			return base.GetPrice() + 10;
		}
	}
}