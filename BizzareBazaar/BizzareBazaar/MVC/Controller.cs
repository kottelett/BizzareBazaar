using System;
using System.Collections.Generic;
using System.Linq;


namespace BizzareBazaar
{
	class Controller
	{
		private readonly Customer _customerModel;
		private readonly Booth _boothModel;
		private readonly View _view;



	
		public Controller(Customer customer, Booth booth)
		{
			_customerModel = customer;
			_boothModel = booth;

			_view = new View();

			foreach (var item in booth.Inventory)
			{
				_view.PrintItem(item);
			}
		}

        
		public void InitiateBoothFetch() 
		{
			_boothModel.SetTimerAndFetchItems();
            
			
		}

	    public void ItemUpForSale()
	    {
	        if (_boothModel.Inventory.Count != 0)
	        {
	            IItem item = _boothModel.Inventory.First();
	            _view.ItemForSale(item, _boothModel);
	        }
	    }

	   

        public void MakeTransaction()
		{
			if (_boothModel.Inventory.Count != 0)
			{
			_customerModel.BuyItem(_boothModel);
			_view.PrintPersonDescription(_customerModel);
			_view.ItemBought(_customerModel.GetFirstItem(), _customerModel);
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


