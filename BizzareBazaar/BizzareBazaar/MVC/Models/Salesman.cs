using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	class Salesman : Person
	{
		



		public string Name { get; set; }
		public int DailyQuota { get; set; } 

		public Salesman(string name = "Default", int quota = 20)
		{
			Name = name;
			DailyQuota = quota;
			
		}

		// TRÅD HER?
		public void CheckStorageForItems() // ???
		{
			if (Global.ItemsForSale.Count != 0)
			{
				AddItemsToInventory(Global.ItemsForSale);
				Global.ItemsForSale.Clear();
			}
		}

		public override void PrintInformation()
		{
			Console.Write("The salesman " + Name);
		}
	}


}
