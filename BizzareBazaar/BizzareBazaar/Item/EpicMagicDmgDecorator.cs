namespace BizzareBazaar
{
	class EpicMagicDamageDecorator : ItemDecorator
	{
		public EpicMagicDamageDecorator(IItem item) : base(item)
		{
		}

		public override string GetDescription()
		{
			return base.GetDescription() + " with EPIC magic damage";
		}

		public override double GetPrice()
		{
			return base.GetPrice() + 10;
		}
	}
}