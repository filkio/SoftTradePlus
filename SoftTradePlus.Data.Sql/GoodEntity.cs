using System;
using System.Collections.Generic;
using System.Text;
using SoftTradePlus.DI;

namespace SoftTradePlus.Data.Sql
{
    public class GoodEntity : IGood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public GoodType Status { get; set; }
        public SubscriptionTerm SubscriptionTerm { get; set; }
        public ClientEntity Client { get; set; }
        public GoodEntity()
        {
        }
        public GoodEntity(IGood good)
        {
            Id = 0;
            Name = good.Name;
            Price = good.Price;
            Status = good.Status;
            SubscriptionTerm = good.SubscriptionTerm;
        }
    }
}
