using System;
using System.Linq;
using System.Text;

namespace BizzareBazaar
{
	abstract class Customer : Person
	{
		protected string CustomerGroup { get; set; }

		public void BuyItem(Booth booth)
		{
			if (booth.Inventory.Count != 0)
			{
				Inventory.Add(booth.Inventory.First());
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
		}


		public override void PrintBoothNumber()
		{
			Console.WriteLine();
		}

		public override string GetDescription()
		{
			return CustomerGroup;
		}

		public IItem GetLastItem()
		{
			return Inventory.Last();
		}
	}
}