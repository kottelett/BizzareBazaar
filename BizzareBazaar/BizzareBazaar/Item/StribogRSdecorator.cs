using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class StribogRsDecorator : ItemDecorator
    {
        public StribogRsDecorator(IItem item) : base(item)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with Stribog runestone";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }
}