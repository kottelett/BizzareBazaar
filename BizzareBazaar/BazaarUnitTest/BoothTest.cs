using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizzareBazaar;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace BazaarUnitTest
{
   [TestFixture]    
   public class BoothTest
    {
        
        [Test]
        public void boothtest()
        {
            Booth booth = new Booth(1, 10);
        }


    }
}
