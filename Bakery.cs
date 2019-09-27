using System;

namespace Bakery.Deals
{
    class Bread
    {
        public int BreadOrder { get; set; }
        public int BreadTotal { get; set; }
        public Bread(int breadOrder, int breadTotal)
        {
            BreadOrder = breadOrder;
            BreadTotal = breadTotal;
        }
        public void BreadDeal(int breadOrder)
        {
            if (breadOrder == 1)
            {
                BreadTotal = 5;
            }
            else if (breadOrder == 2)
            {
                BreadTotal = 10;
            }
            else if (breadOrder == 0)
            {
                BreadTotal = 0;
            }
            else
            {
                BreadTotal = (breadOrder * 5) - 5;
            }
            
        }
    }
    class Pastry
    {
        public int PastryOrder { get; set; }
        public int PastryTotal { get; set; }
        public Pastry(int pastryOrder, int pastryTotal)
        {
            PastryOrder = pastryOrder;
            PastryTotal = pastryTotal;
        }
        public void PastryDeal(int pastryOrder)
        {
            if (pastryOrder == 1)
            {
                PastryTotal = 2;
            }
            else if (pastryOrder == 2)
            {
                PastryTotal = 4;
            }
            else if (pastryOrder == 0)
            {
                PastryTotal = 0;
            }
            else
            {
                PastryTotal = (pastryOrder * 3) - 1;
            }
        }
    }
}