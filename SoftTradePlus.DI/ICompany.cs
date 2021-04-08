using System;
using System.Collections.Generic;
using System.Text;

namespace SoftTradePlus.DI
{
    public interface ICompany
    {
        void CreateClient(IClient item);
        void CreateGood(IGood item);
        void CreateManager(IManager item);

        void DeleteClient(int id);
        void DeleteGood(int id);
        void DeleteManager(int id);

        void UpdateClient(IClient client, int id);
        void UpdateGood(IGood good, int id);
        void UpdateManager(IManager manager, int id);


        IEnumerable<IManager> GetManagers();
        IEnumerable<IClient> GetClients();
        IEnumerable<IClient> GetClients(IManager manager);
        IEnumerable<IClient> GetClients(ClientStatus status);
        IEnumerable<IGood> GetGoods();
        IEnumerable<IGood> GetGoods(int clientId);
    }
}
