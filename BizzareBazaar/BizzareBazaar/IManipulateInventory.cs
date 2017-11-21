using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	interface IManipulateInventory
	{
		//List<IItem> Inventory { get; set; }
		IItem GetFirstItem();
		void AddOneItemToInventory(IItem item);
		void AddItemsToInventory(List<IItem> itemList);
		void RemoveFirstItemFromInventory();
		void PrintInformation();

	}
}
