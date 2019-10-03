using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amanda_Mollare_Prov_PRR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A costumer comes in wanting to sell a book.");
            Console.WriteLine("Do you want to evaluate it?");

            string yesno = Console.ReadLine().ToLower(); //simpelt. En metod som skickar ut Yes eller No som en string till metoden som kallade på YesNo.

            while ((yesno != "no") && (yesno != "yes"))//Göt en while-loop så att spelaren inte kan skriva annat än yes eller no
            {
                Console.WriteLine("Please write only Yes or No.");

                yesno = Console.ReadLine().ToLower();//gör en toLower för att göra så att spelarens typografi(caps tex) inte spelar någon roll.
            }

            if (yesno == "yes")
            {
                Console.WriteLine("You look at the book, caressing its old covers...");
            }
            else if (yesno == "no")
            {
                Console.WriteLine("You throw the book away with a 'Nyeh!'.");
            }


            Console.ReadLine();
        }
    }
}
