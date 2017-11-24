using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	abstract class Customer : Person
	{

		protected string CustomerGroup { get; set; }
		//protected double Strength;
		//protected double Intelect;
		//protected double Agility;

		// tråd
		public void BuyItem(Booth booth)
		{
			if(booth.Inventory.Count != 0)
			{ 
			    IItem item = booth.Inventory.First();
			    Inventory.Add(item);
			    booth.Inventory.Remove(item);
			}
		}


		protected string GetCustomerGroup()
		{
			return CustomerGroup;
		}


		public virtual void ShowInventory()
		{
			foreach (var item in Inventory)
			{
				Console.WriteLine(item.GetDescription());
			}
		}



		public virtual void PrintInformation(string customerClass)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("CustomerGroup: " + GetCustomerGroup() + "\n");


			//	Console.WriteLine(builder);
			//	ShowInventory();
			//	//builder.AppendFormat(" - {0}: {1}", "Strength", Strength);
			//	//builder.AppendFormat(" - {0}: {1}", "Intelect", Intelect);
			//	//builder.AppendFormat(" - {0}; {1}", "Agility", Agility);
			//}
		}


		public override void PrintBoothNumber()
		{
			Console.WriteLine();
		}

	    public override string GetDescription()
	    {
	        return CustomerGroup;
	    }





	}
}