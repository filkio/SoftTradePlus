using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftTradePlus.DI;

namespace SoftTradePlus.Data.Sql
{
    public class ClientSqlData : IData<IClient>
    {
        public void Create(IClient item)
        {
            using (var db = new SoftTradePlusContext())
            {
                var clientAdd = new ClientEntity(item);
                db.Clients.Add(clientAdd);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new SoftTradePlusContext())
            {
                var clientDelete = db.Clients.Where(c => c.Id == id).FirstOrDefault();
                db.Remove(clientDelete);
                db.SaveChanges();
            }
        }

        public void Update(IClient client, int id)
        {
            using (var db = new SoftTradePlusContext())
            {
                var clientUpdate = db.Clients.Where(c => c.Id == id).FirstOrDefault();
                clientUpdate.Manager = client.Manager;
                clientUpdate.Name = client.Name;
                clientUpdate.PurchasedGoods = client.PurchasedGoods;
                clientUpdate.Status = client.Status;
                db.SaveChanges();
            }
        }
        public IEnumerable<IClient> GetAll()
        {
            using (var db = new SoftTradePlusContext())
            {
                var clients = db.Clients;
                return clients;
            }
        }
        public IEnumerable<IClient> GetClients(IManager manager)
        {
            using (var db = new SoftTradePlusContext())
            {
                var clients = db.Clients.Where(c => c.Manager == manager);
                return clients;
            }
        }
        public IEnumerable<IClient> GetClients(ClientStatus status)
        {
            using (var db = new SoftTradePlusContext())
            {
                var clients = db.Clients.Where(c => c.Status == status);
                return clients;
            }
        }
    }
}
