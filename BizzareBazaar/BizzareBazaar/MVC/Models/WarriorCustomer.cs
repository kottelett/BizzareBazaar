﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	class WarriorCustomer : Customer
	{
		/*
		public WarriorCustomer(double strength, double intelect, double agility)
		{
			//Strength = strength;
			//Intelect = intelect;
			//Agility = agility;
		}
		*/

		public WarriorCustomer(string customerCustomerGroup) // customerCustomergroup??
		{
			CustomerGroup = customerCustomerGroup;
		}

		public override void PrintBoothNumber()
		{
			PrintInformation(GetCustomerGroup());
		}


	}
}