using System;

namespace Bakery.Models
{
    public class Pastry
    {
        public int PastryPrice { get; set; }
        public int PastryQuantity { get; set; }

        public Pastry(int pastryQuantity)
        {
            PastryPrice = 2;
            PastryQuantity = pastryQuantity;
        }

        public int PastryDiscount()
        {
            int pastryDiscount = 0;
            if (PastryQuantity % 4 == 0)
            {
                pastryDiscount = (PastryQuantity / 4) * PastryPrice;
            }
            else if (PastryQuantity % 4 == 1)
            {
                pastryDiscount = ((PastryQuantity - 1) / 4) * PastryPrice;
            }
            else if (PastryQuantity % 4 == 2)
            {
                pastryDiscount = ((PastryQuantity - 2) / 4) * PastryPrice;
            }
            return pastryDiscount;
        }

        public int PastryTotalPrice()
        {
            int pastryTotalPrice = (PastryQuantity * PastryPrice) - PastryDiscount();
            return pastryTotalPrice;
        }
    }

}