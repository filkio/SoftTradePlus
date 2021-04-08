using System;
using System.Collections.Generic;
using System.Text;
using SoftTradePlus.DI;

namespace SoftTradePlus.Data.Sql
{
    public class ClientEntity : IClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ClientStatus Status { get; set; }
        public IManager Manager { get; set; }
        public IEnumerable<IGood> PurchasedGoods { get; set; }
        public ClientEntity()
        {
        }
        public ClientEntity(IClient client)
        {
            Id = 0;
            Name = client.Name;
            Status = client.Status;
            Manager = client.Manager;
            PurchasedGoods = client.PurchasedGoods;
        }
    }
}
