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
    }
}