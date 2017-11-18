using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	class View
	{
		public View()
		{
			
		}

		public List<IItem> ItemList { get; set; }

		private void GetList(List<IItem> list)
		{
			
		}

		public static void PrintItem(IItem item)
		{
			Console.WriteLine(item.GetDescription() + " | Price: " + item.GetPrice());

		}

		
	}
}
