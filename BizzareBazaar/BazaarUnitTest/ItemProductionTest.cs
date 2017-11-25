using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using BizzareBazaar;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace BazaarUnitTest
{
    [TestFixture]
   public class ItemProductionTest
    {


        // Testing unit testing itself with positivetest
        [Test]
        public void PositiveTest()
        {
            int x = 7;
            int y = 7;
            Assert.AreEqual(x, y);
        }

      
        // Tests if passed object is not null in storage
        [Test]
        public void StorageIsNotNull()
        {
            for (int i = 0; i < 10; i++)
            {
                ItemProduction.ProduceItems();
            }

            for (int i = 0; i < ItemProduction.Storage.Count; i++)
            {

                Assert.NotNull(ItemProduction.Storage[i]);
            }
        }

        //Tests if storage is not empty when storage is supposed to not be empty
        [Test]
        public void StorageIsNotEmpty()
        {
            for (int i = 0; i < 10; i++)
            {
                ItemProduction.ProduceItems();
            }

            Assert.IsNotEmpty(ItemProduction.Storage);

        } 



        //Tests if storage is already empty
        [Test]
        public void StorageIsEmpty()
        {
           

           Assert.IsEmpty(ItemProduction.Storage);
                            
        }
     

    }
}
 