namespace LibrairieConversionNote
{
    public class Class1
    {using System;  // using doit être en haut du fichier

namespace SDK_Laboratoire_1
    {
        class Program
        {
            // Méthode Main statique - Point d'entrée du programme
            static void Main(string[] args)
            {
                // Boucle infinie pour demander une note à l'utilisateur
                while (true)
                {
                    Console.WriteLine("Entrez une note alphabétique (A-G) ou tapez 'Q' pour quitter :");
                    string input = Console.ReadLine().ToUpper();  // Lire et convertir l'entrée utilisateur en majuscule

                    // Vérifier si l'utilisateur veut quitter
                    if (input == "Q")
                    {
                        Console.WriteLine("Programme terminé.");
                        break;  // Quitte la boucle si l'utilisateur tape 'Q'
                    }

                    // Appel de la méthode Transformer pour obtenir la note musicale
                    string resultat = Transformer(input);

                    // Afficher le résultat
                    Console.WriteLine(resultat);
                }
            }

            // Méthode pour convertir une lettre alphabétique en note musicale
            public static string Transformer(string noteAlphabetique)
            {
                switch (noteAlphabetique)
                {
                    case "A": return "LA";
                    case "B": return "SI";
                    case "C": return "DO";
                    case "D": return "RÉ";
                    case "E": return "MI";
                    case "F": return "FA";
                    case "G": return "SOL";
                    default: return "Erreur : La note n'existe pas.";
                }
            }
        }
    }












