using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftTradePlus.DI;

namespace SoftTradePlus.Data.Sql
{
    public class ManagerSqlData : IData<IManager>
    {
        public void Create(IManager item)
        {
            using (var db = new SoftTradePlusContext())
            {
                var managerAdd = new ManagerEntity(item);
                db.Managers.Add(managerAdd);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new SoftTradePlusContext())
            {
                var managerDelete = db.Managers.Where(m => m.Id == id).FirstOrDefault();
                db.Remove(managerDelete);
                db.SaveChanges();
            }
        }

        public void Update(IManager manager, int id)
        {
            using (var db = new SoftTradePlusContext())
            {
                var managerUpdate = db.Managers.Where(m => m.Id == id).FirstOrDefault();
                managerUpdate.Name = manager.Name;
                db.SaveChanges();
            }
        }
        public IEnumerable<IManager> GetAll()
        {
            using (var db = new SoftTradePlusContext())
            {
                var managers = db.Managers;
                return managers;
            }
        }
    }
}
