using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProject
{
    enum BeerType
    {
        LAGER, PILSNER, MÜNCHENER, WIENERDORTMUNDER, BOCK, DOBBELBOCK, PORTER, MIX
    }

    internal class Beer
    {
        string _Brewery;
        string _BeerName;
        BeerType _BeerType;
        int _Volume;
        double _Percent;

        string Brewery { get { return _Brewery; } set { _Brewery = value; } }
        string BeerName { get { return _BeerName; } set { _BeerName = value; } }
        public BeerType BeerType { get; set; }
        public int Volume { get { return _Volume; } set { _Volume = value; } }
        public double Percent {  get { return _Percent; } set { _Percent = value; } }
        public double Unit;

        public Beer ()
        {

        }

        public Beer(string brewery, string beerName, BeerType beerType, int volume, double percent, double unit)
        {
            Brewery = brewery;
            BeerName = beerName;
            BeerType = beerType;
            Volume = volume;
            Percent = percent;
            Unit = unit;
        }

        public void GetUnits()
        {
            double unit = ((Volume * Percent) / 150);
        }
        public override string ToString()
        {
            return $"Brewery: {Brewery}\nBeer: {BeerName}\nType: {BeerType}\nVolume of beer: {Volume}\nPercent of Alcohol: {Percent}\nUnit of Beer: {Unit}";
        }
            void Add(Beer otherBeer)
            {
                Volume += otherBeer.Volume;
            }
            public Beer Mix(Beer otherBeer)
            {
            int combinedVolume = Volume + otherBeer.Volume;
            double combinedPercent = (Volume * Percent + otherBeer.Volume * otherBeer.Percent) / (Volume + otherBeer.Volume);
            double combinedUnit = ((combinedVolume * combinedPercent) / 150);
            return new Beer($"{Brewery} {otherBeer.Brewery}", $"{BeerName} {otherBeer.BeerName}", BeerType.MIX, combinedVolume, combinedPercent, combinedUnit);
            }
            public static Beer Mix(Beer firstBeer, Beer otherBeer)
            {
            int combinedVolume = firstBeer.Volume + otherBeer.Volume;
            double combinedPercent = (firstBeer.Volume * firstBeer.Percent + otherBeer.Volume * otherBeer.Percent) / (firstBeer.Volume + otherBeer.Volume);
            double combinedUnit = ((combinedVolume * combinedPercent) / 150);
            return new Beer($"{firstBeer.Brewery} {otherBeer.Brewery}", $"{firstBeer.BeerName} {otherBeer.BeerName}", BeerType.MIX, combinedVolume, combinedPercent, combinedUnit);
            }

        public int CompareTo(Beer? obj)
        {
            return this.BeerName.CompareTo(((Beer)obj).BeerName);
        }
    }
}
