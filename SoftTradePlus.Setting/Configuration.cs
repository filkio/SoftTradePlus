using System;
using System.Collections.Generic;
using System.Text;
using SoftTradePlus.Bll;
using SoftTradePlus.Data.Sql;
using SoftTradePlus.DI;
using SimpleInjector;

namespace SoftTradePlus.Setting
{
    public class Configuration
    {
        public Container Container { get; }
        public Configuration()
        {
            Container = new Container();
            Setup();
        }
        public virtual void Setup()
        {
            Container.Register<IClient, Client>(Lifestyle.Transient);
            Container.Register<IGood, Good>(Lifestyle.Transient);
            Container.Register<IManager, Manager>(Lifestyle.Transient);
            Container.Register<ICompany, Company>(Lifestyle.Singleton);
            Container.Register<IData<IClient>, ClientSqlData>(Lifestyle.Singleton);
            Container.Register<IData<IGood>, GoodSqlData>(Lifestyle.Singleton);
            Container.Register<IData<IManager>, ManagerSqlData>(Lifestyle.Singleton);
            Container.Register<ISpecifiedData, SpecifiedSqlData>(Lifestyle.Singleton);
        }
    }
}
