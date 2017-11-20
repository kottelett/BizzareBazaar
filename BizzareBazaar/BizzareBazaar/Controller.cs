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
		private Customer _custormerModel;
		private Salesman _salesmanModel;
		private View _view;
		//private List<IItem> _inventoryItems;
		private List<Person> _salesmenOnBazaar;

		private List<Person> _customersOnBazaar;

		public Controller()
		{
			_custormerModel = new PeasantCustomer("Peasant");
			_salesmanModel = new Salesman("Salesman1", 10);
			_view = new View();
			Console.WriteLine(_view.ItemList);
		}

		public Controller(Customer c, Salesman s)
		{
			_custormerModel = c;
			_salesmanModel = s;
		}

		public void InitiateShopping()
		{
			// 
			_salesmanModel.CheckStorageForItems();
			Global.SetTimerAndFetchItems();
			// Creates list of salesmen and customers 
			_salesmenOnBazaar = createPersons(5, _salesmanModel);
			_customersOnBazaar = createPersons(5, _custormerModel);
		}

		public void MakeTransaction()
		{
			//Tråd?

			if (_salesmanModel.GetFirstItem() != null)
			{
				IItem firstItem = _salesmanModel.GetFirstItem();
				_custormerModel.AddOneItemToInventory(firstItem);
				_salesmanModel.RemoveFirstItemFromInventory();

				_view.ItemBought(firstItem, _custormerModel);

			}

		}

		private List<Person> createPersons (int numberOfPersons, Person param)
		{
			List<Person> list = new List<Person>();
			if (param.GetType() == typeof(Salesman))
			{
				for (int i = 0; i < numberOfPersons; i++)
				{
					string name = "salesman" + i;
					list.Add(new Salesman(name, Global.BOOTHDAILYQUOTA));
				}
			}
			else
			{
				for (int i = 0; i < numberOfPersons; i++)
				{
					string name = "customer" + i;
					//list.Add(CustomerFactory.CreateRandomCustomer(name));
					list.Add(CustomerFactory.CreateCustomer(CustomerClass.Peasant, "Peasant1"));
				}
			}
			
			return list;

		}
		
	}
}


