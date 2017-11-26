using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class SanneshRsDecorator : ItemDecorator
    {
        public SanneshRsDecorator(IItem item) : base(item)
        {

        }

        public override string GetDescription()
        { 
            return base.GetDescription() + " | Sannnesh Runestone(Ragnaros quest item)";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }
}