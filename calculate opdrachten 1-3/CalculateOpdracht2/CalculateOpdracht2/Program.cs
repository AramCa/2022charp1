using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //we gaan nu dingen kopen

            int controllersInMandje = 0;

            controllersInMandje = +2; 


            //koop 2 controllers


            //hij is in voorraad snel kopen!
            int ps5 = 0;

            ps5++;

            //koop 1 ps5


            //koop de games:

            int eldenRing = 0;

            int shantae = 0;

            int spongebob = 0;

            eldenRing++;
            shantae++;
            spongebob++;

            shantae--;


            //hmmm weten we het zeker?
            //haal 1 game weg met -- of -= 1

            //nu nog de prijs


            double ps5Prijs = 499.99;
            double controllerPrijs = 69.99;
            double gamePrijs = 59.99;



            double totaalControllerPrijs = 0;// controllersInMandje keer controllerPrijs
            gamePrijs = 0;// game1 keer gamePrijs  + game2 keer gamePrijs (let op je haakjes!)

            totaalControllerPrijs = 69.99 * 2;
            gamePrijs = (1 * 59.99) + (1 * 59.99); 



            double totaalPrijs = 0;// tel hier alles bij elkaar op

            totaalPrijs = totaalControllerPrijs + gamePrijs + ps5Prijs;

            Console.WriteLine(totaalPrijs);

            //er moet nu 759.95 staan
        }
    }
}