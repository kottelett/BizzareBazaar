using System.Collections.Generic;
using System.Linq;

namespace BizzareBazaar
{
	public static class Global
	{
		public static IItem GetFirstItem(List<IItem> inventory)
		{
			return inventory.First();
		}

		public static void AddOneItemToInventory(List<IItem> inventory, IItem item)
		{
			inventory.Add(item);
		}

		public static void AddItemsToInventory(List<IItem> inventory, List<IItem> itemList)
		{
			inventory.AddRange(itemList);
		}

		public static void RemoveFirstItemFromInventory(List<IItem> inventory)
		{
			inventory.RemoveAt(0);
		}

		public static void RemoveLastItemFromInventory(List<IItem> inventory)
		{
			inventory.RemoveAt(inventory.Count);
		}

		public static string GetDescription(IItem item)
		{
			return item.GetDescription();
		}
	}
}

