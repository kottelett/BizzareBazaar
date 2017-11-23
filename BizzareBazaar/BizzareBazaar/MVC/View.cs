using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	class View 
	{
		public View() // ???
		{
			
		}


		public void PrintItem(IItem item)
		{
			Console.WriteLine(item.GetDescription() + " | Price: " + item.GetPrice());

		}


		public void ItemBought(IItem item, Person customerName)
		{
			customerName.PrintBoothNumber();
			Console.WriteLine(" bought " + "Item # " +item.GetItemNumber() + item.GetDescription());
		}

		public void ItemForSale(IItem item, Booth booth)
		{
			Console.WriteLine(item.GetDescription() + " can now be bought from " + booth.BoothNumber);
		}
         
		public void PrintPersonDescription(Person person)
		{
			person.PrintBoothNumber();
		}

	    
    }
}
