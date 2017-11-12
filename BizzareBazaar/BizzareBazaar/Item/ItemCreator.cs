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

        {


            Random rnd = new Random();
            int rndNum = rnd.Next(0, 2);

            for (int i = 0; i < decorators.Length; i++)
            {

                if (i == rndNum)
                {

                    switch (decorators[i])
                    {
                        case "BasicItem":
                            break;

                        case "Magic":
                            BasicItem = new MagicDecorator(BasicItem);
                            break;



                    }


                }


            }
            Console.WriteLine(rndNum);

            return BasicItem;

        }
    }
}