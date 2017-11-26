using BizzareBazaar;
using NUnit.Framework;

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
				ItemProduction.ProduceItem();
			}

			for (int i = 0; i < Singleton.Inventory.Count; i++)
			{
				Assert.NotNull(Singleton.Inventory[i]);
			}
		}

		//Tests if storage is not empty when storage is supposed to not be empty
		[Test]
		public void StorageIsNotEmpty()
		{
			for (int i = 0; i < 10; i++)
			{
				ItemProduction.ProduceItem();
			}

			Assert.IsNotEmpty(Singleton.Inventory);
		}

		//Tests if storage is already empty
		[Test]
		public void StorageIsEmpty()
		{
			Assert.IsEmpty(Singleton.Inventory);
		}
	}
}