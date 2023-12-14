using System.Collections.Generic;
using System;
using System.Globalization;

namespace BeerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Beer> beers = new List<Beer>();

            Beer beer1 = new Beer("Barnerby", "Schwartz", BeerType.LAGER, 50, 15, 300);
            beers.Add(beer1);

            Beer beer2 = new Beer("Harrisons", "Lime Light", BeerType.PORTER, 75, 6, 120);
            beers.Add(beer2);

            Beer beer3 = Beer.Mix(beer1, beer2);
            beers.Add(beer3);

            foreach (Beer b in beers)
            {
                Console.WriteLine(b.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine("Sorted by Units: ");
            beers.Sort(new SortingBeerBy(SortBy.UNIT));
            foreach (Beer b in beers)
            {
                Console.WriteLine(b.ToString());
            }

            Console.ReadLine();
        }
    }
}
