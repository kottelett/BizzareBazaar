using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

		public void RemoveFirstItemFromInventory() // Finnes egen metoder for det i list
		{
			Inventory.RemoveAt(0);
		}

		public abstract void PrintInformation();

	}
}
