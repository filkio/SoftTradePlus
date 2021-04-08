using System;
using System.Collections.Generic;
using System.Text;

namespace SoftTradePlus.DI
{
    public interface ISpecifiedData
    {
        IEnumerable<IClient> GetClients(IManager manager);
        IEnumerable<IClient> GetClients(ClientStatus status);
        IEnumerable<IGood> GetGoods(int clientId);
    }
}
