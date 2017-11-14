using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	abstract class Customers
	{
		protected List<BasicItem> Inventory { get; set; } =
			new List<BasicItem>();

		protected string Class { get; set; }
		//protected double Strength;
		//protected double Intelect;
		//protected double Agility;


		protected virtual string GetClass()
		{
			return Class;
		}

		public virtual void PrintInformation()
		{
			Console.WriteLine("Overrided text");
		}

		public virtual void ShowInventory()
		{
			Console.WriteLine(Inventory.ToString());
		}

		public void PrintInformation(string customerClass)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("Stats"+ customerClass + "\n");

			Console.WriteLine(builder);
			//builder.AppendFormat(" - {0}: {1}", "Strength", Strength);
			//builder.AppendFormat(" - {0}: {1}", "Intelect", Intelect);
			//builder.AppendFormat(" - {0}; {1}", "Agility", Agility);
		}
	}
}