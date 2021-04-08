using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SoftTradePlus.DI;
using System.Linq;

namespace SoftTradePlus.Data.Sql
{
    public class ClientEntity : IClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ClientStatus Status { get; set; }
        public ManagerEntity MyManager { get; set; }
        public IEnumerable<GoodEntity> MyPurchasedGoods { get; set; }
        [NotMapped]
        public IManager Manager { get; set; }
        [NotMapped]
        public IEnumerable<IGood> PurchasedGoods { get; set; }
        public ClientEntity()
        {
        }
        public ClientEntity(IClient client)
        {
            Id = 0;
            Name = client.Name;
            Status = client.Status;
            MyManager = (ManagerEntity)client.Manager;
            MyPurchasedGoods = (IEnumerable<GoodEntity>)client.PurchasedGoods;
           // Manager = client.Manager;
           // PurchasedGoods = client.PurchasedGoods;
        }
    }
}
