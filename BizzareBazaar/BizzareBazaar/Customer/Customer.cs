using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{

    abstract class Customer
    {
        protected List<BasicItem> Inventory { get ; set ; } = new List<BasicItem>();
		
		protected string Class { get; set; }
		//protected double Strength;
    }
}
