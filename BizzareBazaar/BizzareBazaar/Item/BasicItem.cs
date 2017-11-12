using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    public class BasicItem : IItem
    {
        private readonly double _price;
        private readonly string _description;
        private readonly int _ItemNumber;

        public BasicItem(double price, string description, int ItemNumber)
        {
            _ItemNumber = ItemNumber;
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

        public int GetItemNumber()
        {
            return _ItemNumber;
        }
    }
}
