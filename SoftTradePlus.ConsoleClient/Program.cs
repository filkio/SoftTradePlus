using SoftTradePlus.DI;
using SoftTradePlus.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using SoftTradePlus.Data.Sql;

namespace SoftTradePlus.ConsoleClient
{
    class Program
    {

        #region DI
        private static Configuration _configuration;

        private static IClient CreateClient(string name, ClientStatus status, IManager manager, IEnumerable<IGood> goods)
        {
            var client = _configuration.Container.GetInstance<IClient>();
            client.Name = name;
            client.Status = status;
            client.Manager = manager;
            client.PurchasedGoods = goods;
            var company = _configuration.Container.GetInstance<ICompany>();
            company.CreateClient(client);
            return client;
        }
        #endregion

        static void Main(string[] args)
        {
            _configuration = new Configuration();
            var company = _configuration.Container.GetInstance<ICompany>();
            IManager manager = company.GetManagers().FirstOrDefault();
            CreateClient("test", ClientStatus.key, manager, null);
            Console.WriteLine("ok!");
        }
    }
}
