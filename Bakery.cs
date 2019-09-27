using System;

namespace Bakery.Deals
{
    class Bread
    {
        public int BreadBasePrice { get; set; }
        public Bread(int breadBasePrice)
        {
            BreadBasePrice = breadBasePrice;
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
        public int PastryBasePrice { get; set; }
        public Pastry(int pastryBasePrice)
        {
            PastryBasePrice = pastryBasePrice;
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