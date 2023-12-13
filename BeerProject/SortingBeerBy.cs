using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProject
{
    enum SortBy
    {
        UNIT, PERCENT, VOLUME
    }
    internal class SortingBeerBy : IComparer<Beer>
    {
        private SortBy Value;
        public SortingBeerBy(SortBy value)
        {
            this.Value = value;
        }
        public int Compare(Beer x, Beer y)
        {
            switch (Value)
            {
                case SortBy.UNIT:
                    return x.Unit.CompareTo(y.Unit);
                case SortBy.PERCENT:
                    return x.Percent.CompareTo(y.Percent);
                case SortBy.VOLUME:
                    return x.Volume.CompareTo(y.Volume);
            }
            return 0;
        }
    }
}
