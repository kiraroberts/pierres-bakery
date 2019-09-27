using System;

namespace Bakery
{
    class Bread
    {
        private int _breadBasePrice;
        public Bread(int breadBasePrice)
        {
            _breadBasePrice = breadBasePrice;
        }
        public int GetBreadBasePrice()
        {
            return _breadBasePrice;
        }
        public int breadDeal(int inputBreadOrder)
        {
            if (inputBreadOrder == 1)
            {
                return 5;
            }
            else if (inputBreadOrder => 2)
            {
                return (inputBreadOrder * 5) - 5;
            }
        }
    }
    class Pastry
    {
        private int _pastryBasePrice;
        public Pastry(int PastryBasePrice)
        {
            _pastryBasePrice = pastryBasePrice;
        }
        public int GetPastryBasePrice()
        {
            return _pastryBasePrice;
        }
        public int pastryDeal(int inputPastryOrder)
        {
            if (inputPastryOrder == 1)
            {
                return 2;
            }
            else if (inputPastryOrder => 3)
            {
                return (inputPastryOrder * 2) - 1;
            }
        }
    }
}