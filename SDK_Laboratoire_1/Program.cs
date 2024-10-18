using System;
using LibrairieConversionNote;  // Assurez-vous que votre librairie est bien référencée

namespace SDK_Laboratoire1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instance de la classe de conversion de la librairie
            var convertisseur = new ConversionAlphabetiqueToNote();

            while (true)  // Boucle infinie pour demander des entrées
            {
                Console.WriteLine("Quel type de conversion voulez-vous faire ? Tapez 'NOTE' pour la conversion alphabétique vers note musicale.");
                string typeConversion = Console.ReadLine().ToUpper();  // Lit la saisie de l'utilisateur et la convertit en majuscule

                // Vérification si l'utilisateur veut faire une conversion de note
                if (typeConversion == "NOTE")
                {
                    while (true)  // Boucle pour demander les notes
                    {
                        Console.WriteLine("Entrez une note alphabétique (A-G) ou appuyez sur CTRL+C pour quitter :");
                        string noteAlphabetique = Console.ReadLine().ToUpper();  // Lire l'entrée utilisateur et la convertir en majuscule

                        // Appel de la méthode Transformer de la librairie pour convertir la note
                        string resultat = convertisseur.Transformer(noteAlphabetique);

                        // Affichage du résultat (note musicale ou message d'erreur)
                        Console.WriteLine(resultat);
                    }
                }
                else
                {
                    Console.WriteLine("Commande non reconnue. Veuillez entrer 'NOTE'.");
                }
            }
        }
    }
}

