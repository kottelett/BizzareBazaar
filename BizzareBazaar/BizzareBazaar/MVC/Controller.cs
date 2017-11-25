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
		private readonly Object _lock = new Object();


	
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


		public void PutItemUpForSale(Booth booth)
		{
				if (booth.Inventory.Count != 0)
				{
					IItem item = booth.Inventory.First();
					_view.ItemForSale(item, booth);
				}
		}
		

		//public void PutItemUpForSale()
		//{
		//    for (int i = 0; i < _boothModel.Count; i++)
		//    {

		//        if (_boothModel.ElementAt(i).Inventory.Count != 0)
		//        {
		//            IItem item = _boothModel.ElementAt(i).Inventory.First();
		//            _view.ItemForSale(item, _boothModel[i]);
		//        }
		//    }
		//}

		//private void Transaction(int boothNumber)
		//{
		//	lock (_lock)
		//	{
		//		if (_boothModel.ElementAt(boothNumber).Inventory.Count != 0)
		//		{
		//			//Customer c = (Customer)_customerModel.ElementAt(boothNumber);
		//			((Customer)_customerModel.ElementAt(boothNumber)).BuyItem(_boothModel.ElementAt(boothNumber));
		//			_view.ItemBought(((Customer)_customerModel.ElementAt(boothNumber)).GetFirstItem(), ((Customer)_customerModel.ElementAt(boothNumber)), _boothModel.ElementAt(boothNumber));
		//			_boothModel.ElementAt(boothNumber).DailyQuota--; // Lag metode for dette i Booth
		//			// Lag metode for å sjekke om
		//			//SoldQuota = true;
		//		}

		//	}
		//}

  //      public void MakeTransaction()
		//{
			
		//    for (int i = 0; i < _boothModel.Count; i++)
		//    {
		//	    Transaction(i);
				
		//    }
		//} 
		public void MakeTransaction(Booth booth, Customer customer)
		{
			if (booth.Inventory.Count != 0)
			{
				customer.BuyItem(booth);
				booth.RemoveFirstItemFromInventory();
				//booth.Inventory.Remove(booth.Inventory.First());
				_view.ItemBought(customer.GetLastItem(), customer, booth);
				booth.DailyQuota--;
			}
		}

				
	}
}


