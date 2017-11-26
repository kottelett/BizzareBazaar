using System;
using System.Collections.Generic;

namespace BizzareBazaar
{
	public sealed class Singleton
	{
		private static volatile Singleton _instance;
		private static readonly Object Lock = new Object();

		public static List<IItem> Inventory { get; set; } = new List<IItem>();

		private Singleton()
		{
		}

		public static Singleton Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (Lock)
					{
						if (_instance == null)
							_instance = new Singleton();
					}
				}
				return _instance;
			}
		}
	}
}