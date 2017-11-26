using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;


namespace BizzareBazaar
{
	class Controller
	{
		//private readonly List<Person> _customerModel;
		//private readonly List<Booth> _boothModel;
		private readonly View _view;
		private readonly Object _lock = new Object();


		//public Controller(Customer customer, Booth booth)
		//{
		//	_customerModel = customer;
		//	_boothModel = booth;

		//	_view = new View();
		//} 

		public Controller()
		{
			//_customerModel = customers;
			//_boothModel = booths;

			_view = new View();
		}


		public void InitiateBoothFetch(List<Booth> boothModel)
		{
			foreach (var booth in boothModel)
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
				lock (_lock)
				{
					IItem item = booth.Inventory.First();
				
					_view.ItemForSale(item, booth);
				}
			}
		}
		
		public void MakeTransactionsOnList(List<Booth> booths, List<Person> customers)
		{
			Random randomBooth = new Random();
			Random randomCustomer = new Random();
			lock (_lock)
			{
				MakeTransaction(booths.ElementAt(randomBooth.Next(0, booths.Count)),
					(Customer) customers.ElementAt(randomCustomer.Next(0, customers.Count)));
			}
		}
		
		public void MakeTransaction(Booth booth, Customer customer)
		{
			
				if (booth.Inventory.Count != 0)
				{
					customer.BuyItem(booth);
					booth.RemoveFirstItemFromInventory();
					//booth.Inventory.Remove(booth.Inventory.First());
					lock (_lock)
					{
						_view.ItemBought(customer.GetLastItem(), customer, booth);
					}
					booth.DailyQuota--;
				}
			
		}
	}
}