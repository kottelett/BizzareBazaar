﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	class WarriorCustomer : Customer
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