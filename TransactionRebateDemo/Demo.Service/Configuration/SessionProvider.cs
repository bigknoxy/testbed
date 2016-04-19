using System.Configuration;
using Demo.Service.ClassMaps;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Demo.Service.Configuration
{
    public class SessionProvider
    {
        private readonly ISessionFactory _factory;

        public SessionProvider()
        {
            _factory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(ConfigurationManager
                    .ConnectionStrings["TransactionRebateDemo.Properties.Settings.TestConnectionString"].ConnectionString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TransactionClassMap>())
                .ExposeConfiguration(config =>
                {
                    config.SetProperty("adonet.batch_size", "100");
                })
                .BuildSessionFactory();
        }

        public ISessionFactory GetSessionFactory()
        {
            return _factory;
        }
    }
}