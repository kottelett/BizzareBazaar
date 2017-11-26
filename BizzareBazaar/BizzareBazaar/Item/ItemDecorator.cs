namespace BizzareBazaar
{
	abstract class ItemDecorator : IItem
	{
		private readonly IItem _originalItem;

		protected ItemDecorator(IItem item)
		{
			_originalItem = item;
		}

		public virtual double GetPrice()
		{
			return _originalItem.GetPrice();
		}

		public virtual string GetDescription()
		{
			return _originalItem.GetDescription();
		}

		public virtual int GetItemNumber()
		{
			return _originalItem.GetItemNumber();
		}
	}
}