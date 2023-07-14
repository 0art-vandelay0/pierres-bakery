using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    {
        public int BreadPrice { get; set; }
        public int BreadQuantity { get; set; }
        public int BreadTotal { get; set; }

        public Bread(int breadPrice, int breadQuantity, int breadTotal)
        {
            BreadPrice = 5;
            BreadQuantity = breadQuantity;
            BreadTotal = breadTotal;
        }

        public int BreadDiscount()
        {
            int breadDiscount = 0;
            if (BreadQuantity % 3 == 0)
            {
                breadDiscount = (BreadQuantity / 3) * BreadPrice;
            }
            else if (BreadQuantity % 3 == 1)
            {
                breadDiscount = ((BreadQuantity - 1) / 3) * BreadPrice;
            }
            else if (BreadQuantity % 3 == 2)
            {
                breadDiscount = ((BreadQuantity - 2) / 3) * BreadPrice;
            }
            return breadDiscount;
        }
    }
}