using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;

namespace BizzareBazaar
{
	class Controller
	{
		private readonly Customer _custormerModel;
		private readonly Booth _boothModel;
		private readonly View _view;
		//private List<Person> _salesmenOnBazaar; // ???

		private List<Person> _customersOnBazaar; // ???

		public Controller() // ???
		{
			_custormerModel = new PeasantCustomer("Peasant");
			_boothModel = new Booth(10);
			_view = new View();
			Console.WriteLine(_view.ItemList);
		}

		public Controller(Customer c, Booth s)
		{
			_custormerModel = c;
			_boothModel = s;
			_view = new View();
			//_view.ShowInventory(Global.ItemsForSale);
			foreach (var item in s.Inventory)
			{
				_view.PrintItem(item);
			}
		}

		public void InitiateShopping()
		{
			_boothModel.SetTimerAndFetchItems();
			// Creates random list of salesmen and customers 
			//_salesmenOnBazaar = createPersons(5, _boothModel);
			_customersOnBazaar = createPersons(5);
		}

		public void MakeTransaction()
		{
			if (_boothModel.Inventory.Count != 0)
			{
			_custormerModel.BuyItem(_boothModel);
			_view.PrintDescription(_custormerModel);
			_view.ItemBought(_custormerModel.GetFirstItem(), _custormerModel);
			}
		}

		
		// Kanskje ikke controller-funksjonalitet?
		private List<Person> createPersons (int numberOfPersons)
		{
			List<Person> list = new List<Person>();
			
				for (int i = 0; i < numberOfPersons; i++)
				{
					string name = "customer" + i; // ???
					list.Add(CustomerFactory.CreateCustomer(CustomerClass.Peasant, name));
				}
			
			return list;

		}
		
	}
}


