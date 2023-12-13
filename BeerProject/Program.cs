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

            Beer beer1 = new Beer("", "", BeerType.LAGER, 50, 15, 300);
            beers.Add(beer1);
            beers.Add(new Beer());
            beers.Add(new Beer());

            foreach (Beer b in beers)
            {
                Console.WriteLine(b.ToString());
            }

            Console.WriteLine("Sorted by Mix: ");
            beers.Sort(new SortingBeerBy(SortBy.UNIT));
            foreach (Beer b in beers)
            {
                Console.WriteLine(b.ToString());
            }

            Console.ReadLine();
        }
    }
}
