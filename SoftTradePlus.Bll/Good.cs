using System;
using System.Collections.Generic;
using System.Text;
using SoftTradePlus.DI;

namespace SoftTradePlus.Bll
{
    public class Good : IGood
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public GoodType Status { get; set; }
        public SubscriptionTerm SubscriptionTerm { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
