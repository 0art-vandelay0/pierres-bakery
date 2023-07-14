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

        // public int PastryDiscount()
        // {
        //     //
        // }
    }

}