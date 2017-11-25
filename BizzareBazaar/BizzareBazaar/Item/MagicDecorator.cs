using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class MagicDecorator : ItemDecorator
    {
        public MagicDecorator(IItem item) : base(item)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + extra magic damage";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }
}
