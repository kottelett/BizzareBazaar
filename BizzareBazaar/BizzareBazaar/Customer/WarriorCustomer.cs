using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar.Customer
{
	class WarriorCustomer : Customers
	{
		public WarriorCustomer(double strength, double intelect, double agility)
		{
			//Strength = strength;
			//Intelect = intelect;
			//Agility = agility;
		}

		protected override string GetClass()
		{
			return null;
		}
	}
}