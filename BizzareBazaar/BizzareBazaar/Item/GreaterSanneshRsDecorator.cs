using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class GreaterSanneshRsDecorator : ItemDecorator
    {
        public GreaterSanneshRsDecorator(IItem item) : base(item)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with Greater Sannesh Runestone(Kel`Thuzad quest item ;)";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }
}