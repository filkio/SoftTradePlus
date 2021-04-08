using System;
using SoftTradePlus.Data.Sql;
using SoftTradePlus.DI;
using SoftTradePlus.Bll;

namespace SoftTradePlus.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlManager = new ManagerSqlData();
            IManager manager = new Manager { Name = "test manager name"};
            sqlManager.Create(manager);
        }
    }
}
