using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizzareBazaar;
using NUnit.Framework;

namespace BazaarUnitTest
{
    [TestFixture]
   public class ItemCreatorTest
    {
        [Test]
        public void PositiveTest()
        {
            int x = 7;
            int y = 7;

            Assert.AreEqual(x, y);
        }

        [Test]
        public void NegativeTest()
        {
            if (true)
                Assert.Fail(("This is a failure"));

        }

        [Test]
        public void Test_Divide()
        {
            //Arrange 
            int expected = 5;
            int numerator = 20;
            int denumarator = 4;

            //Act
            

        }

        
    }
}
