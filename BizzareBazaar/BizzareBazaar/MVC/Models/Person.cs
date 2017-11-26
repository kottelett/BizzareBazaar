using System.Collections.Generic;
using System.Linq;

namespace BizzareBazaar
{
	internal abstract class Person : IManipulateInventory
	{
		public List<IItem> Inventory { get; set; } = new List<IItem>();

		protected Person()
		{
		}

		public IItem GetFirstItem()
		{
			return Inventory.FirstOrDefault();
		}

		public void AddOneItemToInventory(IItem item)
		{
			Inventory.Add(item);
		}

		public void AddItemsToInventory(List<IItem> itemList)
		{
			Inventory.AddRange(itemList);
		}

		public void RemoveFirstItemFromInventory()
		{
			Inventory.RemoveAt(0);
		}

		public virtual string GetDescription()
		{
			return "Person.GetDescription: A basic, boring person";
		}


		public abstract void PrintBoothNumber();
	}
}