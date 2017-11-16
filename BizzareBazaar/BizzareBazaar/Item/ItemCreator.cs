using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class ItemCreator
    {
        string[] decorators = { "Basic item", "Magic item" };

        public IItem CreateRndItem(int itemNumber)
        {

            IItem basicItem = new BasicItem(10, "BasicItem", itemNumber);

            Random rnd = new Random();
            int rndNum = rnd.Next(0, 2);

            for (int i = 0; i < decorators.Length; i++)
            {

                if (i == rndNum)
                {

                    switch (decorators[i])
                    {
                        case "Basic item":
                            break;

                        case "Magic item":
                            basicItem = new MagicDecorator(basicItem);
                            break;
                    }


                }


            }

            return basicItem;

        }




    }
}