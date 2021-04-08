using System;
using System.Collections.Generic;
using System.Text;
using SoftTradePlus.DI;
using System.Linq;

namespace SoftTradePlus.Data.Sql
{
    public class SpecifiedSqlData : ISpecifiedData
    {
        public IEnumerable<IClient> GetClients(IManager manager)
        {
            using (var db = new SoftTradePlusContext())
            {
                ManagerEntity managerEntity = (ManagerEntity)manager;
                var clients = db.Clients.Where(c => c.MyManager == manager).ToList();
                return clients;
            }
        }

        public IEnumerable<IClient> GetClients(ClientStatus status)
        {
            using (var db = new SoftTradePlusContext())
            {
                var clients = db.Clients.Where(c => c.Status == status).ToList();
                return clients;
            }

        }

        public IEnumerable<IGood> GetGoods(int clientId)
        {
            using (var db = new SoftTradePlusContext())
            {
                var goods = db.Goods.Where(g => g.Client.Id == clientId).ToList();
                return goods;
            }
        }
    }
}
