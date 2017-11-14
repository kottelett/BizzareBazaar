using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	class WizardCustomer : Customers
	{
		public WizardCustomer(double strength, double intelect, double agility)
		{
			//Strength = strength;
			//Intelect = intelect;
			//Agility = agility;
		}

		protected override string GetClass()
		{
			return null;
		}

		public override void PrintInformation()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("Wizard Stats\n");
		}
	}
}