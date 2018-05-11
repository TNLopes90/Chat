using System;
using ChatIDAL;
using NHibernate;

namespace ChatNHibernateDAL
{
  public class CrudDAL<T> : ICrudDAL<T> where T : class
  {
    public void Delete(T aoT)
    {
      using (ISession loSession = NHibernateConnection.OpenSession())
      {
        using (ITransaction loTransaction = loSession.BeginTransaction())
        {
          try
          {
            loSession.Delete(aoT);
            loTransaction.Commit();
          }
          catch (Exception ex)
          {
            if (!loTransaction.WasCommitted)
              loTransaction.Rollback();
            throw new Exception("Fail to Delete" + ex.Message);
          }
        }
      }
    }

    public void Insert(T aoT)
    {
      using(ISession loSession = NHibernateConnection.OpenSession())
      {
        using (ITransaction loTransaction = loSession.BeginTransaction())
        {
          try
          {
            loSession.Save(aoT);
            loTransaction.Commit();
          }
          catch (Exception ex)
          {
            if (!loTransaction.WasCommitted)
              loTransaction.Rollback();
            throw new Exception("Fail to Insert" + ex.Message);
          }
        }
      }
    }

    public T Load(object aoKey)
    {
      using (ISession loSession = NHibernateConnection.OpenSession())
      {
        return loSession.Get<T>(aoKey);
      }
    }

    public void Update(T aoT)
    {
      using (ISession loSession = NHibernateConnection.OpenSession())
      {
        using (ITransaction loTransaction = loSession.BeginTransaction())
        {
          try
          {
            loSession.Update(aoT);
            loTransaction.Commit();
          }
          catch (Exception ex)
          {
            if (!loTransaction.WasCommitted)
              loTransaction.Rollback();
            throw new Exception("Fail to Update" + ex.Message);
          }
        }
      }
    }
  }
}
