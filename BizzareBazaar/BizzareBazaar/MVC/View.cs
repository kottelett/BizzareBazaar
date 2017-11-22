using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	class View
	{
		public View() // ???
		{
			
		}

		public List<IItem> ItemList { get; set; }

		public void PrintItem(IItem item)
		{
			Console.WriteLine(item.GetDescription() + " | Price: " + item.GetPrice());

		}

		//public void ShowInventory(List<IItem> items)
		//{
		//	if (items.Count != 0)
		//	{
		//		foreach (var item in items)
		//		{
		//			Console.WriteLine(item.GetDescription());
		//		}
		//	}
			
		//}

		public void ItemBought(IItem item, Person customerName)
		{
			customerName.PrintInformation();
			Console.WriteLine(" bought " + "Item # " +item.GetItemNumber() + item.GetDescription());
		}

		public void ItemForSale(IItem item, string salesmanName)
		{
			Console.WriteLine(item.GetDescription() + " can now be bought from " + salesmanName);
		}

		public void PrintDescription(Person person)
		{
			person.PrintInformation();
		}
	}
}
