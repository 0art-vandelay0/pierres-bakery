using System;

namespace Bakery.Models
{
    public class Pastry
    {
        public int PastryPrice { get; set; }
        public int PastryQuantiity { get; set; }

        public Pastry(int pastryQuantiity)
        {
            PastryPrice = 2;
            PastryQuantiity = pastryQuantiity;
        }

        public int PastryDiscount()
        {
            int pastryDiscount = 0;
            if (PastryQuantiity % 4 == 0)
            {
                pastryDiscount = (PastryQuantiity / 4) * PastryPrice;
            }
            else if (PastryQuantiity % 4 == 1)
            {
                pastryDiscount = ((PastryQuantiity - 1) / 4) * PastryPrice;
            }
            else if (PastryQuantiity % 4 == 2)
            {
                pastryDiscount = ((PastryQuantiity - 2) / 4) * PastryPrice;
            }
            return pastryDiscount;
        }
    }

}