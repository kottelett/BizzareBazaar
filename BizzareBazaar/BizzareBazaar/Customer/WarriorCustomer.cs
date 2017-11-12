using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar.Customer
{
    class WarriorCustomer : Customers
    {
        public Double Strength { get; private set; }
        public Double Intelect { get; private set; }
        public Double Agility { get; private set; }

        public WarriorCustomer(double strength, double intelect, double agility)
        {
            Strength = strength;
            Intelect = intelect;
            Agility = agility;
        }

        public override string GetClass()
        {
            return null;
        }
    }
}
