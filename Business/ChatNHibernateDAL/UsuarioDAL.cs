using ChatIDAL;
using ChatModel;

namespace ChatNHibernateDAL
{
  public partial class UsuarioDAL : IUsuarioDAL
  {
    private CrudDAL<Usuario> ioCrud = new CrudDAL<Usuario>();

    public void Delete(Usuario aoUsuario)
    {
      this.ioCrud.Delete(aoUsuario);
    }

    public void Insert(Usuario aoUsuario)
    {
      this.ioCrud.Insert(aoUsuario);
    }

    public Usuario Load(object aoKey)
    {
      return this.ioCrud.Load(aoKey);
    }

    public void Update(Usuario aoUsuario)
    {
      this.ioCrud.Update(aoUsuario);
    }
  }
}
