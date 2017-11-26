using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
   public interface IItem
    {
        double GetPrice();

        string GetDescription();

        int GetItemNumber();
    }
}
