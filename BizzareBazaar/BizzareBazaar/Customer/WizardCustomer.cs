using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	class WizardCustomer : Customer
	{
		/*
		public WizardCustomer(double strength, double intelect, double agility)
		{
			//Strength = strength;
			//Intelect = intelect;
			//Agility = agility;
		}
		*/

		public WizardCustomer(string customerClass)
		{
			Class = customerClass;
		}


		public override void PrintInformation()
		{
			PrintInformation(GetClass());
		}
	}
}