﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class Program
    {
        public static void Main(string[] args)
        {
            Booth booth1 = new Booth();
            booth1.RequestItem();
            booth1.PrintInventory();


        }
    }
}
