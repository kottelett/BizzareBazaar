using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;


namespace BizzareBazaar
{
	class Controller
	{
		private readonly List<Person> _customerModel;
		private readonly List<Booth> _boothModel;
		private readonly View _view;



	
		//public Controller(Customer customer, Booth booth)
		//{
		//	_customerModel = customer;
		//	_boothModel = booth;

		//	_view = new View();
		//} 

	    public Controller(List<Person> customers, List<Booth> booths)
	    {
	        _customerModel = customers;
	        _boothModel = booths;

	        _view = new View();
	        
        }


        public void InitiateBoothFetch() 
		{
			foreach (var booth in _boothModel)
			{
				booth.SetTimerAndFetchItems();
			}
		    //for (int i = 0; i < _boothModel.Count; i++)
		    //{
		    //    _boothModel.ElementAt(i).SetTimerAndFetchItems();
		    //}


		}

	    public void ItemUpForSale()
	    {
	        for (int i = 0; i < _boothModel.Count; i++)
	        {

	            if (_boothModel.ElementAt(i).Inventory.Count != 0)
	            {
	                IItem item = _boothModel.ElementAt(i).Inventory.First();
	                _view.ItemForSale(item, _boothModel[i]);
	            }
	        }
	    }

	   

        public void MakeTransaction()
		{

		    for (int i = 0; i < _boothModel.Count; i++)
		    {

		        if (_boothModel.ElementAt(i).Inventory.Count != 0)
		        {
                    Customer c = (Customer) _customerModel.ElementAt(i);
                    c.BuyItem(_boothModel.ElementAt(i));
		            _view.ItemBought(c.GetFirstItem(), c, _boothModel.ElementAt(i));
			        _boothModel.ElementAt(i).DailyQuota--; // Lag metode for dette i Booth
					// Lag metode for å sjekke om
			        //SoldQuota = true;
				}
		    }
		} 

				
	}
}


