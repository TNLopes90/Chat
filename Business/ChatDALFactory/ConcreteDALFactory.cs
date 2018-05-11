using System;
using System.Reflection;

namespace ChatDALFactory
{
  [DALFactory]
  public partial class ConcreteDALFactory
  {
    public static ChatIDAL.IMensagemDAL CreateMensagemDAL()
    {
      string path = "ChatNHibernateDAL";
      string className = path + ".MensagemDAL";
      return (ChatIDAL.IMensagemDAL)Assembly.Load(path).CreateInstance(className);
    }

    public static ChatIDAL.IUsuarioDAL CreateUsuarioDAL()
    {
      string path = "ChatNHibernateDAL";
      string className = path + ".UsuarioDAL";
      return (ChatIDAL.IUsuarioDAL)Assembly.Load(path).CreateInstance(className);
    }
  }

  [AttributeUsage(AttributeTargets.Class)]
  public class DALFactoryAttribute : Attribute
  {
  }

}
