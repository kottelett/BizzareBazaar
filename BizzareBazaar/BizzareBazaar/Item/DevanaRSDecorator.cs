using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class DevanaRsDecorator : ItemDecorator
    {
        public DevanaRsDecorator(IItem item) : base(item)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with Devana runestone";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }
}