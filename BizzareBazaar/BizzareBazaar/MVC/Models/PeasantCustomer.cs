using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class PeasantCustomer : Customer
    {

		/*
        public PeasantCustomer(double strength, double intelect, double agility)
        {
            Strength = strength;
            Intelect = intelect;
            Agility = agility;
        }
		*/
	    public PeasantCustomer(string customerCustomerGroup) // group?
	    {
		    CustomerGroup = customerCustomerGroup;
	    }


		//  public override void PrintBoothNumber()
		//  {
		//PrintBoothNumber(GetCustomerGroup());
		//  }

		/*public override void ShowInventory()
	    {
		    ShowInventory();
	    }*/
	    public override void PrintBoothNumber()
	    {
		    Console.Write(CustomerGroup); // customergroup?
	    }

    }
}
