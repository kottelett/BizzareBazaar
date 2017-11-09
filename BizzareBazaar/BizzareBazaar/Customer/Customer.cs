<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
	
    abstract class Customer
    {
	    protected List<IItem> Inventory { get; set; } = new List<IItem>();

	    public virtual void ShowInventory()
	    {
		    Console.WriteLine(Inventory.ToString());
	    }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{

    abstract class Customer
    {
        List<IItem> inventory = new List<IItem>();

        protected List<IItem> Inventory { get => inventory; set => inventory = value; }

        public virtual void ShowInventory()
        {
            Console.WriteLine(inventory.ToString());
        }
    }
}
>>>>>>> d5041be1870d0b69ec33697b1a76249b859644d5
