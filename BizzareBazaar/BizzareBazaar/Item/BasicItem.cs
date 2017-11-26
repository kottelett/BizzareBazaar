namespace BizzareBazaar
{
	public class BasicItem : IItem
	{
		private readonly double _price;
		private readonly string _description;
		private readonly int _itemNumber;

		public BasicItem(double price, string description, int itemNumber)
		{
			_itemNumber = itemNumber;
			_price = price;
			_description = description;
		}

		public string GetDescription()
		{
			return _description;
		}

		public double GetPrice()
		{
			return _price;
		}

		public int GetItemNumber()
		{
			return _itemNumber;
		}
	}
}