using System;
/*using System.Globalization; fait appel à une librairie pour que tous les mots soit transformaé avec majuscule au début */
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliDeNoel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black; /* couleur du texte */
            Console.BackgroundColor = ConsoleColor.White; /* couleur du fond */
            Console.SetCursorPosition(20, 1);
            Console.WriteLine("---> Trouvez le BUG <---\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Tentez de déceler quel composant de l'ordinateur de Billy est HS \nparmis ces différentes propositions : \n");
            string[] composants = new string[] { "écran", "batterie", "clavier", "chargeur", "disque dur", "carte mère", "barrette de RAM" };
            foreach (string bug in composants)
            {
                Console.WriteLine(bug);
            }
            Random randomized = new Random();
            int index = randomized.Next(composants.Length);
            /*string leBug = composants[3];*/
            Console.WriteLine("\nVotre réponse :");
            string userAnswer = Console.ReadLine();
            int counter = 0;
            while (userAnswer != composants[index]) /* tant que la réponse de l'utilisateur n'est pas la bonne réponse, lui demander de réessayer */
            {
                Console.WriteLine("C'est pas ça !");
                counter++;
                Console.WriteLine("\nRéessayez :");
                userAnswer = Console.ReadLine();
            }


            if (userAnswer == composants[1] || userAnswer == composants[5] || userAnswer == composants[6]) /* au féminin */ 
            {
                Console.WriteLine($"Bravo ! Tu as trouvé le composant défaillant en {counter} coup(s) ! \n\nTu n'as plus qu'à lui acheter une nouvelle {composants[index]} pour Noël !");
            }
            else /* au masculin */
            {
                Console.WriteLine($"\nBravo ! Tu as trouvé le composant défaillant en {counter} coup(s) ! \nTu n'as plus qu'à lui acheter un nouveau {composants[index]} pour Noël !");
            }

            /* Pour créer symboles : \x..  numéro du symbol */

            /* CultureInfo.CurrentCulture.TextInfo.ToTitleCase(userCommand)*/

            /* System.Threading.Thread.Sleep(4000); ---> pause */

            /*Random randomized = new Random;
            int indexDuTableau = randomized.Next(composants.Length);*/

        }
    }
}
