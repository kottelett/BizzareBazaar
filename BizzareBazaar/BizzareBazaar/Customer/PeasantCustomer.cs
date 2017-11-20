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
	    public PeasantCustomer(string customerCustomerGroup)
	    {
		    CustomerGroup = customerCustomerGroup;
	    }


		//  public override void PrintInformation()
		//  {
		//PrintInformation(GetCustomerGroup());
		//  }

		/*public override void ShowInventory()
	    {
		    ShowInventory();
	    }*/
	    public override void PrintInformation()
	    {
		    Console.WriteLine(CustomerGroup.ToString());
	    }

    }
}
