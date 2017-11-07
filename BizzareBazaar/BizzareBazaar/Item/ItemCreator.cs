using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class ItemCreator
    {
        string[] decorators = { "BasicItem", "Magic" };
        IItem item;
        public IItem CreateRndItem()
        {

            Random rnd = new Random();
            for (int i = 0; i < decorators.Length ; i++)
            {
                if (i == rnd.Next(0, 2))
                {

                    switch (decorators[i])
                    {
                        case "BasicItem":
                            item = new BasicItem(10, "BasicItem");
                            break;


                        case "Magic":
                            item = new MagicDecorator(item);
                            break;



                    }

                }

            }
            return item;

        }
    }
}