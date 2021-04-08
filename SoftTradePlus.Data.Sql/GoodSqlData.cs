using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftTradePlus.DI;

namespace SoftTradePlus.Data.Sql
{
    public class GoodSqlData : IData<IGood>
    {
        public void Create(IGood item)
        {
            using (var db = new SoftTradePlusContext())
            {
                var goodAdd = new GoodEntity(item);
                db.Goods.Add(goodAdd);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new SoftTradePlusContext())
            {
                var goodDelete = db.Goods.Where(g => g.Id == id).FirstOrDefault();
                db.Remove(goodDelete);
                db.SaveChanges();
            }
        }

        public void Update (IGood good, int id)
        {
            using (var db = new SoftTradePlusContext())
            {
                var goodUpdate = db.Goods.Where(g => g.Id == id).FirstOrDefault();
                goodUpdate.Name = good.Name;
                goodUpdate.Price = good.Price;
                goodUpdate.Status = good.Status;
                goodUpdate.SubscriptionTerm = good.SubscriptionTerm;
                db.SaveChanges();
            }
        }
        public IEnumerable<IGood> GetGoods()
        {
            using (var db = new SoftTradePlusContext())
            {
                var goods = db.Goods;
                return goods;
            }
        }
        public IEnumerable<IGood> GetGoods(int clientId)
        {
            using (var db = new SoftTradePlusContext())
            {
                var goods = db.Goods.Where(g => g.Client.Id == clientId);
                return goods;
            }
        }
    }
}
