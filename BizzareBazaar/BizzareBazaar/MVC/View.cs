using System;

namespace BizzareBazaar
{
	class View
	{
		public void PrintItem(IItem item)
		{
			Console.WriteLine(item.GetDescription() + " | Price: " + item.GetPrice());
		}


		public void ItemBought(IItem item, Person customerName, Booth booth)
		{
			Console.WriteLine("\t\t\t" + customerName.GetDescription() + " bought " + "Item#"
			                  + item.GetItemNumber() + item.GetDescription() + " from " + booth.GetDescription());
		}

		public void ItemForSale(IItem item, Booth booth)
		{
			Console.WriteLine("item#" + item.GetItemNumber() + " " + item.GetDescription() + " can now be bought from " +
			                  booth.GetDescription());
		}

		public void PrintPersonDescription(Person person)
		{
			person.PrintBoothNumber();
		}
	}
}