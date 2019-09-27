using System;

namespace Bakery
{
    class Bakery
    {
        private int _breadBasePrice;
        public Bakery(int breadBasePrice)
        {
            _breadBasePrice = breadBasePrice;
        }
        public int GetBreadBasePrice()
        {
            return _breadBasePrice;
        }
        public bool breadDeal(int inputBreadOrder)
    }
    class Pastry
    {
        private int _pastryBasePrice;
    }
}