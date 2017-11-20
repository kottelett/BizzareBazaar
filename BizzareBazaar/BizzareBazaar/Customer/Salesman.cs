using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	class Salesman : Person
	{
		private string _name;
		private int _dailyQuota;


		public int NumberofSoldItems { get; set; }

		public string Name { get; set; }
		public int DailyQuota { get; set; }

		public Salesman(string name = "Default", int quota = 20)
		{
			_name = name;
			_dailyQuota = quota;
			
		}

		// TRÅD HER?
		public void CheckStorageForItems()
		{
			if (Global.ItemsForSale.Count != 0)
			{
				AddItemsToInventory(Global.ItemsForSale);
				Global.ItemsForSale.Clear();
			}
		}
	}


}
