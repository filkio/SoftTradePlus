using System;
using System.Collections.Generic;
using System.Text;

namespace SoftTradePlus.DI
{
    public interface IClient
    {
        string Name { get; set; }
        ClientStatus Status { get; set; }
        IManager Manager { get; set; }
        IEnumerable<IGood> PurchasedGoods { get; set; }
    }
}
