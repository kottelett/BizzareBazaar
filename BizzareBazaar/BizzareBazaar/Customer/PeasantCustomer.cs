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
	    public PeasantCustomer(string customerClass)
	    {
		    Class = customerClass;
	    }
        

	    public override void PrintInformation()
	    {
			PrintInformation(GetClass());
	    }

	    /*public override void ShowInventory()
	    {
		    ShowInventory();
	    }*/
    }
}
