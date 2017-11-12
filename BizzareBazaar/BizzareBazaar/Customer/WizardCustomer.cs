using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    
    class WizardCustomer : Customers 
    {
        public Double Strength { get; private set; }
        public Double Intelect { get; private set; }
        public Double Agility   { get; private set; }

        public WizardCustomer(double strength, double intelect, double agility)
        {
            Strength = strength;
            Intelect = intelect;
            Agility = agility; 
        }

        public override string GetClass()
        {
            return null;
        }

        public override void PrintInformation()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Wizard Stats\n");
            builder.AppendFormat(" - {0}: {1}", "Strength", Strength);
            builder.AppendFormat(" - {0}: {1}", "Intelect", Intelect);
            builder.AppendFormat(" - {0}; {1}", "Agility", Agility);

        }

    }
}
