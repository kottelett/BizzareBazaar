using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class PeasantCustomer : Customer
    {
        public Double Strength { get; private set; }
        public Double Intelect { get; private set; }
        public Double Agility { get; private set; }

        public PeasantCustomer(double strength, double intelect, double agility)
        {
            Strength = strength;
            Intelect = intelect;
            Agility = agility;
        }

        protected override string GetClass()
        {
            return null;
        }

        /*public override void ShowInventory()
	    {
		    base.ShowInventory();
	    }*/
    }
}
