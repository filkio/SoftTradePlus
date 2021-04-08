using SoftTradePlus.DI;
using SoftTradePlus.Setting;
using System;
using System.Collections.Generic;

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
            CreateClient("test", ClientStatus.key, null, null);
            Console.WriteLine("ok!");
        }
    }
}
