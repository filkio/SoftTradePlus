using System;
using System.Collections.Generic;
using System.Text;
using SoftTradePlus.DI;

namespace SoftTradePlus.Data.Sql
{
    public class ManagerEntity : IManager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ManagerEntity()
        {
        }
        public ManagerEntity(IManager manager)
        {
            Id = 0;
            Name = manager.Name; 
        }
    }
}
