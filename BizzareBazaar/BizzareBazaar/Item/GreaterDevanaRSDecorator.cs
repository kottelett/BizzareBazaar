using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class GreaterDevanaRsDecorator : ItemDecorator
    {
        public GreaterDevanaRsDecorator(IItem item) : base(item)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with Greater Devana Runestone";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }
}