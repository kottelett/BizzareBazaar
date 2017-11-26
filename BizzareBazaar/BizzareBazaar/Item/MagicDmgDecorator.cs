namespace BizzareBazaar
{
	class MagicDecorator : ItemDecorator
	{
		public MagicDecorator(IItem item) : base(item)
		{
		}

		public override string GetDescription()
		{
			return base.GetDescription() + " with magic damage";
		}

		public override double GetPrice()
		{
			return base.GetPrice() + 10;
		}
	}
}