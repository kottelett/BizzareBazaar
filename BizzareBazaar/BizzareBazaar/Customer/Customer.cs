using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	abstract class Customer
	{
		public List<IItem> Inventory { get; set; } =
			new List<IItem>();

		protected string Class { get; set; }
		//protected double Strength;
		//protected double Intelect;
		//protected double Agility;


		protected virtual string GetClass()
		{
			return Class;
		}

		//public virtual void PrintInformation()
		//{
		//	Console.WriteLine("Unidendified Class");
		//}


		//public virtual void ShowInventory()
		//{
		//	foreach (var item in Inventory)
		//	{
		//		Console.WriteLine(item.GetDescription());
		//	}
		//}

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

		//public void PrintInformation(string customerClass)
		//{
		//	StringBuilder builder = new StringBuilder();
		//	builder.Append("Class: "+ GetClass() + "\n");


		//	Console.WriteLine(builder);
		//	ShowInventory();
		//	//builder.AppendFormat(" - {0}: {1}", "Strength", Strength);
		//	//builder.AppendFormat(" - {0}: {1}", "Intelect", Intelect);
		//	//builder.AppendFormat(" - {0}; {1}", "Agility", Agility);
		//}
	}
}