using SoftTradePlus.DI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftTradePlus.Bll
{
    public class Company : ICompany
    {
        private readonly IData<IManager> _managerData;
        private readonly IData<IGood> _goodData;
        private readonly IData<IClient> _clientData;
        private readonly ISpecifiedData _specifiedData;
        public Company(IData<IManager> managerData, IData<IGood> goodData, IData<IClient> clientData, ISpecifiedData specifiedData)
        {
            _managerData = managerData;
            _goodData = goodData;
            _clientData = clientData;
            _specifiedData = specifiedData;
        }


        public void CreateClient(IClient item)
        {
            _clientData.Create(item);
        }

        public void CreateGood(IGood item)
        {
            _goodData.Create(item);
        }

        public void CreateManager(IManager item)
        {
            _managerData.Create(item);
        }

        public void DeleteClient(int id)
        {
            _clientData.Delete(id);
        }

        public void DeleteGood(int id)
        {
            _goodData.Delete(id);
        }

        public void DeleteManager(int id)
        {
            _managerData.Delete(id);
        }

        public void UpdateClient(IClient client, int id)
        {
            _clientData.Update(client, id);
        }

        public void UpdateGood(IGood good, int id)
        {
            _goodData.Update(good, id);
        }

        public void UpdateManager(IManager manager, int id)
        {
            _managerData.Update(manager, id);
        }

        public IEnumerable<IClient> GetClients()
        {
            return _clientData.GetAll();
        }

        public IEnumerable<IClient> GetClients(IManager manager)
        {
            return _specifiedData.GetClients(manager);
        }

        public IEnumerable<IClient> GetClients(ClientStatus status)
        {
            return _specifiedData.GetClients(status);
        }

        public IEnumerable<IGood> GetGoods()
        {
            return _goodData.GetAll();
        }

        public IEnumerable<IGood> GetGoods(int clientId)
        {
            return _specifiedData.GetGoods(clientId);
        }

        public IEnumerable<IManager> GetManagers()
        {
            return _managerData.GetAll();
        }

    }
}
