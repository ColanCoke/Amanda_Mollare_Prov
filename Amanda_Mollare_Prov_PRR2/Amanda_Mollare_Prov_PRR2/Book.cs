using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amanda_Mollare_Prov_PRR2
{
    class Books//skapade en klass för books enligt instruktioner
    {
        //följer till större delen instruktionerna
        public int price;

        //gjorde en lista för namn att slumpa från. Jag hade för kul med namnen haha.
        List<string> name = new List<string>() {"Dungeoner",
            "Caller Of Stones",
            "Larry Pooter and The Crazy Hooters",
            "Mein Svampf",
            "Mikael: The Biografy",
            "Hoars E Shote And The Windchimes",
            "Internet Meanie",
            "Trololo's Guide To Shoes",
            "The Magicioner",
            "The Starving Play",
            "Moonrise",
            "One Hundred Shades Of Moron",
            "Random Manga"};

        //en int för att kunna använda för att randomisera namnet och göra det lätt att skriva ut det.
        int randomName;

        int rarity;

        string category;

        int actualValue;

        bool cursed;

        Random generator;



        public void Book()
        {
            actualValue = generator.Next(20, 500);

            rarity = generator.Next(1, 100);

            var isCursed = generator.Next(1, 100);

            //en if för att se om itemet är cursed (med en 80% failsafe)
            if (isCursed > 20)
            {
                cursed = false;
            }
            else if (isCursed < 20)
            {
                cursed = true;
            }

            randomName = generator.Next(name.Count);

        }

        public void PrintInfo()
        {
            Console.WriteLine(actualValue);
            Console.WriteLine(rarity);
            Console.WriteLine(cursed);
            Console.WriteLine((string)name[randomName]);
        }

        public int Evaluate()
        {
            price = (actualValue * rarity);

            return price;
        }

        public string GetCategory()
        {
            return "hi";
        }

        public string GetName()
        {
            return "hi";
        }

        public bool IsCursed()
        {
            return true;
        }
    }
}
