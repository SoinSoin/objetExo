using System;
using myApp.Objet;
namespace myApp
{
    class Program
    {
        public static string[] Prenoms = new string[] { "jean-eude", "pierre", "jean-yve le pas gentille", "freude", "brillant", "rodolphe", "mr lamort", "moise", "jesus", "boudha", "francois", "theodule" };


        static void Main(string[] args)
        {
            int alea = RandomHelper.GetRandom(1, 100);
            int rand = RandomHelper.GetRandom(0, Prenoms.Length - 1);

            Personnage Hero = new Personnage(Prenoms[rand], "Chevalier", "Hero", alea);
            Console.WriteLine($"{Hero.Niv},{Hero.Nom},{Hero.Atk},{Hero.Atkspe}");
            Personnage Mechant = new Personnage(Prenoms[rand], "Chevalier", "Hero", 1);



        }


    }
}

