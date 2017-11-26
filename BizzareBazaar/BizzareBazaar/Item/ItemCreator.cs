using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizzareBazaar
{
    class ItemCreator
    {
        string[] decorators = { "Basic item", "Magic item",
            "Epic Magic item", "Stribog Runestone",
            "Greater Stribog Runestone","Devana Runestone",
            "Greater Devana Runestone", "Sannesh Runestone", "Greater Sannesh Runestone"};

        public IItem CreateRndItem(int itemNumber)
        {

            IItem basicItem = new BasicItem(10, "BasicItem", itemNumber);

            Random rnd = new Random();
            int rndNum = rnd.Next(0, 10);

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

                        case "Epic Magic item":
                            basicItem = new EpicMagicDamageDecorator(basicItem);
                            break;

                        case "Devana Runestone":
                            basicItem = new DevanaRsDecorator(basicItem);
                            break;

                        case "Greater Devana Runestone":
                            basicItem = new GreaterDevanaRsDecorator(basicItem);
                            break;


                        case "Stribog Runestone":
                            basicItem = new StribogRsDecorator(basicItem);
                            break;
                        case "Greater Stribog Runestone":
                            basicItem = new GreaterStribogRsDecorator(basicItem);
                            break;
                        case "Sannesh Runestone":
                            basicItem = new SanneshRsDecorator(basicItem);
                            break;
                        case "Greater Sannesh Runestone":
                            basicItem= new GreaterSanneshRsDecorator(basicItem);
                            break;
                    }


                }


            }

            return basicItem;
        }
    }
}