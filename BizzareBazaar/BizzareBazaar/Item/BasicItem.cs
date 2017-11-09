using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    public class IItem : IItem
    {
        private readonly double _price;
        private readonly string _description;

        public IItem(double price, string description)
        {
            _price = price;
            _description = description;
        }

        public string GetDescription()
        {
            return _description;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
