using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace BizzareBazaar
{
	class Booth : IManipulateInventory
	{


	   public List<IItem> Inventory { get; set; } = new List<IItem>();
		

		public int BoothNumber { get; set; }


	    public bool SoldQuota = false;



		public Booth(int quota, int boothNumber)
		{
			DailyQuota = quota;
			BoothNumber = boothNumber;
		}


		public IItem GetFirstItem()
		{
			return Inventory.First();
		}
		public void AddOneItemToInventory(IItem item)
		{
			Inventory.Add(item);
		}

		public void AddItemsToInventory(List<IItem> itemList)
		{
			Inventory.AddRange(itemList);
		}

		public void RemoveFirstItemFromInventory() // Finnes egen metoder for det i list
		{
			Inventory.RemoveAt(0);
			//Inventory.Remove(Inventory.First());
		}

		public void SetTimerAndFetchItems()
		{

		}

		public void FetchFirstItem()
		{

            {
		        //IItem item = ItemProduction.Storage.First();
		        Inventory.Add(Singleton.Inventory.First());
	            Singleton.Inventory.Remove(Singleton.Inventory.First());
		       // PrintItem(item);
	            //DEBUG
              Console.WriteLine("Booth" + BoothNumber + " daily quota: " + DailyQuota);
            }
            
		    if (DailyQuota <= 0)
		    {
		        _timer.Stop();
				_timer.Dispose();
				//DEBUG
				Console.WriteLine("DEBUG: Timer stopped at booth " + BoothNumber);
		    }
		}

		public void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			if (Singleton.Inventory.Count != 0 && DailyQuota > 0)
			{
				FetchFirstItem();
			}
		}

        //tråd 
	    public IItem ItemUpForSale()
	    {
	        //IItem item = Inventory.First();

		    return Inventory.First();
	    }


		// Fjernes fra Interface?
		public string GetDescription()
		{
		    String info = "Booth#" + BoothNumber;

		    return info;
		}


        //La stå
	    public void PrintItem(IItem item)
	    {
	        Console.WriteLine("Item# " + item.GetItemNumber() + " " + item.GetDescription() + "Price is: " + item.GetPrice());
	    }
	}
}
