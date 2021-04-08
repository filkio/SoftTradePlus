using System;
using System.Collections.Generic;
using System.Text;
using SoftTradePlus.DI;

namespace SoftTradePlus.Bll
{
    public class Client : IClient
    {
        public string Name { get; set; }
        public ClientStatus Status { get; set; }
        public IManager Manager { get; set; }
        public IEnumerable<IGood> PurchasedGoods { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
