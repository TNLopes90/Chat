using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using ChatModel;
using NHibernate.Tool.hbm2ddl;

namespace ChatNHibernateDAL
{
  public class NHibernateConnection
  {
    private static ISessionFactory ioSession;

    private static ISessionFactory CreateSession()
    {
      if (ioSession != null)
        return ioSession;

      FluentConfiguration loConfiguration = Fluently.Configure()
        .Database(MsSqlConfiguration.MsSql2008.ConnectionString(x => x.Server(@"THIAGO\SQLEXPRESS").Username("thiago").Password("123456").Database("Chat")))
        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<UsuarioMap>());

      ioSession = loConfiguration.BuildSessionFactory();

      return ioSession;
    }

    public static ISession OpenSession()
    {
      return CreateSession().OpenSession();
    }
  }
}
