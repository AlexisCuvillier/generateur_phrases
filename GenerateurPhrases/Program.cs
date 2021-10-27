using System;
using System.Collections.Generic;

namespace GenerateurPhrases
{
    class Program
    {

        static string ObtenirElementAleatoire(string[] t)
        {
            Random r = new Random();

            int i = r.Next(t.Length);

            return t[i];
        }
        static void Main(string[] args)
        {



            // phrase type : sujet verbes complement
            var sujets = new string[]{
                "Un lapin",
                "Un chien",
                "Une grand-mère",
                "Une fée",
                "Un magicien",
                "Une tortue",
                "Un bonhomme de neige",
                "Un loup",
                "Une limace"
            };

            var verbes = new string[]
            {
                "attrape",
                "regarde",
                "avale",
                "mange",
                "bois",
                "néttoie",
                "se bat avec",
                "s'accroche à",
                "vol"
            };

            var complements = new string[]
            {
                "un livre",
                "la lune",
                "le soleil",
                "une piscine",
                "un gateau",
                "une souris",
                "un crapeau",
                "le ciel",
                "un arbre",
                "un chien",
                "un verre"
            };

            const int NB_PHRASES = 100;
            int nbDoublon = 0;
            var listePhrase = new List<string>();

           while(listePhrase.Count < NB_PHRASES)
            {
                var sujet = ObtenirElementAleatoire(sujets);
                var verbe = ObtenirElementAleatoire(verbes);
                var complement = ObtenirElementAleatoire(complements);

                var phrase = sujet + " " + verbe + " " + complement;
                phrase = phrase.Replace("à le", "au");

               

                if (!listePhrase.Contains(phrase))
                {
                    listePhrase.Add(phrase);
                }
                else
                {
                    nbDoublon++;
                }
              
            }
            

            foreach (var phrase in listePhrase)
            {
                Console.WriteLine(phrase);
            }


            Console.WriteLine();
            Console.WriteLine("Nombre de phrases uniques : " + listePhrase.Count);
            Console.WriteLine("Nombre de doublon évités : " + nbDoublon);


            //  Console.WriteLine(phrase);

        }


    }

    }

