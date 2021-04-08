using System;
using System.Collections.Generic;
using System.Text;

namespace SoftTradePlus.DI
{
    public interface IGood
    {
        string Name { get; set; }
        decimal Price { get; set; }
        GoodType Status { get; set; }
        SubscriptionTerm SubscriptionTerm { get; set; }
    }
}
