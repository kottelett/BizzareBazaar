using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	class Model
	{

		private Customer customer;
		
		// Constructor
		public Model(Customer customer)
		{
			this.customer = customer;
		}
	

		// Prop
		//public List<IItem> Inventory { get; set; }
		public Customer Customer { get; set; }


		// Methods
		
	}
}
