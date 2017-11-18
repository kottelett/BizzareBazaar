using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace BizzareBazaar
{
	class Controller
	{
		private Model _custormerModel;
		private Model _salesmanModel;
		private View _view;
		//private List<IItem> _inventoryItems;

		public Controller()
		{
			_custormerModel = new Model();
			_view = new View();
			Console.WriteLine(_view.ItemList);
		}

		//public void UpdateInventory(List< IItem> items)
		//{
		//	_custormerModel.Customer.
		//}

		public void AddItemToInventory(IItem item)
		{
			_custormerModel.Customer.AddOneItemToInventory(item);
		}

		public void ResetInventory(List<IItem> items)
		{
			
		}
	}
}
