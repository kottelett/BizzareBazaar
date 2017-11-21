using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{ // Person + salesman istedenfor booth? 
	internal abstract class Person
	{

		protected List<IItem> _inventory = new List<IItem>();

		protected List<IItem> Inventory { get; set; } // ???

		public List<IItem> GetInventory()
		{
			return _inventory;
		}

		public void SetInventory(List<IItem> value)
		{
			_inventory = value;
		}
		public IItem GetFirstItem()
		{
			return GetInventory().FirstOrDefault();
		}
		public void AddOneItemToInventory(IItem item)
		{
			GetInventory().Add(item);
		}

		public void AddItemsToInventory(List<IItem> itemList)
		{
			GetInventory().AddRange(itemList);
		}

		public void RemoveFirstItemFromInventory() // Finnes egen metoder for det i list
		{
			GetInventory().RemoveAt(0);
		}

		public abstract void PrintInformation();

	}
}
